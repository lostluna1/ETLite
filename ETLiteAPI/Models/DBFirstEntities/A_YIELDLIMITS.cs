using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class A_YIELDLIMITS {

		public string YIELDLIMITSID { get; set; }

		public uint? CDOTYPEID { get; set; }

		public uint? CHANGECOUNT { get; set; }

		public string CHANGEHISTORYID { get; set; }

		public string DESCRIPTION { get; set; }

		public string FAILUREEMAILGROUPID { get; set; }

		public string FAILUREHOLDREASONID { get; set; }

		public string FILTERTAGS { get; set; }

		public uint? ICONID { get; set; }

		public uint? ISFROZEN { get; set; }

		public string NOTES { get; set; }

		public string OWNERID { get; set; }

		public string PRODUCTFAMILYID { get; set; }

		public string PRODUCTID { get; set; }

		public string RESOURCEFAMILYID { get; set; }

		public string SETUPACCESSID { get; set; }

		public string SPECID { get; set; }

		public string YIELDLIMITSNAME { get; set; }

	}

}
