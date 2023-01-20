	using System;
	using System.Collections.Generic;
	using System.Linq;
	using System.Web;
	using System.Web.Services;

namespace SoapApiService
 {
	 

	
	[WebService(Namespace = "http://tempuri.org/")]
	[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
	[System.ComponentModel.ToolboxItem(false)]
	
	 public class SoapAPiService: System.Web.Services.WebService
	 {
	 
	 [WebMethod]
	 public string FirstSoapApi()
	 {
	 return "Hey its Soap!!!";
	 
	 }
	 
	 
	 }
	 
	 
 }