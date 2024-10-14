using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class NOTIFICATIONTARGET {

		public string NOTIFICATIONTARGETID { get; set; }

		public uint? CDOTYPEID { get; set; }

		public uint? CHANGECOUNT { get; set; }

		public string CHANGESTATUSID { get; set; }

		public uint? DELIVERYMETHOD { get; set; }

		public string DESCRIPTION { get; set; }

		public string EMAILPROFILE { get; set; }

		public string FILTERTAGS { get; set; }

		public uint? ICONID { get; set; }

		public uint? ISFROZEN { get; set; }

		public string NOTES { get; set; }

		public string NOTIFICATIONTARGETNAME { get; set; }

		public string RECIPIENT { get; set; }

		public string SENDER { get; set; }

		public string SETUPACCESSID { get; set; }

	}

}
