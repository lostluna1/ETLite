using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models {

	[JsonObject(MemberSerialization.OptIn), Table(Name = "ES_ISSUEDETAILS", DisableSyncStructure = true)]
	public partial class ESISSUEDETAILS {

		[JsonProperty, Column(DbType = "NUMBER(22)")]
		public decimal? ACTUALQTYISSUED { get; set; }

		[JsonProperty, Column(Name = "ES_FROMLOT2", DbType = "VARCHAR2(255 BYTE)")]
		public string ESFROMLOT2 { get; set; }

		[JsonProperty, Column(Name = "ES_FROMLOT3", DbType = "VARCHAR2(255 BYTE)")]
		public string ESFROMLOT3 { get; set; }

		[JsonProperty, Column(Name = "ES_MOUNTINGTECHNOLOGY")]
		public uint? ESMOUNTINGTECHNOLOGY { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string FROMBATCHID { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(100 BYTE)")]
		public string FROMBATCHNAME { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string FROMCONTAINERID { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(100 BYTE)")]
		public string FROMCONTAINERNAME { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(255 BYTE)")]
		public string FROMLOT { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(100 BYTE)")]
		public string FROMPRIMARYSERIALNUMBER { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(30 BYTE)")]
		public string FROMSTOCKPOINT { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(100 BYTE)")]
		public string IDENTIFIER { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)", IsNullable = false)]
		public string ISSUEACTUALSHISTORYID { get; set; }

		[JsonProperty]
		public uint? ISSUECONTROL { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string ISSUEHISTORYDETAILID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string PRODUCTID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string PRODUCTMATERIALLISTITEMID { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(100 BYTE)")]
		public string PRODUCTNAME { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(25 BYTE)")]
		public string PRODUCTREVISION { get; set; }

		[JsonProperty, Column(DbType = "NUMBER(22)")]
		public decimal? QTY { get; set; }

		[JsonProperty, Column(DbType = "NUMBER(22)")]
		public decimal? QTYREQUIRED { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(30 BYTE)")]
		public string REFERENCEDESIGNATOR { get; set; }

	}

}
