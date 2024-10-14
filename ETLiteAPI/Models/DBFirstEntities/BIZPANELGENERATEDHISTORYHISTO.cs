﻿using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class BIZPANELGENERATEDHISTORYHISTO {

		[JsonProperty, Column(Name = "BIZ_PANELGENERATEDHISTORYID", DbType = "CHAR(16 BYTE)", IsPrimary = true, IsNullable = false)]
		public string BIZPANELGENERATEDHISTORYID { get; set; }

		[JsonProperty, Column(IsPrimary = true)]
		public uint FIELDID { get; set; }

		[JsonProperty, Column(IsPrimary = true)]
		public uint SEQUENCE { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string HISTORYDETAILSID { get; set; }

	}

}
