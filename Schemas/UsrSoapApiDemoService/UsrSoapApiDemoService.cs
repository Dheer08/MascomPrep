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
		public int SoapApiInfo(int number)
		{
			return number;
		}
	
	}
	
	
}