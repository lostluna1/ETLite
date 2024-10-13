using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models {

	[JsonObject(MemberSerialization.OptIn), Table(Name = "RV_TOOLUSAGE", DisableSyncStructure = true)]
	public partial class RVTOOLUSAGE {

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)", IsNullable = false)]
		public string CONTAINERID { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(100 BYTE)")]
		public string CONTAINERNAME { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(30 BYTE)")]
		public string EMPLOYEENAME { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(100 BYTE)")]
		public string IDENTIFIER { get; set; }

		[JsonProperty, Column(DbType = "DATE(7)")]
		public DateTime? MOVEINDATE { get; set; }

		[JsonProperty, Column(DbType = "DATE(7)")]
		public DateTime? MOVEOUTDATE { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(100 BYTE)")]
		public string RESOURCENAME { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(201 BYTE)")]
		public string RESOURCETOOL { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(58 BYTE)")]
		public string SPEC { get; set; }

		[JsonProperty]
		public uint? TOOLACTION { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(7 BYTE)")]
		public string TOOLACTIONNAME { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(100 BYTE)")]
		public string TOOLNAME { get; set; }

		[JsonProperty, Column(DbType = "DATE(7)")]
		public DateTime? TXNDATE { get; set; }

		[JsonProperty, Column(DbType = "DATE(7)")]
		public DateTime? TXNDATEGMT { get; set; }

	}

}
