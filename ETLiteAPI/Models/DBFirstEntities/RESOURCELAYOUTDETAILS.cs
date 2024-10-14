﻿using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class RESOURCELAYOUTDETAILS {

		public string RESOURCELAYOUTDETAILSID { get; set; }

		public uint? CDOTYPEID { get; set; }

		public uint? CHANGECOUNT { get; set; }

		public string EXPORTIMPORTKEY { get; set; }

		public uint? ISFROZEN { get; set; }

		public string NAME { get; set; }

		public string RESOURCEID { get; set; }

		public string RESOURCELAYOUTID { get; set; }

		public decimal? XLOCATION { get; set; }

		public decimal? YLOCATION { get; set; }

	}

}
