using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models {

	[JsonObject(MemberSerialization.OptIn), Table(Name = "BIZ_CONTAINERMAINTENANCE", DisableSyncStructure = true)]
	public partial class BIZCONTAINERMAINTENANCE {

		[JsonProperty, Column(Name = "BIZ_CONTAINERMAINTENANCEID", DbType = "CHAR(16 BYTE)", IsPrimary = true, IsNullable = false)]
		public string BIZCONTAINERMAINTENANCEID { get; set; }

		[JsonProperty, Column(Name = "BIZ_CONTAINERMAINTENANCENAME", DbType = "VARCHAR2(36 BYTE)")]
		public string BIZCONTAINERMAINTENANCENAME { get; set; }

		[JsonProperty, Column(Name = "BIZ_RFID", DbType = "CHAR(16 BYTE)")]
		public string BIZRFID { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(255 BYTE)")]
		public string CAUSEANALYSIS { get; set; }

		[JsonProperty]
		public uint? CDOTYPEID { get; set; }

		[JsonProperty]
		public uint? CHANGECOUNT { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(255 BYTE)")]
		public string COMMENTS { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string CONFIRMERID { get; set; }

		[JsonProperty, Column(DbType = "DATE(7)")]
		public DateTime? CONFIRMTIME { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string CONTAINERID { get; set; }

		[JsonProperty, Column(DbType = "DATE(7)")]
		public DateTime? CREATETIME { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(100 BYTE)")]
		public string DEFECTLOCATION { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string EMPLOYEEID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string HISTORYID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string HISTORYMAINLINEID { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(255 BYTE)")]
		public string IMPROVESTRATEGY { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string INTEGRATIONTXNID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string ISDEFECTREASONID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string ISREPAIRACTIONID { get; set; }

		[JsonProperty]
		public uint? MAINTENANCECOUNT { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(255 BYTE)")]
		public string MOVEHISTORYID { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(30 BYTE)")]
		public string STATUS { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string STEPID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string TXNID { get; set; }

	}

}
