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
	public partial class DATAPOINTHISTORY {

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)", IsPrimary = true, IsNullable = false)]
		public string DATAPOINTHISTORYID { get; set; }

		[JsonProperty, Column(Name = "BIZ_EQUIPBORROWTASKID", DbType = "CHAR(16 BYTE)")]
		public string BIZEQUIPBORROWTASKID { get; set; }

		[JsonProperty, Column(Name = "BIZ_EQUIPDAILYINSPECTTASKID", DbType = "CHAR(16 BYTE)")]
		public string BIZEQUIPDAILYINSPECTTASKID { get; set; }

		[JsonProperty, Column(Name = "BIZ_EQUIPMAINTTASK", DbType = "VARCHAR2(30 BYTE)")]
		public string BIZEQUIPMAINTTASK { get; set; }

		[JsonProperty]
		public uint? CDOTYPEID { get; set; }

		[JsonProperty]
		public uint? CHANGECOUNT { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string DATACOLLECTIONDEFID { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(36 BYTE)")]
		public string EXPORTIMPORTKEY { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string HISTORYID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string HISTORYMAINLINEID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string INTEGRATIONTXNID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string TXNID { get; set; }

	}

}
