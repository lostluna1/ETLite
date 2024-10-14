﻿using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class ES_DPMO_DEFECTS {

		public decimal? DEFECTTECH { get; set; }

		public DateTime? DEFECTTXNDATE { get; set; }

		public string ISCURRENTDEFECTSID { get; set; }

		public string ISDEFECTREASONNAME { get; set; }

		public string ISREFDES { get; set; }

		public string MFGORDERID { get; set; }

		public string MFGORDERNAME { get; set; }

		public string PARTNUMBER { get; set; }

		public string PARTPRODUCTID { get; set; }

		public string PRODUCTDISPLAY { get; set; }

		public string PRODUCTID { get; set; }

		public string PRODUCTNAME { get; set; }

		public string PRODUCTREVISION { get; set; }

		public string RESOURCENAME { get; set; }

		public string WORKFLOWSTEPNAME { get; set; }

	}

}
