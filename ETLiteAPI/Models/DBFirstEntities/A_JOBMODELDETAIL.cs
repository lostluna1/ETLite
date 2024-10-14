using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class A_JOBMODELDETAIL {

		public string JOBMODELDETAILID { get; set; }

		public uint? ALLOWCOMPLETE { get; set; }

		public uint? CDOTYPEID { get; set; }

		public uint? CHANGECOUNT { get; set; }

		public string DATACOLLECTIONDEFBASEID { get; set; }

		public string DATACOLLECTIONDEFID { get; set; }

		public string DOCUMENTSETID { get; set; }

		public uint? ENFORCECHECKLISTSEQUENCE { get; set; }

		public string EXPORTIMPORTKEY { get; set; }

		public uint? ISFROZEN { get; set; }

		public string JOBMODELID { get; set; }

		public uint? REQUIRECAUSECODE { get; set; }

		public uint? REQUIREREPAIRCODE { get; set; }

		public uint? REQUIRESYMPTOMCODE { get; set; }

		public string STAGEID { get; set; }

		public uint? STAGESEQUENCE { get; set; }

	}

}
