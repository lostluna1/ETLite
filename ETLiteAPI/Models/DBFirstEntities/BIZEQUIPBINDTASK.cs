using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class BIZEQUIPBINDTASK {

		[JsonProperty, Column(Name = "BIZ_EQUIPBINDTASKID", DbType = "CHAR(16 BYTE)", IsPrimary = true, IsNullable = false)]
		public string BIZEQUIPBINDTASKID { get; set; }

		[JsonProperty, Column(Name = "BIZ_COUNTEDASCONTAINERQTY")]
		public uint? BIZCOUNTEDASCONTAINERQTY { get; set; }

		[JsonProperty, Column(Name = "BIZ_EQUIPBINDTASKNAME", DbType = "VARCHAR2(256 BYTE)")]
		public string BIZEQUIPBINDTASKNAME { get; set; }

		[JsonProperty, Column(Name = "BIZ_EQUIPBINDTIME", DbType = "DATE(7)")]
		public DateTime? BIZEQUIPBINDTIME { get; set; }

		[JsonProperty, Column(Name = "BIZ_EQUIPUNBINDTIME", DbType = "DATE(7)")]
		public DateTime? BIZEQUIPUNBINDTIME { get; set; }

		[JsonProperty, Column(Name = "BIZ_ISBINDING")]
		public uint? BIZISBINDING { get; set; }

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
		public string RESOURCEID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string SETUPACCESSID { get; set; }

	}

}
