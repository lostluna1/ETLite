using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class BIZEQUIPDAILYINSPECTTASK {

		[JsonProperty, Column(Name = "BIZ_EQUIPDAILYINSPECTTASKID", DbType = "CHAR(16 BYTE)", IsPrimary = true, IsNullable = false)]
		public string BIZEQUIPDAILYINSPECTTASKID { get; set; }

		[JsonProperty, Column(Name = "BIZ_EQUIPDAILYINSPECTTASKNAME", DbType = "VARCHAR2(256 BYTE)")]
		public string BIZEQUIPDAILYINSPECTTASKNAME { get; set; }

		[JsonProperty, Column(Name = "BIZ_INSPECTATTACH", DbType = "VARCHAR2(4000 BYTE)")]
		public string BIZINSPECTATTACH { get; set; }

		[JsonProperty, Column(Name = "BIZ_INSPECTORID", DbType = "CHAR(16 BYTE)")]
		public string BIZINSPECTORID { get; set; }

		[JsonProperty, Column(Name = "BIZ_INSPECTREMARK", DbType = "VARCHAR2(255 BYTE)")]
		public string BIZINSPECTREMARK { get; set; }

		[JsonProperty, Column(Name = "BIZ_INSPECTTYPE", DbType = "VARCHAR2(30 BYTE)")]
		public string BIZINSPECTTYPE { get; set; }

		[JsonProperty, Column(Name = "BIZ_JUDGEMENTRESULT", DbType = "VARCHAR2(30 BYTE)")]
		public string BIZJUDGEMENTRESULT { get; set; }

		[JsonProperty, Column(Name = "BIZ_RESOURCEID", DbType = "CHAR(16 BYTE)")]
		public string BIZRESOURCEID { get; set; }

		[JsonProperty, Column(Name = "BIZ_SHIFTID", DbType = "CHAR(16 BYTE)")]
		public string BIZSHIFTID { get; set; }

		[JsonProperty, Column(Name = "BIZ_TASKCLOSETIME", DbType = "DATE(7)")]
		public DateTime? BIZTASKCLOSETIME { get; set; }

		[JsonProperty, Column(Name = "BIZ_TASKSTARTTIME", DbType = "DATE(7)")]
		public DateTime? BIZTASKSTARTTIME { get; set; }

		[JsonProperty, Column(Name = "BIZ_TASKSTATUSID", DbType = "CHAR(16 BYTE)")]
		public string BIZTASKSTATUSID { get; set; }

		[JsonProperty, Column(Name = "BIZ_TOOLID", DbType = "CHAR(16 BYTE)")]
		public string BIZTOOLID { get; set; }

		[JsonProperty, Column(Name = "BIZ_WOID", DbType = "CHAR(16 BYTE)")]
		public string BIZWOID { get; set; }

		[JsonProperty]
		public uint? CDOTYPEID { get; set; }

		[JsonProperty]
		public uint? CHANGECOUNT { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string CHANGEHISTORYID { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(2000 BYTE)")]
		public string DESCRIPTION { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(255 BYTE)")]
		public string FILTERTAGS { get; set; }

		[JsonProperty]
		public uint? ICONID { get; set; }

		[JsonProperty]
		public uint? ISFROZEN { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(2000 BYTE)")]
		public string NOTES { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string SETUPACCESSID { get; set; }

	}

}
