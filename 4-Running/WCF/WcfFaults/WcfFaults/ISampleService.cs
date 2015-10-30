using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Security;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfFaultsLib
{
    /// <summary>
    /// Sample Service Interface. 
    /// </summary>
    [ServiceContract(Namespace = "http://Microsoft.ServiceModel.Samples")]
    public interface ISampleService
    {
        [OperationContract]
        [FaultContractAttribute(typeof(GreetingFault), Action = "http://www.contoso.com/GreetingFault")]
        string SampleMethod(string msg);
    }
}
