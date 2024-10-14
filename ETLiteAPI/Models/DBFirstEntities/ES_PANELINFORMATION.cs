using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class ES_PANELINFORMATION {

		public string ES_PANELINFORMATIONID { get; set; }

		public uint? CDOTYPEID { get; set; }

		public uint? CHANGECOUNT { get; set; }

		public string ES_CADDESIGNID { get; set; }

		public string ES_NPIJOBID { get; set; }

		public string ES_PANELINFORMATIONNAME { get; set; }

		public uint? ES_PCBNUMBER { get; set; }

		public uint? ES_PCBSIDE { get; set; }

		public uint? ES_ROTATION { get; set; }

		public uint? ES_XLOCATION { get; set; }

		public uint? ES_YLOCATION { get; set; }

		public uint? ISFROZEN { get; set; }

	}

}
