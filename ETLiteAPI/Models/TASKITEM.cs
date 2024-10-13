﻿using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models {

	[JsonObject(MemberSerialization.OptIn), Table(DisableSyncStructure = true)]
	public partial class TASKITEM {

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)", IsPrimary = true, IsNullable = false)]
		public string TASKITEMID { get; set; }

		[JsonProperty]
		public uint? ADVANCETONEXTTASK { get; set; }

		[JsonProperty]
		public uint? CDOTYPEID { get; set; }

		[JsonProperty]
		public uint? CHANGECOUNT { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string COMPUTATIONID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string DATACOLLECTIONDEFBASEID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string DATACOLLECTIONDEFID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string DOCUMENTSETID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string ESIGREQUIREMENTID { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(36 BYTE)")]
		public string EXPORTIMPORTKEY { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(4000 BYTE)")]
		public string INSTRUCTION { get; set; }

		[JsonProperty]
		public uint? INSTRUCTIONTYPE { get; set; }

		[JsonProperty]
		public uint? ISFROZEN { get; set; }

		[JsonProperty]
		public uint? MAXITERATIONS { get; set; }

		[JsonProperty]
		public uint? MINITERATIONS { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(4000 BYTE)")]
		public string REPORTINSTRUCTION { get; set; }

		[JsonProperty]
		public uint? SEQUENCE { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(40 BYTE)")]
		public string TASKITEMNAME { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string TASKLISTID { get; set; }

		[JsonProperty]
		public uint? TASKTYPE { get; set; }

		[JsonProperty]
		public uint? TASKUSAGE { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string TRAININGREQGROUPID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string TRANSACTIONPAGEID { get; set; }

	}

}
