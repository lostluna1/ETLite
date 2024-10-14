using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class CSIVIEWEVENTTREND {

		[JsonProperty, Column(DbType = "DATE(7)")]
		public DateTime? CLOSEDATE { get; set; }

		[JsonProperty, Column(DbType = "DATE(7)")]
		public DateTime? EVENTDATE { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)", IsNullable = false)]
		public string EVENTID { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(255 BYTE)")]
		public string EVENTNAME { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(30 BYTE)")]
		public string FAILUREMODENAME { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(30 BYTE)")]
		public string FAILURESEVERITYNAME { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(6 BYTE)")]
		public string MYSTATUS { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(30 BYTE)")]
		public string NCRCAUSECODENAME { get; set; }

		[JsonProperty, Column(DbType = "DATE(7)")]
		public DateTime? REPORTEDDATE { get; set; }

	}

}
