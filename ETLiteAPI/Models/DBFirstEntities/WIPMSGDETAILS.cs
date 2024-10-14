using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class WIPMSGDETAILS {

		public string WIPMSGDETAILSID { get; set; }

		public uint? ACKNOWLEDGMENTREQUIRED { get; set; }

		public uint? CDOTYPEID { get; set; }

		public uint? CHANGECOUNT { get; set; }

		public string CHANGESTATUSID { get; set; }

		public string CONTACTINFO { get; set; }

		public DateTime? CREATIONDATE { get; set; }

		public DateTime? CREATIONDATEGMT { get; set; }

		public string DOCUMENTBASEID { get; set; }

		public string DOCUMENTID { get; set; }

		public DateTime? EFFECTIVEFROMDATE { get; set; }

		public DateTime? EFFECTIVEFROMDATEGMT { get; set; }

		public DateTime? EFFECTIVETHRUDATE { get; set; }

		public DateTime? EFFECTIVETHRUDATEGMT { get; set; }

		public string EXPORTIMPORTKEY { get; set; }

		public string HOLDREASONID { get; set; }

		public uint? ISFROZEN { get; set; }

		public string MSGACTIONID { get; set; }

		public string MSGTEXT { get; set; }

		public string NOTIFICATIONTEXT { get; set; }

		public string PARENTID { get; set; }

		public uint? PASSWORDREQUIRED { get; set; }

		public uint? RELEVANTSERVICETYPE { get; set; }

		public uint? SENDNOTIFICATION { get; set; }

		public uint? STATUS { get; set; }

		public uint? STOPPROCESSING { get; set; }

		public string TEXTVARIABLES { get; set; }

		public uint? TRIGGERACTION { get; set; }

		public string WIPMSGDETAILSNAME { get; set; }

		public string WIPMSGPASSWORD { get; set; }

		public uint? WRITETOHISTORY { get; set; }

	}

}
