using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models {

	[JsonObject(MemberSerialization.OptIn), Table(DisableSyncStructure = true)]
	public partial class CONTAINERSAMPLEDATA {

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)", IsPrimary = true, IsNullable = false)]
		public string CONTAINERSAMPLEDATAID { get; set; }

		[JsonProperty]
		public uint? ALLOWEDREJECTS { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string AQLLEVELID { get; set; }

		[JsonProperty]
		public uint? CDOTYPEID { get; set; }

		[JsonProperty]
		public uint? CHANGECOUNT { get; set; }

		[JsonProperty]
		public uint? COMPLETEDSAMPLES { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string CONTAINERID { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(36 BYTE)")]
		public string EXPORTIMPORTKEY { get; set; }

		[JsonProperty]
		public uint? INSPECTALLCONTQTY { get; set; }

		[JsonProperty]
		public uint? INSPECTALLQTYONFAILURE { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string INSPECTIONLEVELID { get; set; }

		[JsonProperty]
		public uint? REJECTS { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string SAMPLETESTID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string SAMPLINGPLANID { get; set; }

		[JsonProperty]
		public uint? TOTALSAMPLESREQUIRED { get; set; }

	}

}
