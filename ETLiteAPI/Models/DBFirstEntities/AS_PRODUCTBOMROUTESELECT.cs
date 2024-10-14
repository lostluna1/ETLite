using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class AS_PRODUCTBOMROUTESELECT {

		public string BIZ_EFFECTIVEFROMDATE { get; set; }

		public string BIZ_EFFECTIVETHROUGHDATA { get; set; }

		public string BOMID { get; set; }

		public string BOMNAME { get; set; }

		public string BOMREVISION { get; set; }

		public string DESCRIPTION { get; set; }

		public string ERPBOMID { get; set; }

		public string ERPBOMNAME { get; set; }

		public string ERPBOMREVISION { get; set; }

		public string ERPROUTENAME { get; set; }

		public string ERPROUTEREVISION { get; set; }

		public string PRODUCTNAME { get; set; }

		public string PRODUCTREVISION { get; set; }

		public string WORKFLOWNAME { get; set; }

		public string WORKFLOWREVISION { get; set; }

	}

}
