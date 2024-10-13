using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models {

	[JsonObject(MemberSerialization.OptIn), Table(Name = "ES_PROCESSPREPDETAILLIST", DisableSyncStructure = true)]
	public partial class ESPROCESSPREPDETAILLIST {

		[JsonProperty, Column(Name = "ES_PROCESSPREPDETAILLISTID", DbType = "CHAR(16 BYTE)", IsPrimary = true, IsNullable = false)]
		public string ESPROCESSPREPDETAILLISTID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string BASEOBJECTID { get; set; }

		[JsonProperty]
		public uint? CDOTYPEID { get; set; }

		[JsonProperty]
		public uint? CHANGECOUNT { get; set; }

		[JsonProperty, Column(Name = "ES_ANGLE", DbType = "NUMBER(22)")]
		public decimal? ESANGLE { get; set; }

		[JsonProperty, Column(Name = "ES_PLACEMENTTIMEINMSEC")]
		public uint? ESPLACEMENTTIMEINMSEC { get; set; }

		[JsonProperty, Column(Name = "ES_PROCESSPREPDETAILLISTNAME", DbType = "VARCHAR2(36 BYTE)")]
		public string ESPROCESSPREPDETAILLISTNAME { get; set; }

		[JsonProperty, Column(Name = "ES_PRODUCTID", DbType = "CHAR(16 BYTE)")]
		public string ESPRODUCTID { get; set; }

		[JsonProperty, Column(Name = "ES_QTY", DbType = "NUMBER(22)")]
		public decimal? ESQTY { get; set; }

		[JsonProperty, Column(Name = "ES_REFDES", DbType = "VARCHAR2(30 BYTE)")]
		public string ESREFDES { get; set; }

		[JsonProperty, Column(Name = "ES_XMM", DbType = "NUMBER(22)")]
		public decimal? ESXMM { get; set; }

		[JsonProperty, Column(Name = "ES_YMM", DbType = "NUMBER(22)")]
		public decimal? ESYMM { get; set; }

		[JsonProperty]
		public uint? ISFROZEN { get; set; }

	}

}
