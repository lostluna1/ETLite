﻿using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models {

	[JsonObject(MemberSerialization.OptIn), Table(Name = "STARTHISTORYDETAILES_PHYSICALA", DisableSyncStructure = true)]
	public partial class STARTHISTORYDETAILESPHYSICALA {

		[JsonProperty, Column(IsPrimary = true)]
		public uint FIELDID { get; set; }

		[JsonProperty, Column(IsPrimary = true)]
		public uint SEQUENCE { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)", IsPrimary = true, IsNullable = false)]
		public string STARTHISTORYDETAILID { get; set; }

		[JsonProperty, Column(Name = "ES_PHYSICALADDRESSESID", DbType = "CHAR(16 BYTE)")]
		public string ESPHYSICALADDRESSESID { get; set; }

	}

}
