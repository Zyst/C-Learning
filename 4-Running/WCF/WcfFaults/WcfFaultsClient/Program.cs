using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using WcfFaultsClient.ServiceReference1;
using WcfFaultsLib;

namespace WcfFaultsClient
{
    class Program
    {
        static void Main(string[] args)
        {
            SampleServiceClient client = new SampleServiceClient();

            try
            {
                for (int i = 0; i < 10; i++)
                {
                    // This will post (In the service):

                    // "Hey! Test #x" until an exception happens or it goes 10 times without an exception.
                    string test = client.SampleMethod("Test #" + i);

                    Console.WriteLine(test);
                }
            }
            catch (TimeoutException timeProblem)
            {
                Console.WriteLine("The service operation timed out. " + timeProblem.Message);
                Console.ReadLine();
                client.Abort();
            }
            catch (FaultException<GreetingFault> greetingFault)
            {
                Console.WriteLine(greetingFault.Detail.Message);
                Console.ReadLine();
                client.Abort();
            }
            catch (FaultException unknownFault)
            {
                Console.WriteLine("An unknown exception was received. " + unknownFault.Message);
                Console.ReadLine();
                client.Abort();
            }
            catch (CommunicationException commProblem)
            {
                Console.WriteLine("There was a communication problem. " + commProblem.Message + commProblem.StackTrace);
                Console.ReadLine();
                client.Abort();
            }
            finally
            {
                client.Close();
            }
        }
    }
}
