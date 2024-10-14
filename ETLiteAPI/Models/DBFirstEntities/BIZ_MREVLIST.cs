using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class BIZ_MREVLIST {

		public string BIZ_MREVLISTID { get; set; }

		public string BASEOBJECTID { get; set; }

		public string BIZ_MREVLISTNAME { get; set; }

		public uint? CDOTYPEID { get; set; }

		public uint? CHANGECOUNT { get; set; }

		public string ECNDES { get; set; }

		public string ECNNO { get; set; }

		public string EXPORTIMPORTKEY { get; set; }

		public uint? ISFROZEN { get; set; }

		public string MATERIALREV { get; set; }

		public DateTime? STARTTIME { get; set; }

	}

}
