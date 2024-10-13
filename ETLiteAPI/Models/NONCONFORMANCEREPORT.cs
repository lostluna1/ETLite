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
	public partial class NONCONFORMANCEREPORT {

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)", IsPrimary = true, IsNullable = false)]
		public string NONCONFORMANCEREPORTID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string ATTACHMENTSID { get; set; }

		[JsonProperty]
		public uint? CDOTYPEID { get; set; }

		[JsonProperty]
		public uint? CHANGECOUNT { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string CHARGETOSTEPID { get; set; }

		[JsonProperty, Column(DbType = "DATE(7)")]
		public DateTime? CLOSEDATE { get; set; }

		[JsonProperty, Column(DbType = "DATE(7)")]
		public DateTime? CLOSEDATEGMT { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string CONTAINERID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string CORRECTIVEACTIONCOMMENTSID { get; set; }

		[JsonProperty, Column(DbType = "DATE(7)")]
		public DateTime? CREATIONDATE { get; set; }

		[JsonProperty, Column(DbType = "DATE(7)")]
		public DateTime? CREATIONDATEGMT { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string ESCALATEDBYID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string ESCALATEDEVENTID { get; set; }

		[JsonProperty, Column(DbType = "DATE(7)")]
		public DateTime? ESCALATIONDATE { get; set; }

		[JsonProperty, Column(DbType = "DATE(7)")]
		public DateTime? ESCALATIONDATEGMT { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string FAILUREINVESTIGATIONCOMMENTSID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string LASTREVTXNID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string NCRCAUSECODEGROUPID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string NCRCAUSECODEID { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(255 BYTE)")]
		public string NCRCOMMENT { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string NCRFAILURETYPEID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string NCRRESOLUTIONCODEID { get; set; }

		[JsonProperty]
		public uint? NCRSTATUS { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(30 BYTE)")]
		public string NONCONFORMANCEREPORTNAME { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string PREVENTIVEACTIONCOMMENTSID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string RELATEDNONCONFORMANCEID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string TASKID { get; set; }

	}

}
