using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class RV_MFGORDER {

		public decimal? FAILCOUNT { get; set; }

		public string MFGORDERID { get; set; }

		public string MFGORDERNAME { get; set; }

		public decimal? PANELIZED { get; set; }

		public decimal? PCBCOUNT { get; set; }

		public string PRODUCTDISPLAY { get; set; }

		public decimal? QTY { get; set; }

		public decimal? QTYSTARTED { get; set; }

		public decimal? XOUTCOUNT { get; set; }

	}

}
