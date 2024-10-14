using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class PRODUCTBIZ_PRDREVLIST {

		public uint FIELDID { get; set; }

		public string PRODUCTID { get; set; }

		public uint SEQUENCE { get; set; }

		public string BIZ_PRDREVLISTID { get; set; }

	}

}
