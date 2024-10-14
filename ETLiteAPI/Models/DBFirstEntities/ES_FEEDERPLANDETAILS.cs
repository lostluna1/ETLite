using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class ES_FEEDERPLANDETAILS {

		public string FEEDERFAMILYID { get; set; }

		public string FEEDERFAMILYNAME { get; set; }

		public string FEEDERGROUPID { get; set; }

		public string FEEDERGROUPNAME { get; set; }

		public string FEEDERID { get; set; }

		public string FEEDERSLOTNAME { get; set; }

		public string PRODUCTBASEID { get; set; }

		public string PRODUCTID { get; set; }

		public string PRODUCTNAME { get; set; }

		public string SLOTID { get; set; }

	}

}
