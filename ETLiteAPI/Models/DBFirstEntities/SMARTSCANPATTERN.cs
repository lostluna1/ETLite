using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class SMARTSCANPATTERN {

		public string SMARTSCANPATTERNID { get; set; }

		public string ACTIONIDENTIFIER { get; set; }

		public string ACTIONPARAM { get; set; }

		public uint? CDOTYPEID { get; set; }

		public uint? CHANGECOUNT { get; set; }

		public uint? COMMANDBAR { get; set; }

		public uint? ISACTIVE { get; set; }

		public uint? ISFROZEN { get; set; }

		public uint? ISREGEX { get; set; }

		public string PATTERN { get; set; }

		public uint? REMOVEONMATCH { get; set; }

		public uint? SEQUENCE { get; set; }

		public string SMARTSCANPATTERNNAME { get; set; }

		public string SMARTSCANRULEID { get; set; }

		public uint? SMARTSCANTYPE { get; set; }

	}

}
