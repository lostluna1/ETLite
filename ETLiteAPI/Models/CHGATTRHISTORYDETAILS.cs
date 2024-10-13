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
	public partial class CHGATTRHISTORYDETAILS {

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)", IsPrimary = true, IsNullable = false)]
		public string CHGATTRHISTORYDETAILSID { get; set; }

		[JsonProperty]
		public uint? CDOTYPEID { get; set; }

		[JsonProperty]
		public uint? CHANGECOUNT { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string CHGATTRHISTORYID { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(36 BYTE)")]
		public string EXPORTIMPORTKEY { get; set; }

		[JsonProperty]
		public uint? FIELDID { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(255 BYTE)")]
		public string FIELDNAME { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string HISTORYID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string INTEGRATIONTXNID { get; set; }

		[JsonProperty]
		public uint? NEWBOOLEANVALUE { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(255 BYTE)")]
		public string NEWDISPLAYVALUE { get; set; }

		[JsonProperty, Column(DbType = "NUMBER(22)")]
		public decimal? NEWDURATIONVALUE { get; set; }

		[JsonProperty, Column(DbType = "NUMBER(22)")]
		public decimal? NEWFIXEDVALUE { get; set; }

		[JsonProperty, Column(DbType = "NUMBER(22)")]
		public decimal? NEWFLOATVALUE { get; set; }

		[JsonProperty]
		public uint? NEWINTEGERVALUE { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string NEWOBJECTID { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(2000 BYTE)")]
		public string NEWSTRINGVALUE { get; set; }

		[JsonProperty, Column(DbType = "DATE(7)")]
		public DateTime? NEWTIMESTAMPVALUE { get; set; }

		[JsonProperty]
		public uint? OLDBOOLEANVALUE { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(255 BYTE)")]
		public string OLDDISPLAYVALUE { get; set; }

		[JsonProperty, Column(DbType = "NUMBER(22)")]
		public decimal? OLDDURATIONVALUE { get; set; }

		[JsonProperty, Column(DbType = "NUMBER(22)")]
		public decimal? OLDFIXEDVALUE { get; set; }

		[JsonProperty, Column(DbType = "NUMBER(22)")]
		public decimal? OLDFLOATVALUE { get; set; }

		[JsonProperty]
		public uint? OLDINTEGERVALUE { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string OLDOBJECTID { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(2000 BYTE)")]
		public string OLDSTRINGVALUE { get; set; }

		[JsonProperty, Column(DbType = "DATE(7)")]
		public DateTime? OLDTIMESTAMPVALUE { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string TXNID { get; set; }

	}

}
