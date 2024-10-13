﻿using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models {

	[JsonObject(MemberSerialization.OptIn), Table(Name = "RV_INPROCESSATSTEP", DisableSyncStructure = true)]
	public partial class RVINPROCESSATSTEP {

		[JsonProperty, Column(DbType = "NUMBER(22)")]
		public decimal? CONTAINERCOUNT { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)", IsNullable = false)]
		public string MFGORDERID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)", IsNullable = false)]
		public string WORKFLOWSTEPID { get; set; }

	}

}
