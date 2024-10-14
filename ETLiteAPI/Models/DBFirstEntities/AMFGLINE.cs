using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class AMFGLINE {

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)", IsPrimary = true, IsNullable = false)]
		public string MFGLINEID { get; set; }

		[JsonProperty, Column(Name = "BIZ_BUID", DbType = "CHAR(16 BYTE)")]
		public string BIZBUID { get; set; }

		[JsonProperty, Column(Name = "BIZ_FACTORYID", DbType = "CHAR(16 BYTE)")]
		public string BIZFACTORYID { get; set; }

		[JsonProperty, Column(Name = "BIZ_LINEREPTTYPE", DbType = "VARCHAR2(40 BYTE)")]
		public string BIZLINEREPTTYPE { get; set; }

		[JsonProperty, Column(Name = "BIZ_SUBDEPTID", DbType = "CHAR(16 BYTE)")]
		public string BIZSUBDEPTID { get; set; }

		[JsonProperty, Column(Name = "BIZ_WORKCENTERID", DbType = "CHAR(16 BYTE)")]
		public string BIZWORKCENTERID { get; set; }

		[JsonProperty, Column(Name = "BIZ_WORKFLOWID", DbType = "CHAR(16 BYTE)")]
		public string BIZWORKFLOWID { get; set; }

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

		[JsonProperty, Column(DbType = "VARCHAR2(40 BYTE)")]
		public string MFGLINENAME { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(2000 BYTE)")]
		public string NOTES { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string SETUPACCESSID { get; set; }

	}

}
