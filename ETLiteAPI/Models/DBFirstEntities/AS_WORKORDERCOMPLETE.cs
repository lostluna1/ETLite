using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class AS_WORKORDERCOMPLETE {

		public string FACTORY { get; set; }

		public string LOCATION { get; set; }

		public string MFGORDER { get; set; }

		public string PKN { get; set; }

		public string PRODUCT { get; set; }

		public string QCSTATUS { get; set; }

		public string QTY { get; set; }

		public string REQUESTTYPE { get; set; }

		public string UOM { get; set; }

	}

}
