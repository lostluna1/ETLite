using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models {

	[JsonObject(MemberSerialization.OptIn), Table(Name = "ES_CONFIRMINSTRUCTION", DisableSyncStructure = true)]
	public partial class ESCONFIRMINSTRUCTION {

		[JsonProperty, Column(Name = "ES_CONFIRMINSTRUCTIONID", DbType = "CHAR(16 BYTE)", IsPrimary = true, IsNullable = false)]
		public string ESCONFIRMINSTRUCTIONID { get; set; }

		[JsonProperty]
		public uint? CDOTYPEID { get; set; }

		[JsonProperty]
		public uint? CHANGECOUNT { get; set; }

		[JsonProperty, Column(DbType = "DATE(7)")]
		public DateTime? CONFIRMDATEGMT { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string CONTAINERID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string EMPLOYEEID { get; set; }

		[JsonProperty, Column(Name = "ES_CONFIRMINSTRUCTIONNAME", DbType = "VARCHAR2(36 BYTE)")]
		public string ESCONFIRMINSTRUCTIONNAME { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(40 BYTE)")]
		public string INSTRUCTIONID { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(1000 BYTE)")]
		public string INSTRUCTIONTEXT { get; set; }

		[JsonProperty]
		public uint? ISFROZEN { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string MFGORDERID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string PRODUCTID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string WORKFLOWSTEPID { get; set; }

	}

}
