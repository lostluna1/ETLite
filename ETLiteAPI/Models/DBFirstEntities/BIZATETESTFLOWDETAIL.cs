using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class BIZATETESTFLOWDETAIL {

		[JsonProperty, Column(Name = "BIZ_ATETESTFLOWDETAILID", DbType = "CHAR(16 BYTE)", IsPrimary = true, IsNullable = false)]
		public string BIZATETESTFLOWDETAILID { get; set; }

		[JsonProperty, Column(Name = "BIZ_ATESTATIONID", DbType = "CHAR(16 BYTE)")]
		public string BIZATESTATIONID { get; set; }

		[JsonProperty, Column(Name = "BIZ_ATETESTFLOWDETAILNAME", DbType = "VARCHAR2(36 BYTE)")]
		public string BIZATETESTFLOWDETAILNAME { get; set; }

		[JsonProperty, Column(Name = "BIZ_ATETESTFLOWID", DbType = "CHAR(16 BYTE)")]
		public string BIZATETESTFLOWID { get; set; }

		[JsonProperty, Column(Name = "BIZ_MODELNAMEID", DbType = "CHAR(16 BYTE)")]
		public string BIZMODELNAMEID { get; set; }

		[JsonProperty]
		public uint? CDOTYPEID { get; set; }

		[JsonProperty]
		public uint? CHANGECOUNT { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(40 BYTE)")]
		public string CURRENTSPEC { get; set; }

		[JsonProperty]
		public uint? ENABLE { get; set; }

		[JsonProperty]
		public uint? ISFROZEN { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(40 BYTE)")]
		public string MODELNAME { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string SPECID { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(40 BYTE)")]
		public string TESTSPEC { get; set; }

	}

}
