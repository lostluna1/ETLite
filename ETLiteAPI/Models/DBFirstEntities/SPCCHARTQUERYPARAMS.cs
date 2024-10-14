using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class SPCCHARTQUERYPARAMS {

		public string SPCCHARTQUERYPARAMSID { get; set; }

		public uint? CDOTYPEID { get; set; }

		public uint? CHANGECOUNT { get; set; }

		public uint? DATATYPE { get; set; }

		public string DISPLAYTEXT { get; set; }

		public string DYNAMICVALUE { get; set; }

		public uint? ISFROZEN { get; set; }

		public string PARAMNAME { get; set; }

		public string PARAMVALUE { get; set; }

		public string PARENTID { get; set; }

		public string SPCCHARTQUERYPARAMSNAME { get; set; }

	}

}
