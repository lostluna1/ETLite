using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models {

	[JsonObject(MemberSerialization.OptIn), Table(Name = "BIZ_IPQCINSPECTIONTASK", DisableSyncStructure = true)]
	public partial class BIZIPQCINSPECTIONTASK {

		[JsonProperty, Column(Name = "BIZ_IPQCINSPECTIONTASKID", DbType = "CHAR(16 BYTE)", IsPrimary = true, IsNullable = false)]
		public string BIZIPQCINSPECTIONTASKID { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(255 BYTE)")]
		public string ATTACHMENT { get; set; }

		[JsonProperty, Column(Name = "BIZ_IPQCINSPECTIONTASKNAME", DbType = "VARCHAR2(64 BYTE)")]
		public string BIZIPQCINSPECTIONTASKNAME { get; set; }

		[JsonProperty, Column(Name = "BIZ_IPQCSHIFTID", DbType = "CHAR(16 BYTE)")]
		public string BIZIPQCSHIFTID { get; set; }

		[JsonProperty]
		public uint? CDOTYPEID { get; set; }

		[JsonProperty]
		public uint? CHANGECOUNT { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string CHANGEHISTORYID { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(2000 BYTE)")]
		public string DESCRIPTION { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string EMPLOYEEID { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(255 BYTE)")]
		public string FILTERTAGS { get; set; }

		[JsonProperty]
		public uint? ICONID { get; set; }

		[JsonProperty]
		public uint? INSPECTQTY { get; set; }

		[JsonProperty]
		public uint? ISCOMPLATE { get; set; }

		[JsonProperty]
		public uint? ISFROZEN { get; set; }

		[JsonProperty]
		public uint? ISUPLOADSPC { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string MFGORDERID { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(2000 BYTE)")]
		public string NOTES { get; set; }

		[JsonProperty]
		public uint? QCCONFRIM { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string QCEMPLOYEEID { get; set; }

		[JsonProperty, Column(DbType = "DATE(7)")]
		public DateTime? QCTXNDATE { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(1000 BYTE)")]
		public string REMARK { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string SETUPACCESSID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string SPECID { get; set; }

		[JsonProperty]
		public uint? TASKSTATUS { get; set; }

		[JsonProperty, Column(DbType = "DATE(7)")]
		public DateTime? TXNDATE { get; set; }

	}

}
