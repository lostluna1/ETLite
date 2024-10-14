using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class BIZ_ATETESTITEM {

		public string BIZ_ATETESTITEMID { get; set; }

		public string BIZ_ATETESTITEMNAME { get; set; }

		public uint? CDOTYPEID { get; set; }

		public uint? CHANGECOUNT { get; set; }

		public string CHANGEHISTORYID { get; set; }

		public string DESCRIPTION { get; set; }

		public uint? ENABLE { get; set; }

		public string FILTERTAGS { get; set; }

		public uint? ICONID { get; set; }

		public uint? ISFROZEN { get; set; }

		public string MFGLINEID { get; set; }

		public string MIS_JUDGE_TIME { get; set; }

		public string NOTES { get; set; }

		public string PRODUCT { get; set; }

		public string PRODUCTID { get; set; }

		public string SEQ { get; set; }

		public string SETUPACCESSID { get; set; }

		public string TABLENAME { get; set; }

		public string TEST_ITEM { get; set; }

	}

}
