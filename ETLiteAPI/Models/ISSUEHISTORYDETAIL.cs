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
	public partial class ISSUEHISTORYDETAIL {

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)", IsPrimary = true, IsNullable = false)]
		public string ISSUEHISTORYDETAILID { get; set; }

		[JsonProperty, Column(DbType = "NUMBER(22)")]
		public decimal? ACTUALQTY2ISSUED { get; set; }

		[JsonProperty, Column(DbType = "NUMBER(22)")]
		public decimal? ACTUALQTYISSUED { get; set; }

		[JsonProperty]
		public uint? ALLOWMANUALWEIGHOVERRIDE { get; set; }

		[JsonProperty]
		public uint? CDOTYPEID { get; set; }

		[JsonProperty]
		public uint? CHANGECOUNT { get; set; }

		[JsonProperty]
		public uint? CLOSEWHENEMPTY { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string COMPONENTISSUEHISTORYID { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(36 BYTE)")]
		public string EXPORTIMPORTKEY { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string HISTORYID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string INTEGRATIONTXNID { get; set; }

		[JsonProperty]
		public uint? ISMANUALREADINGONLY { get; set; }

		[JsonProperty]
		public uint? ISSUECONTROL { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string ISSUEDIFFERENCEREASONID { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(2000 BYTE)")]
		public string NOTES { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string PRODUCTID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string PRODUCTMATERIALLISTITEMID { get; set; }

		[JsonProperty, Column(DbType = "NUMBER(22)")]
		public decimal? QTY2REQUIRED { get; set; }

		[JsonProperty, Column(DbType = "NUMBER(22)")]
		public decimal? QTYLOWERLIMIT { get; set; }

		[JsonProperty, Column(DbType = "NUMBER(22)")]
		public decimal? QTYREQUIRED { get; set; }

		[JsonProperty, Column(DbType = "NUMBER(22)")]
		public decimal? QTYUPPERLIMIT { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(30 BYTE)")]
		public string REFERENCEDESIGNATOR { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string TXNID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string UOM2ID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string UOMID { get; set; }

	}

}
