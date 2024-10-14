using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class USERQUERYPARAMETER {

		public string USERQUERYPARAMETERID { get; set; }

		public uint? CDOTYPEID { get; set; }

		public uint? CHANGECOUNT { get; set; }

		public string CIOVALUE { get; set; }

		public string CIOVALUEEXPRESSION { get; set; }

		public uint? DATATYPE { get; set; }

		public string DEFAULTVALUE { get; set; }

		public string DISPLAYTEXT { get; set; }

		public string DYNAMICVALUE { get; set; }

		public string EXPORTIMPORTKEY { get; set; }

		public uint? ISFROZEN { get; set; }

		public uint? PARAMSEQUENCE { get; set; }

		public uint? USEFORBLOCKROWS { get; set; }

		public string USERQUERYID { get; set; }

		public string USERQUERYPARAMETERNAME { get; set; }

	}

}
