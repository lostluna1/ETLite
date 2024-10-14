using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class CIOMAPSOURCE {

		public string CIOMAPSOURCEID { get; set; }

		public uint? CDOTYPEID { get; set; }

		public uint? CHANGECOUNT { get; set; }

		public string CIOMESSAGEMAPID { get; set; }

		public string EXPORTIMPORTKEY { get; set; }

		public string FILENAME { get; set; }

		public uint? ISFROZEN { get; set; }

		public string MAPSOURCE { get; set; }

	}

}
