using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class ASWORKFLOW {

		[JsonProperty, Column(DbType = "VARCHAR2(255 BYTE)")]
		public string DESCRIPTION { get; set; }

		[JsonProperty, Column(DbType = "CHAR(0 BYTE)")]
		public string EQPGROUP { get; set; }

		[JsonProperty]
		public uint? SEQUENCE { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(40 BYTE)")]
		public string SPEC { get; set; }

		[JsonProperty, Column(Name = "SPEC_REV", DbType = "VARCHAR2(15 BYTE)")]
		public string SPECREV { get; set; }

		[JsonProperty, Column(DbType = "CHAR(0 BYTE)")]
		public string STEPTIME { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(40 BYTE)")]
		public string WORKFLOW { get; set; }

		[JsonProperty, Column(Name = "WORKFLOW_REV", DbType = "VARCHAR2(15 BYTE)")]
		public string WORKFLOWREV { get; set; }

		[JsonProperty, Column(DbType = "CHAR(0 BYTE)")]
		public string YIELD { get; set; }

	}

}
