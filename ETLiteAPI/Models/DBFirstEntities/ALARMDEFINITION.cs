using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class ALARMDEFINITION {

		public string ALARMDEFINITIONID { get; set; }

		public string ACTIONID { get; set; }

		public string ALARMDEFINITIONNAME { get; set; }

		public uint? ALARMICONID { get; set; }

		public uint? ALARMPRIORITY { get; set; }

		public uint? CDOTYPEID { get; set; }

		public uint? CHANGECOUNT { get; set; }

		public string CHANGESTATUSID { get; set; }

		public string DESCRIPTION { get; set; }

		public string DOCUMENTSETID { get; set; }

		public string FILTERTAGS { get; set; }

		public uint? ICONID { get; set; }

		public uint? ISFROZEN { get; set; }

		public string MESSAGETEXT { get; set; }

		public string NOTES { get; set; }

		public string NOTIFICATIONTARGETID { get; set; }

		public string NOTIFICATIONTEXT { get; set; }

		public uint? SENDNOTIFICATION { get; set; }

		public string SETUPACCESSID { get; set; }

		public uint? TRIGGERACTION { get; set; }

	}

}
