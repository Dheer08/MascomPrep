 using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
namespace SoapApiDemo
{
	public class SoapApiDemo : ISoapApiService
	{
		public SoapResponse SoapApiInfo(SoapResponse _temp1)
		{	
			SoapResponse _temp = new SoapResponse();
			_temp=_temp1;
			return _temp;
		}
	
	}
	
	
}