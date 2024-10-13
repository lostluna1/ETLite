using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models {

	[JsonObject(MemberSerialization.OptIn), Table(Name = "A_JOBORDER", DisableSyncStructure = true)]
	public partial class AJOBORDER {

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)", IsPrimary = true, IsNullable = false)]
		public string JOBORDERID { get; set; }

		[JsonProperty, Column(Name = "BIZ_ACTURALWORKINGHOUR")]
		public uint? BIZACTURALWORKINGHOUR { get; set; }

		[JsonProperty, Column(Name = "BIZ_EQUIPIMRSUPID", DbType = "CHAR(16 BYTE)")]
		public string BIZEQUIPIMRSUPID { get; set; }

		[JsonProperty, Column(Name = "BIZ_EQUIPIMRTECHID", DbType = "CHAR(16 BYTE)")]
		public string BIZEQUIPIMRTECHID { get; set; }

		[JsonProperty, Column(Name = "BIZ_EQUIPREPAIREXPENSETYPEID", DbType = "CHAR(16 BYTE)")]
		public string BIZEQUIPREPAIREXPENSETYPEID { get; set; }

		[JsonProperty, Column(Name = "BIZ_ORDERWORKINGHOUR")]
		public uint? BIZORDERWORKINGHOUR { get; set; }

		[JsonProperty, Column(Name = "BIZ_REPAIRINGAPPLICANTID", DbType = "CHAR(16 BYTE)")]
		public string BIZREPAIRINGAPPLICANTID { get; set; }

		[JsonProperty, Column(Name = "BIZ_REPAIRINGATTACH", DbType = "VARCHAR2(4000 BYTE)")]
		public string BIZREPAIRINGATTACH { get; set; }

		[JsonProperty, Column(Name = "BIZ_REPAIRINGPO", DbType = "VARCHAR2(64 BYTE)")]
		public string BIZREPAIRINGPO { get; set; }

		[JsonProperty, Column(Name = "BIZ_REPAIRINGREMARK", DbType = "VARCHAR2(255 BYTE)")]
		public string BIZREPAIRINGREMARK { get; set; }

		[JsonProperty, Column(Name = "BIZ_REPAIRINGVENDOR", DbType = "VARCHAR2(64 BYTE)")]
		public string BIZREPAIRINGVENDOR { get; set; }

		[JsonProperty, Column(Name = "BIZ_TASKCLOSETIME", DbType = "DATE(7)")]
		public DateTime? BIZTASKCLOSETIME { get; set; }

		[JsonProperty, Column(Name = "BIZ_TASKSTARTTIME", DbType = "DATE(7)")]
		public DateTime? BIZTASKSTARTTIME { get; set; }

		[JsonProperty, Column(Name = "BIZ_TASKSTATUSID", DbType = "CHAR(16 BYTE)")]
		public string BIZTASKSTATUSID { get; set; }

		[JsonProperty]
		public uint? CDOTYPEID { get; set; }

		[JsonProperty]
		public uint? CHANGECOUNT { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string CHANGEHISTORYID { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(255 BYTE)")]
		public string DESCRIPTION { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(255 BYTE)")]
		public string FILTERTAGS { get; set; }

		[JsonProperty]
		public uint? ICONID { get; set; }

		[JsonProperty]
		public uint? ISFROZEN { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string JOBCAUSECODEID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string JOBMODELID { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(40 BYTE)")]
		public string JOBORDERNAME { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string JOBREPAIRCODEID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string JOBSYMPTOMCODEID { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(2000 BYTE)")]
		public string NOTES { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string RESOURCEID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string SETUPACCESSID { get; set; }

	}

}
