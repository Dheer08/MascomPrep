using System.IO;
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
    //using System.IO;
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
	using System.Xml; 
	using System.Xml.Linq;
	
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
	
	public class Student
	{
		public string Name{get;set;}
		public string Location {get;set;}
		
	}
	 public class ListStudents
	 {
		 public List<Student> Stud{get;set;}
		 
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
		public List<Student> GetContact(Stream data)
		{	//Guid Id = Guid.Parse("c4ed336c-3e9b-40fe-8b82-5632476472b4");
			//Id= "Hii";
			//var sr = new StreamReader(data);
			//var content = sr.ReadToEnd();
			
		/*	if (data.Postition > 0)
			{
			data.Position = 0;
			}*/
			string temp = "";
		XDocument document = XDocument.Load(data);
		List<Student> listOfStudents = new List<Student>();
		
		 foreach (XElement element in document.Descendants("Student"))
        {
         	   
			// temp = temp+ element.Element("Name").Value;
			Student stu = new Student();
			stu.Name =  element.Element("Name").Value;
			stu.Location = element.Element("Location").Value;
			
			listOfStudents.Add(stu);
        }
		
			return listOfStudents;
			
		/*	ContactResponse contact = new ContactResponse();
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
	*/		
		}
	
	}
	
	
}