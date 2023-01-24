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
        SoapResponse SoapApiInfo(SoapResponse _temp1);
    }	
	[DataContract]
	public class SoapResponse
	{
		
		int number = 0;
		string text = "";
		[DataMember]
		public int Number
		{
			
			get {return number;}
			set { number = value;}
		}
		[DataMember]
		public string Text
		{
			
			get {return text;}
			set { text = value;}
		}
		
		
	}
	
	
	
}