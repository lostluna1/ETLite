using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class BIZIPQCINSPECTIONTASKTEST {

		[JsonProperty, Column(Name = "BIZ_IPQCINSPECTIONTASKTESTID", DbType = "CHAR(16 BYTE)", IsPrimary = true, IsNullable = false)]
		public string BIZIPQCINSPECTIONTASKTESTID { get; set; }

		[JsonProperty, Column(Name = "BIZ_IPQCINSPECTIONTASKID", DbType = "CHAR(16 BYTE)")]
		public string BIZIPQCINSPECTIONTASKID { get; set; }

		[JsonProperty, Column(Name = "BIZ_IPQCINSPECTIONTASKTESTNAME", DbType = "VARCHAR2(36 BYTE)")]
		public string BIZIPQCINSPECTIONTASKTESTNAME { get; set; }

		[JsonProperty, Column(Name = "BIZ_IPQCSHIFTID", DbType = "CHAR(16 BYTE)")]
		public string BIZIPQCSHIFTID { get; set; }

		[JsonProperty]
		public uint? CDOTYPEID { get; set; }

		[JsonProperty]
		public uint? CHANGECOUNT { get; set; }

		[JsonProperty]
		public uint? ISFROZEN { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string RESOURCEID { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(64 BYTE)")]
		public string SAMPLETEST { get; set; }

	}

}
