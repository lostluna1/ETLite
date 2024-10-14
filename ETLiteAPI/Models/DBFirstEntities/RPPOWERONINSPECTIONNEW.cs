using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class RPPOWERONINSPECTIONNEW {

		[JsonProperty, Column(Name = "BIZ_EQUIPSTATUS", DbType = "VARCHAR2(64 BYTE)")]
		public string BIZEQUIPSTATUS { get; set; }

		[JsonProperty, Column(Name = "BIZ_USAGE", DbType = "VARCHAR2(100 BYTE)")]
		public string BIZUSAGE { get; set; }

		[JsonProperty, Column(Name = "CREATION_DATE", DbType = "DATE(7)")]
		public DateTime? CREATIONDATE { get; set; }

		[JsonProperty, Column(Name = "EXECUTION_TIME", DbType = "DATE(7)")]
		public DateTime? EXECUTIONTIME { get; set; }

		[JsonProperty, Column(Name = "FAMILY_DES", DbType = "VARCHAR2(255 BYTE)")]
		public string FAMILYDES { get; set; }

		[JsonProperty, Column(Name = "FAMILY_NAME", DbType = "VARCHAR2(40 BYTE)")]
		public string FAMILYNAME { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(30 BYTE)")]
		public string MFGORDER { get; set; }

		[JsonProperty, Column(Name = "MFGORDER_ID", DbType = "CHAR(16 BYTE)", IsNullable = false)]
		public string MFGORDERID { get; set; }

		[JsonProperty, Column(Name = "OBJECT_TYPE", DbType = "VARCHAR2(40 BYTE)")]
		public string OBJECTTYPE { get; set; }

		[JsonProperty, Column(Name = "POWERONDET_NAME", DbType = "VARCHAR2(256 BYTE)")]
		public string POWERONDETNAME { get; set; }

		[JsonProperty, Column(Name = "POWERONINSPECTION_NAME", DbType = "VARCHAR2(256 BYTE)")]
		public string POWERONINSPECTIONNAME { get; set; }

		[JsonProperty, Column(Name = "RESOURCE_NAME", DbType = "VARCHAR2(100 BYTE)")]
		public string RESOURCENAME { get; set; }

	}

}
