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
	public partial class CAPA {

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)", IsPrimary = true, IsNullable = false)]
		public string CAPAID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string ATTACHMENTSID { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(100 BYTE)")]
		public string BRIEFDESCRIPTION { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string CAPACUSTOMDATAID { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(30 BYTE)")]
		public string CAPANAME { get; set; }

		[JsonProperty]
		public uint? CARRESOLUTIONACTION { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string CARSEVERITYID { get; set; }

		[JsonProperty]
		public uint? CATEGORY { get; set; }

		[JsonProperty]
		public uint? CDOTYPEID { get; set; }

		[JsonProperty]
		public uint? CHANGECOUNT { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string CLASSIFICATIONID { get; set; }

		[JsonProperty, Column(DbType = "DATE(7)")]
		public DateTime? CLOSEDATE { get; set; }

		[JsonProperty, Column(DbType = "DATE(7)")]
		public DateTime? CLOSEDATEGMT { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string CLOSEDBYID { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(255 BYTE)")]
		public string CLOSEDESCRIPTION { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(4000 BYTE)")]
		public string DESCRIPTION { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string INITIATORID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string INITIATORORGANIZATIONID { get; set; }

		[JsonProperty]
		public uint? ISFROZEN { get; set; }

		[JsonProperty]
		public uint? ISSUBMITTED { get; set; }

		[JsonProperty, Column(DbType = "DATE(7)")]
		public DateTime? OCCURRENCEDATE { get; set; }

		[JsonProperty, Column(DbType = "DATE(7)")]
		public DateTime? OCCURRENCEDATEGMT { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string ORGANIZATIONID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string ORIGPROCESSMODELTEMPLATEID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string OWNERID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string PRIORITYLEVELID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string PROCESSMODELID { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(255 BYTE)")]
		public string PROPOSEDRESOLUTION { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string QUALITYRESOLUTIONCODEID { get; set; }

		[JsonProperty, Column(DbType = "DATE(7)")]
		public DateTime? REPORTEDDATE { get; set; }

		[JsonProperty, Column(DbType = "DATE(7)")]
		public DateTime? REPORTEDDATEGMT { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string REPORTERID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string REPORTERORGANIZATIONID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string RISKASSESSMENTID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string ROLEID { get; set; }

		[JsonProperty]
		public uint? STATUS { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string SUBCLASSIFICATIONID { get; set; }

		[JsonProperty]
		public uint? SYSTEMICISSUE { get; set; }

		[JsonProperty]
		public uint? TRIAGECOMPLETE { get; set; }

	}

}
