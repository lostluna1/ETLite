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
	public partial class LOTSAMPLEDATA {

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)", IsPrimary = true, IsNullable = false)]
		public string LOTSAMPLEDATAID { get; set; }

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
		public string RESOURCEID { get; set; }

		[JsonProperty]
		public uint? SAMPLESFAILED { get; set; }

		[JsonProperty]
		public uint? SAMPLESTESTED { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string SAMPLETESTID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string SAMPLINGLOTID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string SAMPLINGPLANDETAILID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string SAMPLINGPLANID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string SPECID { get; set; }

		[JsonProperty]
		public uint? TOTALSAMPLESREQUIRED { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string VENDORITEMID { get; set; }

	}

}
