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
	public partial class MFGLOT {

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)", IsPrimary = true, IsNullable = false)]
		public string MFGLOTID { get; set; }

		[JsonProperty]
		public uint? ALLOWADJUSTTOLOTSIZE { get; set; }

		[JsonProperty]
		public uint? CDOTYPEID { get; set; }

		[JsonProperty]
		public uint? CHANGECOUNT { get; set; }

		[JsonProperty, Column(DbType = "DATE(7)")]
		public DateTime? CREATIONDATE { get; set; }

		[JsonProperty]
		public uint? LOTSTATUS { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(30 BYTE)")]
		public string MFGLOTNAME { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string PRODUCTID { get; set; }

		[JsonProperty, Column(DbType = "NUMBER(22)")]
		public decimal? QTY { get; set; }

		[JsonProperty]
		public uint? SAMPLERATE { get; set; }

		[JsonProperty]
		public uint? SAMPLINGCOMPLETED { get; set; }

		[JsonProperty]
		public uint? SAMPLINGPASSED { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string SAMPLINGPLANID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string UOMID { get; set; }

	}

}
