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
	public partial class PACKAGEAPPROVALREMINDER {

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)", IsPrimary = true, IsNullable = false)]
		public string PACKAGEAPPROVALREMINDERID { get; set; }

		[JsonProperty]
		public uint? CDOTYPEID { get; set; }

		[JsonProperty]
		public uint? CHANGECOUNT { get; set; }

		[JsonProperty]
		public uint? DAYSAFTERDUE { get; set; }

		[JsonProperty]
		public uint? DAYSBEFOREDUE { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string EMAILMESSAGEID { get; set; }

		[JsonProperty]
		public uint? ISFROZEN { get; set; }

		[JsonProperty]
		public uint? ISREPEATDAILY { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(36 BYTE)")]
		public string PACKAGEAPPROVALREMINDERNAME { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string PARENTID { get; set; }

		[JsonProperty]
		public uint? RECIPIENT { get; set; }

	}

}
