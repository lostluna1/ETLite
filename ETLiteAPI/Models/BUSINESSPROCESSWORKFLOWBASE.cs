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
	public partial class BUSINESSPROCESSWORKFLOWBASE {

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)", IsPrimary = true, IsNullable = false)]
		public string BUSINESSPROCESSWORKFLOWBASEID { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(40 BYTE)")]
		public string BUSINESSPROCESSWORKFLOWNAME { get; set; }

		[JsonProperty]
		public uint? CDOTYPEID { get; set; }

		[JsonProperty]
		public uint? CHANGECOUNT { get; set; }

		[JsonProperty]
		public uint? ICONID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string REVOFRCDID { get; set; }

	}

}
