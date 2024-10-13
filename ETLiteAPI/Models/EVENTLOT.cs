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
	public partial class EVENTLOT {

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)", IsPrimary = true, IsNullable = false)]
		public string EVENTLOTID { get; set; }

		[JsonProperty]
		public uint? CDOTYPEID { get; set; }

		[JsonProperty]
		public uint? CHANGECOUNT { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string CHARGETOSTEPID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string CONTAINERID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string EVENTDATAID { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(36 BYTE)")]
		public string EXPORTIMPORTKEY { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(30 BYTE)")]
		public string FACTORYNAME { get; set; }

		[JsonProperty]
		public uint? ISCONTAINER { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(30 BYTE)")]
		public string LOT { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(30 BYTE)")]
		public string OPERATIONNAME { get; set; }

		[JsonProperty, Column(DbType = "DATE(7)")]
		public DateTime? ORIGINALSTARTDATE { get; set; }

		[JsonProperty]
		public uint? PLACEONHOLD { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(255 BYTE)")]
		public string PRODUCTDESCRIPTION { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(100 BYTE)")]
		public string PRODUCTNAME { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(15 BYTE)")]
		public string PRODUCTREV { get; set; }

		[JsonProperty, Column(DbType = "NUMBER(22)")]
		public decimal? QTY { get; set; }

		[JsonProperty, Column(DbType = "NUMBER(22)")]
		public decimal? QTYDEFECTIVE { get; set; }

		[JsonProperty, Column(DbType = "NUMBER(22)")]
		public decimal? QTYSAMPLED { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(30 BYTE)")]
		public string REFERENCEDESIGNATOR { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string TASKID { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(30 BYTE)")]
		public string UOMNAME { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(30 BYTE)")]
		public string WORKCENTERNAME { get; set; }

	}

}
