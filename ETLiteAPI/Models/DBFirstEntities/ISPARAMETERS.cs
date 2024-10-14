using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class ISPARAMETERS {

		public string ISPARAMETERSID { get; set; }

		public uint? CDOTYPEID { get; set; }

		public uint? CHANGECOUNT { get; set; }

		public uint? DISPLAYSEQUENCE { get; set; }

		public string EXPORTIMPORTKEY { get; set; }

		public uint? ISFROZEN { get; set; }

		public string ISPARAMETERSNAME { get; set; }

		public string MAXIMUMVALUE { get; set; }

		public string MINIMUMVALUE { get; set; }

		public uint? PARAMETERTYPE { get; set; }

		public string PARAMETERVALUE { get; set; }

		public string RECIPEID { get; set; }

		public string VALIDVALUES { get; set; }

	}

}
