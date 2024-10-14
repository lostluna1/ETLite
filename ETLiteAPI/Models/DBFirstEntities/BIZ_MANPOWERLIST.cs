using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class BIZ_MANPOWERLIST {

		public string BIZ_MANPOWERLISTID { get; set; }

		public string BIZ_MANPOWERID { get; set; }

		public string BIZ_MANPOWERLISTNAME { get; set; }

		public string BREAKTIME { get; set; }

		public uint? CDOTYPEID { get; set; }

		public uint? CHANGECOUNT { get; set; }

		public uint? ENABLE { get; set; }

		public string ENDTIME { get; set; }

		public uint? ISFROZEN { get; set; }

		public string MANPOWER { get; set; }

		public string MFGLINEID { get; set; }

		public string SHIFTID { get; set; }

		public string STARTTIME { get; set; }

	}

}
