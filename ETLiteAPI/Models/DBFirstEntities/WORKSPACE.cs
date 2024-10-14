using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class WORKSPACE {

		public uint WORKSPACEID { get; set; }

		public string COLOR { get; set; }

		public uint? DEFAULTFEATUREID { get; set; }

		public uint? ENDCDOID { get; set; }

		public string ENDCDOIDHEX { get; set; }

		public uint? ENDID { get; set; }

		public string ENDIDHEX { get; set; }

		public bool? ISACTIVE { get; set; }

		public string PREFIX { get; set; }

		public uint? SEQUENCE { get; set; }

		public uint? STARTCDOID { get; set; }

		public string STARTCDOIDHEX { get; set; }

		public uint? STARTID { get; set; }

		public string STARTIDHEX { get; set; }

		public string SUPPORTEDBY { get; set; }

		public string WORKSPACECODE { get; set; }

		public string WORKSPACEDESCRIPTION { get; set; }

	}

}
