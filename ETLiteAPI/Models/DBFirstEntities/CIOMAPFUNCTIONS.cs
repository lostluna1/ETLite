using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class CIOMAPFUNCTIONS {

		public string CIOMAPFUNCTIONSID { get; set; }

		public string ARGUMENTS { get; set; }

		public uint? CDOTYPEID { get; set; }

		public uint? CHANGECOUNT { get; set; }

		public string CIOFUNCTIONID { get; set; }

		public string CIOMAPFUNCTIONSNAME { get; set; }

		public string CIOMESSAGEMAPID { get; set; }

		public string EXPORTIMPORTKEY { get; set; }

		public uint? ISFROZEN { get; set; }

		public uint? LEFTPOSITION { get; set; }

		public uint? TOPPOSITION { get; set; }

	}

}
