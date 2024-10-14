﻿using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class BIZFQCINSPECTIONTASKBIZFQCSN {

		[JsonProperty, Column(Name = "BIZ_FQCINSPECTIONTASKID", DbType = "CHAR(16 BYTE)", IsPrimary = true, IsNullable = false)]
		public string BIZFQCINSPECTIONTASKID { get; set; }

		[JsonProperty, Column(IsPrimary = true)]
		public uint FIELDID { get; set; }

		[JsonProperty, Column(IsPrimary = true)]
		public uint SEQUENCE { get; set; }

		[JsonProperty, Column(Name = "BIZ_FQCSNLISTID", DbType = "CHAR(16 BYTE)")]
		public string BIZFQCSNLISTID { get; set; }

	}

}
