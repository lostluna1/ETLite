using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class A_PRODUCTCONVERSIONPLANDETAILS {

		public string PRODUCTCONVERSIONPLANDETAILSID { get; set; }

		public uint? CDOTYPEID { get; set; }

		public uint? CHANGECOUNT { get; set; }

		public string EXPORTIMPORTKEY { get; set; }

		public string FROMPRODUCTBASEID { get; set; }

		public string FROMPRODUCTID { get; set; }

		public string FROMSPECID { get; set; }

		public uint? ISFROZEN { get; set; }

		public string PRODUCTCONVERSIONPLANID { get; set; }

		public string SPECBASEID { get; set; }

		public string TOPRODUCTBASEID { get; set; }

		public string TOPRODUCTFORCHILDID { get; set; }

		public string TOPRODUCTID { get; set; }

		public string TOWORKFLOWBASEID { get; set; }

		public string TOWORKFLOWID { get; set; }

	}

}
