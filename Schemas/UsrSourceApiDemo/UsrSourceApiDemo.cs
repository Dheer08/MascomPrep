 using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
 
namespace SoapApiDemo
{
	[ServiceContract]
    public interface ISoapApiService
    {
        [OperationContract]
        int SoapApiInfo(int number);
    }	
	
	
	
}