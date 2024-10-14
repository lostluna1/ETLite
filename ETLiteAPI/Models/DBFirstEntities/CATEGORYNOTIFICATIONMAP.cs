using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class CATEGORYNOTIFICATIONMAP {

		public string CATEGORYNOTIFICATIONMAPID { get; set; }

		public uint? CDOTYPEID { get; set; }

		public uint? CHANGECOUNT { get; set; }

		public uint? DISPLAYINCONCIERGE { get; set; }

		public uint? DISPLAYINMESSAGECENTER { get; set; }

		public string EXPORTIMPORTKEY { get; set; }

		public string ICON { get; set; }

		public uint? ISFROZEN { get; set; }

		public string MESSAGECATEGORYLABELID { get; set; }

		public string PARENTID { get; set; }

		public uint? SEQUENCE { get; set; }

	}

}
