using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models {

	[JsonObject(MemberSerialization.OptIn), Table(DisableSyncStructure = true)]
	public partial class COMPLETEMAINTENANCEHISTORY {

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)", IsPrimary = true, IsNullable = false)]
		public string COMPLETEMAINTENANCEHISTORYID { get; set; }

		[JsonProperty, Column(Name = "BIZ_ACTUALWORKINGHOUR")]
		public uint? BIZACTUALWORKINGHOUR { get; set; }

		[JsonProperty, Column(Name = "BIZ_EQUIPMAINTTASK", DbType = "VARCHAR2(30 BYTE)")]
		public string BIZEQUIPMAINTTASK { get; set; }

		[JsonProperty, Column(Name = "BIZ_INSPECTATTACH", DbType = "VARCHAR2(4000 BYTE)")]
		public string BIZINSPECTATTACH { get; set; }

		[JsonProperty, Column(Name = "BIZ_INSPECTORID", DbType = "CHAR(16 BYTE)")]
		public string BIZINSPECTORID { get; set; }

		[JsonProperty, Column(Name = "BIZ_INSPECTREMARK", DbType = "VARCHAR2(255 BYTE)")]
		public string BIZINSPECTREMARK { get; set; }

		[JsonProperty, Column(Name = "BIZ_TASKCLOSETIME", DbType = "DATE(7)")]
		public DateTime? BIZTASKCLOSETIME { get; set; }

		[JsonProperty]
		public uint? CDOTYPEID { get; set; }

		[JsonProperty]
		public uint? CHANGECOUNT { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(36 BYTE)")]
		public string EXPORTIMPORTKEY { get; set; }

		[JsonProperty]
		public uint? FORCEMAINTENANCE { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string HISTORYID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string HISTORYMAINLINEID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string INTEGRATIONTXNID { get; set; }

		[JsonProperty]
		public uint? RESETALL { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string TXNID { get; set; }

	}

}
