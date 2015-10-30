using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Security;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfFaultsLib
{
    public class SampleService : ISampleService
    {
        #region ISampleService Members

        /// <summary>
        /// A sample method that lets us test faults.
        /// </summary>
        /// <param name="msg">Message that gets concatenated to the service return, or fault.</param>
        /// <returns>Returns a success or error message depending on a random number generator.</returns>
        public string SampleMethod(string msg)
        {
            Console.WriteLine("Client said: " + msg);

            // Generate intermittent error behavior
            Random rnd = new Random(DateTime.Now.Millisecond);

            int test = rnd.Next(5);

            if (test % 2 != 0)
            {
                return "The service greets you: " + msg;
            }
            else
            {
                throw new FaultException<GreetingFault>(new GreetingFault("A greeting error occurred. You said: " + msg));
            }
        }

        #endregion
    }

    /// <summary>
    /// Greeting Fault
    /// </summary>
    [DataContractAttribute]
    public class GreetingFault
    {
        private string report;

        public GreetingFault(string message)
        {
            this.report = message;
        }

        [DataMemberAttribute]
        public string Message
        {
            get { return this.report; }
            set { this.report = value; }
        }
    }
}
