using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models {

	[JsonObject(MemberSerialization.OptIn), Table(Name = "AS_ERPROUTE", DisableSyncStructure = true)]
	public partial class ASERPROUTE {

		[JsonProperty, Column(Name = "BIZ_ACTIVETIME", DbType = "NUMBER(22)")]
		public decimal? BIZACTIVETIME { get; set; }

		[JsonProperty, Column(Name = "BIZ_ATUOM", DbType = "VARCHAR2(30 BYTE)")]
		public string BIZATUOM { get; set; }

		[JsonProperty, Column(Name = "BIZ_BASEUOM", DbType = "VARCHAR2(30 BYTE)")]
		public string BIZBASEUOM { get; set; }

		[JsonProperty, Column(Name = "BIZ_EFFECTIVEFROMDATE", DbType = "DATE(7)")]
		public DateTime? BIZEFFECTIVEFROMDATE { get; set; }

		[JsonProperty, Column(Name = "BIZ_EFFECTIVETHROUGHDATE", DbType = "DATE(7)")]
		public DateTime? BIZEFFECTIVETHROUGHDATE { get; set; }

		[JsonProperty, Column(Name = "BIZ_EQTTIME", DbType = "NUMBER(22)")]
		public decimal? BIZEQTTIME { get; set; }

		[JsonProperty, Column(Name = "BIZ_ETUOM", DbType = "VARCHAR2(30 BYTE)")]
		public string BIZETUOM { get; set; }

		[JsonProperty, Column(Name = "BIZ_MANTIME", DbType = "NUMBER(22)")]
		public decimal? BIZMANTIME { get; set; }

		[JsonProperty, Column(Name = "BIZ_MTUOM", DbType = "VARCHAR2(30 BYTE)")]
		public string BIZMTUOM { get; set; }

		[JsonProperty, Column(Name = "BIZ_PREPARETIME", DbType = "NUMBER(22)")]
		public decimal? BIZPREPARETIME { get; set; }

		[JsonProperty, Column(Name = "BIZ_PRETUOM", DbType = "VARCHAR2(30 BYTE)")]
		public string BIZPRETUOM { get; set; }

		[JsonProperty, Column(Name = "BIZ_PRODCOSTSTIME", DbType = "NUMBER(22)")]
		public decimal? BIZPRODCOSTSTIME { get; set; }

		[JsonProperty, Column(Name = "BIZ_PROTUOM", DbType = "VARCHAR2(30 BYTE)")]
		public string BIZPROTUOM { get; set; }

		[JsonProperty, Column(Name = "BIZ_STAQTY", DbType = "NUMBER(22)")]
		public decimal? BIZSTAQTY { get; set; }

		[JsonProperty, Column(Name = "BIZ_WORKCENTER", DbType = "VARCHAR2(40 BYTE)")]
		public string BIZWORKCENTER { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(255 BYTE)")]
		public string DESCRIPTION { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(30 BYTE)")]
		public string ERPOPERATION { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(30 BYTE)")]
		public string ERPROUTE { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(100 BYTE)")]
		public string PRODUCT { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(15 BYTE)")]
		public string REVISION { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(255 BYTE)")]
		public string ROUTESTEPDESCRIPTION { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(40 BYTE)")]
		public string ROUTESTEPNAME { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(30 BYTE)")]
		public string SEQUENCE { get; set; }

		[JsonProperty]
		public uint? STATUS { get; set; }

	}

}
