using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class CIOBUFFER {

		public string CIOBUFFERID { get; set; }

		public uint? BUFFERINTERVAL { get; set; }

		public uint? CDOTYPEID { get; set; }

		public uint? CHANGECOUNT { get; set; }

		public string CHANGEHISTORYID { get; set; }

		public string CIOBUFFERKIND { get; set; }

		public string CIOBUFFERNAME { get; set; }

		public string CONNECTIONNAME { get; set; }

		public string CONNECTIONSTRING { get; set; }

		public string DESCRIPTION { get; set; }

		public uint? EXPIRYINTERVAL { get; set; }

		public string FILTERTAGS { get; set; }

		public uint? ICONID { get; set; }

		public uint? ISFROZEN { get; set; }

		public uint? MAXCOUNT { get; set; }

		public uint? MAXSIZE { get; set; }

		public string NOTES { get; set; }

		public string SETUPACCESS { get; set; }

	}

}
