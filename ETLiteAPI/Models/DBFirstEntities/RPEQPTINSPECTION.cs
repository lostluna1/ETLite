using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class RPEQPTINSPECTION {

		[JsonProperty, Column(Name = "BIZ_ASSETDEPT", DbType = "VARCHAR2(30 BYTE)")]
		public string BIZASSETDEPT { get; set; }

		[JsonProperty, Column(Name = "BIZ_ASSETDES", DbType = "VARCHAR2(255 BYTE)")]
		public string BIZASSETDES { get; set; }

		[JsonProperty, Column(Name = "BIZ_EQUIPDAILYINSPECTTASKNAME", DbType = "VARCHAR2(256 BYTE)")]
		public string BIZEQUIPDAILYINSPECTTASKNAME { get; set; }

		[JsonProperty, Column(Name = "BIZ_INSPECTTYPE", DbType = "VARCHAR2(30 BYTE)")]
		public string BIZINSPECTTYPE { get; set; }

		[JsonProperty, Column(Name = "BIZ_JUDGEMENTRESULT", DbType = "VARCHAR2(30 BYTE)")]
		public string BIZJUDGEMENTRESULT { get; set; }

		[JsonProperty, Column(Name = "BIZ_SAPASSETCODE", DbType = "VARCHAR2(30 BYTE)")]
		public string BIZSAPASSETCODE { get; set; }

		[JsonProperty, Column(Name = "BIZ_TASKCLOSETIME", DbType = "DATE(7)")]
		public DateTime? BIZTASKCLOSETIME { get; set; }

		[JsonProperty, Column(Name = "BIZ_TASKSTATUSNAME", DbType = "VARCHAR2(256 BYTE)")]
		public string BIZTASKSTATUSNAME { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(30 BYTE)")]
		public string EMPLOYEENAME { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(30 BYTE)")]
		public string FACTORYNAME { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(40 BYTE)")]
		public string OBJECTTYPE { get; set; }

		[JsonProperty, Column(Name = "RESOURCE_DESCRIPTION", DbType = "VARCHAR2(255 BYTE)")]
		public string RESOURCEDESCRIPTION { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(40 BYTE)")]
		public string RESOURCEFAMILYNAME { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(100 BYTE)")]
		public string RESOURCENAME { get; set; }

	}

}
