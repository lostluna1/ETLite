using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class AJOBMODELDETAIL {

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)", IsPrimary = true, IsNullable = false)]
		public string JOBMODELDETAILID { get; set; }

		[JsonProperty]
		public uint? ALLOWCOMPLETE { get; set; }

		[JsonProperty]
		public uint? CDOTYPEID { get; set; }

		[JsonProperty]
		public uint? CHANGECOUNT { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string DATACOLLECTIONDEFBASEID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string DATACOLLECTIONDEFID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string DOCUMENTSETID { get; set; }

		[JsonProperty]
		public uint? ENFORCECHECKLISTSEQUENCE { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(36 BYTE)")]
		public string EXPORTIMPORTKEY { get; set; }

		[JsonProperty]
		public uint? ISFROZEN { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string JOBMODELID { get; set; }

		[JsonProperty]
		public uint? REQUIRECAUSECODE { get; set; }

		[JsonProperty]
		public uint? REQUIREREPAIRCODE { get; set; }

		[JsonProperty]
		public uint? REQUIRESYMPTOMCODE { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string STAGEID { get; set; }

		[JsonProperty]
		public uint? STAGESEQUENCE { get; set; }

	}

}
