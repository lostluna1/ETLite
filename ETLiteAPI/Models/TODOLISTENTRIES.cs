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
	public partial class TODOLISTENTRIES {

		[JsonProperty, Column(DbType = "VARCHAR2(16 BYTE)")]
		public string ACTIVITYPLAN { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(16 BYTE)")]
		public string APPROVALENTRYROLE { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(16 BYTE)")]
		public string APPROVALSHEETPARENT { get; set; }

		[JsonProperty, Column(DbType = "NUMBER(22)")]
		public decimal? APPROVALSTATUS { get; set; }

		[JsonProperty, Column(DbType = "NUMBER(22)")]
		public decimal? APPROVALSUBSTITUTEOPTION { get; set; }

		[JsonProperty]
		public uint? CATEGORY { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string CLASSIFICATIONID { get; set; }

		[JsonProperty, Column(DbType = "NUMBER(22)")]
		public decimal? DATACOLLECTIONDEFINED { get; set; }

		[JsonProperty, Column(DbType = "DATE(7)")]
		public DateTime? DESIGNATEDDATE { get; set; }

		[JsonProperty, Column(DbType = "DATE(7)")]
		public DateTime? DESIGNATEDDATEGMT { get; set; }

		[JsonProperty, Column(DbType = "DATE(7)")]
		public DateTime? DUEDATE { get; set; }

		[JsonProperty, Column(DbType = "DATE(7)")]
		public DateTime? DUEDATEGMT { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string IDENTIFIER { get; set; }

		[JsonProperty]
		public uint? IDENTIFIERCDOTYPE { get; set; }

		[JsonProperty, Column(DbType = "NUMBER(22)")]
		public decimal? IDENTIFIERTYPE { get; set; }

		[JsonProperty, Column(DbType = "NUMBER(22)")]
		public decimal? NOTIFICATIONTYPE { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string ORGANIZATION { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string OWNER { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string PRIORITYLEVEL { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string PROCESSMODEL { get; set; }

		[JsonProperty, Column(DbType = "NUMBER(22)")]
		public decimal? PROCESSSTAGE { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string QUALITYOBJECT { get; set; }

		[JsonProperty, Column(DbType = "NUMBER(22)")]
		public decimal? QUALITYSTATUS { get; set; }

		[JsonProperty, Column(DbType = "DATE(7)")]
		public DateTime? REPORTEDDATE { get; set; }

		[JsonProperty, Column(DbType = "DATE(7)")]
		public DateTime? REPORTEDDATEGMT { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string ROLE { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string SUBCLASSIFICATIONID { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(29 BYTE)")]
		public string TODOLISTITEMTYPE { get; set; }

		[JsonProperty, Column(DbType = "NUMBER(22)")]
		public decimal? TRIAGECOMPLETE { get; set; }

	}

}
