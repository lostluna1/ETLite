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
	public partial class CIODATAHUBSUBSCRIPTIONS {

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)", IsPrimary = true, IsNullable = false)]
		public string CIODATAHUBSUBSCRIPTIONID { get; set; }

		[JsonProperty]
		public uint? CDOTYPEID { get; set; }

		[JsonProperty]
		public uint? CHANGECOUNT { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string CIODATAHUBADAPTERID { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(30 BYTE)")]
		public string CIODATAHUBSUBSCRIPTIONNAME { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(36 BYTE)")]
		public string EXPORTIMPORTKEY { get; set; }

		[JsonProperty]
		public uint? ISACTIVE { get; set; }

		[JsonProperty]
		public uint? ISFROZEN { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(20 BYTE)")]
		public string TRIGGERCOMPARISON { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(500 BYTE)")]
		public string TRIGGERFULLNAME { get; set; }

		[JsonProperty]
		public uint? TRIGGERINTERVAL { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(255 BYTE)")]
		public string TRIGGERPROPERTY { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(500 BYTE)")]
		public string TRIGGERTARGET { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(255 BYTE)")]
		public string TRIGGERTYPE { get; set; }

	}

}
