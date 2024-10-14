using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class CONTAINERCOMPLETEDSUBTASK {

		public string CONTAINERCOMPLETEDSUBTASKSID { get; set; }

		public uint? CDOTYPEID { get; set; }

		public uint? CHANGECOUNT { get; set; }

		public DateTime? COMPLETIONTIMESTAMP { get; set; }

		public DateTime? COMPLETIONTIMESTAMPGMT { get; set; }

		public string CONTAINERCOMPLETEDTASKID { get; set; }

		public string CONTAINERID { get; set; }

		public string EXPORTIMPORTKEY { get; set; }

		public uint? ISFROZEN { get; set; }

		public uint? NBRTIMESPROCESSED { get; set; }

		public uint? PASS { get; set; }

	}

}
