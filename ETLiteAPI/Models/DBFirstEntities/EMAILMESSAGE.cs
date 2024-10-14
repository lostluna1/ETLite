using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class EMAILMESSAGE {

		public string EMAILMESSAGEID { get; set; }

		public uint? CDOTYPEID { get; set; }

		public uint? CHANGECOUNT { get; set; }

		public string CHANGEHISTORYID { get; set; }

		public string DESCRIPTION { get; set; }

		public string EMAILMESSAGENAME { get; set; }

		public string FILTERTAGS { get; set; }

		public uint? ICONID { get; set; }

		public uint? ISFROZEN { get; set; }

		public string MESSAGE { get; set; }

		public uint? MESSAGEFORMAT { get; set; }

		public string NOTES { get; set; }

		public uint? SENDEMAILONTXNFAILURE { get; set; }

		public string SENDER { get; set; }

		public string SETUPACCESSID { get; set; }

		public string SUBJECT { get; set; }

	}

}
