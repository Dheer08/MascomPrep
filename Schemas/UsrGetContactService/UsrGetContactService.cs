
namespace UsrGetContactService
{
/*
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Collections.ObjectModel;

using Terrasoft.Common;
using Terrasoft.Core;
using Terrasoft.Core.DB;

using Terrasoft.Configuration;*/
	
	
	 using System;
	using System.Data;
    using System.ServiceModel;
    using System.ServiceModel.Web;
    using System.ServiceModel.Activation;
    using Terrasoft.Web.Common;
    using System.IO;
    using Newtonsoft.Json.Linq;
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using Terrasoft.Core;
    using Terrasoft.Core.Process;
    using Terrasoft.Common;
    using System.Web;
	using Terrasoft.Core.Entities;
    using Terrasoft.Core.DB;
    using System.Reflection;
    using RestSharp.Extensions;
    using System.ComponentModel;
	using System.Runtime.Serialization;
	
	
	
	public class ContactResponse
	{
		Guid id = new Guid();
		string name = "";
		string address = "";
		string city = "";
	
		public Guid Id 
		{
			get {return id;}
			set {id = value;}
		}
		
		public string Name 
		{
			get {return name;}
			set {name = value;}
		}
		
		public string Address 
		{
			get {return address;}
			set {address = value;}
		}
		
		public string City 
		{
			get {return city;}
			set {city = value;}
		}
			
		
	}
	
	[ServiceContract]
	public class UsrGetContactService:BaseService
	{
			/*private SystemUserConnection _systemUserConnection;
        private SystemUserConnection SystemUserConnection {
            get {
                return _systemUserConnection ?? (_systemUserConnection = (SystemUserConnection)AppConnection.SystemUserConnection);
            }
		}*/
		 [OperationContract]
		public ContactResponse  GetContact()
		{	Guid Id = Guid.Parse("c4ed336c-3e9b-40fe-8b82-5632476472b4");
			ContactResponse contact = new ContactResponse();
			var esqContact = new EntitySchemaQuery(UserConnection.EntitySchemaManager, "Contact");
			var Id1 = esqContact.AddColumn("Id");
			var Name=esqContact.AddColumn("Name");
			var Address = esqContact.AddColumn("Address");
			var City = esqContact.AddColumn("City.Name");
			//var filterGroup = new 
			var entity = esqContact.GetEntity(UserConnection,Id);
			contact.Id = entity.GetTypedColumnValue<Guid>("Id1");
			contact.Name = entity.GetTypedColumnValue<string>("Name");
			contact.Address = entity.GetTypedColumnValue<string>("Address");
		//	contact.City = entity.GetTypedColumnValue<string>("City");
			return contact;
			//return Id;
			
		}
	
	}
	
	
}