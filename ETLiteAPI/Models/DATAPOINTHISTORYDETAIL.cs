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
	public partial class DATAPOINTHISTORYDETAIL {

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)", IsPrimary = true, IsNullable = false)]
		public string DATAPOINTHISTORYDETAILID { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(255 BYTE)")]
		public string ATTRIBUTENAME { get; set; }

		[JsonProperty]
		public uint? BOOLEANVALUE { get; set; }

		[JsonProperty]
		public uint? CDOTYPEID { get; set; }

		[JsonProperty]
		public uint? CHANGECOUNT { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(2000 BYTE)")]
		public string COMMENTS { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string DATACOLLECTIONDEFID { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(255 BYTE)")]
		public string DATANAME { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string DATAPOINTHISTORYID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string DATAPOINTID { get; set; }

		[JsonProperty]
		public uint? DATATYPE { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(1000 BYTE)")]
		public string DATAVALUE { get; set; }

		[JsonProperty]
		public uint? DECIMALSCALE { get; set; }

		[JsonProperty, Column(DbType = "NUMBER(19,9)")]
		public decimal? DECIMALVALUE { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(30 BYTE)")]
		public string ENUMERATIONVALUE { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(36 BYTE)")]
		public string EXPORTIMPORTKEY { get; set; }

		[JsonProperty, Column(DbType = "NUMBER(22)")]
		public decimal? FIXEDVALUE { get; set; }

		[JsonProperty, Column(DbType = "NUMBER(22)")]
		public decimal? FLOATVALUE { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string HISTORYID { get; set; }

		[JsonProperty]
		public uint? INTEGERVALUE { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string INTEGRATIONTXNID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string ISDEFECTREASONID { get; set; }

		[JsonProperty]
		public uint? ISLIMITOVERRIDE { get; set; }

		[JsonProperty]
		public uint? ISLIMITOVERRIDEALLOWED { get; set; }

		[JsonProperty]
		public uint? ISLIMITVIOLATION { get; set; }

		[JsonProperty]
		public uint? ISREQUIRED { get; set; }

		[JsonProperty]
		public uint? ISREQUIREDEFECTREASON { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(30 BYTE)")]
		public string LOWERLIMIT { get; set; }

		[JsonProperty]
		public uint? MAPTOUSERATTRIBUTE { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string NDOVALUEID { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(30 BYTE)")]
		public string OBJECTTYPENAME { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(30 BYTE)")]
		public string ORIGINALVALUE { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string RDOVALUEID { get; set; }

		[JsonProperty, Column(DbType = "DATE(7)")]
		public DateTime? TIMESTAMPVALUE { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string TXNID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string UOMID { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(30 BYTE)")]
		public string UPPERLIMIT { get; set; }

	}

}
