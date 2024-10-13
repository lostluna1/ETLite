using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models {

	[JsonObject(MemberSerialization.OptIn), Table(Name = "ES_PROCESSPREPDETAILS", DisableSyncStructure = true)]
	public partial class ESPROCESSPREPDETAILS {

		[JsonProperty, Column(Name = "ES_PROCESSPREPDETAILSID", DbType = "CHAR(16 BYTE)", IsPrimary = true, IsNullable = false)]
		public string ESPROCESSPREPDETAILSID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string BASEOBJECTID { get; set; }

		[JsonProperty]
		public uint? CDOTYPEID { get; set; }

		[JsonProperty]
		public uint? CHANGECOUNT { get; set; }

		[JsonProperty, Column(Name = "ES_ANGLE")]
		public uint? ESANGLE { get; set; }

		[JsonProperty, Column(Name = "ES_PLACEMENTTIMEMSEC")]
		public uint? ESPLACEMENTTIMEMSEC { get; set; }

		[JsonProperty, Column(Name = "ES_PROCESSPREPDETAILSNAME", DbType = "VARCHAR2(40 BYTE)")]
		public string ESPROCESSPREPDETAILSNAME { get; set; }

		[JsonProperty, Column(Name = "ES_PRODUCTID", DbType = "CHAR(16 BYTE)")]
		public string ESPRODUCTID { get; set; }

		[JsonProperty, Column(Name = "ES_QTY", DbType = "NUMBER(19,9)")]
		public decimal? ESQTY { get; set; }

		[JsonProperty, Column(Name = "ES_REFDES", DbType = "VARCHAR2(30 BYTE)")]
		public string ESREFDES { get; set; }

		[JsonProperty, Column(Name = "ES_XMM", DbType = "NUMBER(15)")]
		public decimal? ESXMM { get; set; }

		[JsonProperty, Column(Name = "ES_YMM", DbType = "NUMBER(15)")]
		public decimal? ESYMM { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(36 BYTE)")]
		public string EXPORTIMPORTKEY { get; set; }

		[JsonProperty]
		public uint? ISFROZEN { get; set; }

	}

}
