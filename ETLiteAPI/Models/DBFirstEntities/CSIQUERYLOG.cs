using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class CSIQUERYLOG {

		[JsonProperty, Column(Name = "LOG_DATE", InsertValueSql = "SYSDATE")]
		public DateTime? LOGDATE { get; set; }

		[JsonProperty, Column(Name = "MESSAGE_TEXT", DbType = "CLOB")]
		public string MESSAGETEXT { get; set; }

		[JsonProperty, Column(Name = "QUERY_NAME", DbType = "VARCHAR2(256 BYTE)")]
		public string QUERYNAME { get; set; } = "SelectionValueEx_QualityObjectInquiry_QualityObject";

	}

}
