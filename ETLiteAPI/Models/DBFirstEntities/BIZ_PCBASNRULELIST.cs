using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class BIZ_PCBASNRULELIST {

		public string BIZ_PCBASNRULELISTID { get; set; }

		public string BGADATA { get; set; }

		public string BGALOT { get; set; }

		public string BIZ_PCBASNRULELISTNAME { get; set; }

		public uint? CDOTYPEID { get; set; }

		public uint? CHANGECOUNT { get; set; }

		public uint? CRTRULECODE { get; set; }

		public string EXPORTIMPORTKEY { get; set; }

		public uint? ISFROZEN { get; set; }

		public string MFGORDERID { get; set; }

		public string PCBASN { get; set; }

		public uint? PRIORITY { get; set; }

	}

}
