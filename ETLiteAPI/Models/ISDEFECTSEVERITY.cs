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
	public partial class ISDEFECTSEVERITY {

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)", IsPrimary = true, IsNullable = false)]
		public string ISDEFECTSEVERITYID { get; set; }

		[JsonProperty]
		public uint? ASSOCIATEDPACKAGES { get; set; }

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
		public uint? INSTANCELOCKED { get; set; }

		[JsonProperty]
		public uint? ISCONTAINERFAIL { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(40 BYTE)")]
		public string ISDEFECTSEVERITYNAME { get; set; }

		[JsonProperty]
		public uint? ISFROZEN { get; set; }

		[JsonProperty]
		public uint? ISSCORE { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(2000 BYTE)")]
		public string NOTES { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string SETUPACCESS { get; set; }

	}

}
