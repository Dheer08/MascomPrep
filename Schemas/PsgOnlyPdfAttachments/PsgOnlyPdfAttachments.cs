 namespace Psg.EntityEventListeners
{
using System;
using Terrasoft.Core.Entities;
using Terrasoft.Core.Entities.Events;
using Terrasoft.Core;
using System.Text;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Web;
using System.IO;
using System.Threading.Tasks;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.ServiceModel.Activation;
using Terrasoft.Core;
using Terrasoft.Core.DB;
using System.Data.SqlClient;
using Terrasoft.Web.Common;
using Terrasoft.Core.Entities;
using System.Collections.Generic;
using Terrasoft.Core.Process;
using System.Net;
using System.Data;
using Terrasoft.Common;
using System.Linq;
using System.Globalization;
using Terrasoft.Messaging.Common;
using Terrasoft.Configuration;
using System.Collections;
	
    [EntityEventListener(SchemaName = "FileLead")]
    public class PsgOnlyPdfAttachments : BaseEntityEventListener
    {
        public override void OnInserting(object sender, EntityBeforeEventArgs e)
        {
			base.OnInserting(sender, e);
			Entity attachement = (Entity)sender;
			string fileName = attachement.GetTypedColumnValue<string>("Name");
			
			if(!(fileName.EndsWith(".jpg")|| fileName.EndsWith(".pdf")))
			{
				e.IsCanceled = true;
				throw new Exception("Restricted!!!");
			}
            
        }
    }
}