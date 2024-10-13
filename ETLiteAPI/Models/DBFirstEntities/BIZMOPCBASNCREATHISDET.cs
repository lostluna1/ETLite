using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models {

	[JsonObject(MemberSerialization.OptIn), Table(Name = "BIZ_MOPCBASNCREATHISDET", DisableSyncStructure = true)]
	public partial class BIZMOPCBASNCREATHISDET {

		[JsonProperty, Column(Name = "BIZ_MOPCBASNCREATHISDETID", DbType = "CHAR(16 BYTE)", IsPrimary = true, IsNullable = false)]
		public string BIZMOPCBASNCREATHISDETID { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(40 BYTE)")]
		public string BGADATA { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(40 BYTE)")]
		public string BGALOT { get; set; }

		[JsonProperty, Column(Name = "BIZ_MOPCBASNCREATHISDETNAME", DbType = "VARCHAR2(36 BYTE)")]
		public string BIZMOPCBASNCREATHISDETNAME { get; set; }

		[JsonProperty, Column(Name = "BIZ_MOPCBASNCREATHISID", DbType = "CHAR(16 BYTE)")]
		public string BIZMOPCBASNCREATHISID { get; set; }

		[JsonProperty]
		public uint? CDOTYPEID { get; set; }

		[JsonProperty]
		public uint? CHANGECOUNT { get; set; }

		[JsonProperty]
		public uint? CRTRULECODE { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string HISTORYID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string INTEGRATIONTXNID { get; set; }

		[JsonProperty]
		public uint? ISLASER { get; set; }

		[JsonProperty]
		public uint? ISUPLOAD { get; set; }

		[JsonProperty, Column(DbType = "DATE(7)")]
		public DateTime? LASERTIME { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(100 BYTE)")]
		public string PANELID { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(40 BYTE)")]
		public string PCBASN { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(100 BYTE)")]
		public string PCSID { get; set; }

		[JsonProperty]
		public uint? PRIORITY { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(40 BYTE)")]
		public string SERIALCODE { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string TXNID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string UPLOADEMPLOYEEID { get; set; }

		[JsonProperty, Column(DbType = "DATE(7)")]
		public DateTime? UPLOADTIME { get; set; }

	}

}
