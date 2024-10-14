using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class UIPREFFIELDDEF {

		public string UIPREFFIELDDEFID { get; set; }

		public uint? CDOTYPEID { get; set; }

		public uint? CHANGECOUNT { get; set; }

		public string EXPORTIMPORTKEY { get; set; }

		public uint? FIELDSEQ { get; set; }

		public uint? ISFROZEN { get; set; }

		public string UIPREFERENCEID { get; set; }

		public string UIPREFFIELDDEFNAME { get; set; }

	}

}
