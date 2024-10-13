using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models {

	[JsonObject(MemberSerialization.OptIn), Table(Name = "RP_EQPT_TOOL", DisableSyncStructure = true)]
	public partial class RPEQPTTOOL {

		[JsonProperty, Column(Name = "BIZ_EQUIPBINDTASKNAME", DbType = "VARCHAR2(256 BYTE)")]
		public string BIZEQUIPBINDTASKNAME { get; set; }

		[JsonProperty, Column(Name = "BIZ_EQUIPBINDTIME", DbType = "DATE(7)")]
		public DateTime? BIZEQUIPBINDTIME { get; set; }

		[JsonProperty, Column(Name = "BIZ_EQUIPUNBINDTIME", DbType = "DATE(7)")]
		public DateTime? BIZEQUIPUNBINDTIME { get; set; }

		[JsonProperty, Column(Name = "CONTAINER_NAME", DbType = "VARCHAR2(100 BYTE)")]
		public string CONTAINERNAME { get; set; }

		[JsonProperty, Column(Name = "CREATION_DATE", DbType = "DATE(7)")]
		public DateTime? CREATIONDATE { get; set; }

		[JsonProperty, Column(Name = "RESOURCE_FAMILY_DESC", DbType = "VARCHAR2(255 BYTE)")]
		public string RESOURCEFAMILYDESC { get; set; }

		[JsonProperty, Column(Name = "RESOURCE_FAMILY_NAME", DbType = "VARCHAR2(40 BYTE)")]
		public string RESOURCEFAMILYNAME { get; set; }

		[JsonProperty, Column(Name = "RESOURCE_NAME", DbType = "VARCHAR2(100 BYTE)")]
		public string RESOURCENAME { get; set; }

		[JsonProperty, Column(Name = "SPEC_NAME", DbType = "VARCHAR2(40 BYTE)")]
		public string SPECNAME { get; set; }

		[JsonProperty, Column(Name = "TOOL_FAMILY_DESC", DbType = "VARCHAR2(255 BYTE)")]
		public string TOOLFAMILYDESC { get; set; }

		[JsonProperty, Column(Name = "TOOL_FAMILY_NAME", DbType = "VARCHAR2(40 BYTE)")]
		public string TOOLFAMILYNAME { get; set; }

		[JsonProperty, Column(Name = "TOOL_NAME", DbType = "VARCHAR2(100 BYTE)")]
		public string TOOLNAME { get; set; }

		[JsonProperty, Column(DbType = "DATE(7)")]
		public DateTime? TXNDATE { get; set; }

		[JsonProperty, Column(Name = "TXNSERVICE_NAME", DbType = "VARCHAR2(32 BYTE)")]
		public string TXNSERVICENAME { get; set; }

	}

}
