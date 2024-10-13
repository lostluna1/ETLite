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
	public partial class DATAPOINT {

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)", IsPrimary = true, IsNullable = false)]
		public string DATAPOINTID { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(255 BYTE)")]
		public string ATTRIBUTENAME { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(30 BYTE)")]
		public string BOOLEANFALSE { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(30 BYTE)")]
		public string BOOLEANTRUE { get; set; }

		[JsonProperty]
		public uint? CDOTYPEID { get; set; }

		[JsonProperty]
		public uint? CHANGECOUNT { get; set; }

		[JsonProperty]
		public uint? COLUMNPOSITION { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string DATACOLLECTIONDEFID { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(256 BYTE)")]
		public string DATAPOINTNAME { get; set; }

		[JsonProperty]
		public uint? DATATYPE { get; set; }

		[JsonProperty]
		public uint? DECIMALSCALE { get; set; }

		[JsonProperty]
		public uint? DISPLAYLIMITS { get; set; }

		[JsonProperty]
		public uint? DISPLAYMODE { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(36 BYTE)")]
		public string EXPORTIMPORTKEY { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string FAILUREHOLDREASONID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string FAILURERESOURCESTATUSCODEID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string FAILURERESOURCESTATUSREASONID { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(30 BYTE)")]
		public string INNERLOWERLIMIT { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(30 BYTE)")]
		public string INNERUPPERLIMIT { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string ISDEFECTREASONID { get; set; }

		[JsonProperty]
		public uint? ISFROZEN { get; set; }

		[JsonProperty]
		public uint? ISLIMITOVERRIDEALLOWED { get; set; }

		[JsonProperty]
		public uint? ISREQUIRED { get; set; }

		[JsonProperty]
		public uint? ISREQUIREDEFECTREASON { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(255 BYTE)")]
		public string LISTFIELDEXPRESSION { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(255 BYTE)")]
		public string LOWERLIMIT { get; set; }

		[JsonProperty]
		public uint? MAPTOUSERATTRIBUTE { get; set; }

		[JsonProperty]
		public uint? MINIMUMSAMPLES { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string OBJECTGROUPID { get; set; }

		[JsonProperty]
		public uint? OBJECTSELVALTYPE { get; set; }

		[JsonProperty]
		public uint? OBJECTTYPE { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(30 BYTE)")]
		public string OUTERLOWERLIMIT { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(30 BYTE)")]
		public string OUTERUPPERLIMIT { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(255 BYTE)")]
		public string QUERYNAME { get; set; }

		[JsonProperty]
		public uint? QUERYTYPE { get; set; }

		[JsonProperty]
		public uint? ROUNDINGRULE { get; set; }

		[JsonProperty]
		public uint? ROWPOSITION { get; set; }

		[JsonProperty]
		public uint? SEQUENCE { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string UOMID { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(255 BYTE)")]
		public string UPPERLIMIT { get; set; }

	}

}
