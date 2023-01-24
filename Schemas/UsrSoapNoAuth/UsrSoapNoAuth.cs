 namespace UsrSoapNoAuth
 { 
	 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
	 
	 
	 [ServiceContract]
	 public class UsrSoapNoAuth
	 {
		 
		 [OperationContract]
		 public string SoapNoAuth()
		 {
			 return "No Authentication done";
		 }
		 
	 }
	 
	 
	 
	 
 }