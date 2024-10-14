using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class A_SPCCHARTPARAMS {

		public string SPCCHARTPARAMSID { get; set; }

		public uint? CDOTYPEID { get; set; }

		public uint? CHANGECOUNT { get; set; }

		public string DEFAULTVALUE { get; set; }

		public uint? DISPLAYSEQUENCE { get; set; }

		public string EXPORTIMPORTKEY { get; set; }

		public uint? ISDYNAMIC { get; set; }

		public uint? ISFROZEN { get; set; }

		public string PARAMNAME { get; set; }

		public string SPCCHARTID { get; set; }

	}

}
