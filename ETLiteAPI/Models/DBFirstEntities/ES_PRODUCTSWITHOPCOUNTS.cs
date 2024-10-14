﻿using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class ES_PRODUCTSWITHOPCOUNTS {

		public decimal? ALLCOUNT { get; set; }

		public string PRODUCTDISPLAY { get; set; }

		public string PRODUCTID { get; set; }

		public string PRODUCTNAME { get; set; }

		public string PRODUCTREVISION { get; set; }

		public string PRODUCTTYPENAME { get; set; }

		public decimal? SMTCOUNT { get; set; }

		public decimal? THTCOUNT { get; set; }

	}

}
