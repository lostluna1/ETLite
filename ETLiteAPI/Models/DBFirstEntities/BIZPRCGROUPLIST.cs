using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class BIZPRCGROUPLIST {

		[JsonProperty, Column(Name = "BIZ_PRCGROUPLISTID", DbType = "CHAR(16 BYTE)", IsPrimary = true, IsNullable = false)]
		public string BIZPRCGROUPLISTID { get; set; }

		[JsonProperty, Column(Name = "BIZ_PRCGROUPID", DbType = "CHAR(16 BYTE)")]
		public string BIZPRCGROUPID { get; set; }

		[JsonProperty, Column(Name = "BIZ_PRCGROUPLISTNAME", DbType = "VARCHAR2(256 BYTE)")]
		public string BIZPRCGROUPLISTNAME { get; set; }

		[JsonProperty, Column(Name = "BIZ_PRODUCTRESOURCECHECKID", DbType = "CHAR(16 BYTE)")]
		public string BIZPRODUCTRESOURCECHECKID { get; set; }

		[JsonProperty]
		public uint? CDOTYPEID { get; set; }

		[JsonProperty]
		public uint? CHANGECOUNT { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(36 BYTE)")]
		public string EXPORTIMPORTKEY { get; set; }

		[JsonProperty]
		public uint? ISFROZEN { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string RESOURCEFAMILYID { get; set; }

	}

}
