using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class A_JOBMODELDETAILTOSTAGE {

		public string JOBMODELDETAILTOSTAGEID { get; set; }

		public uint? CDOTYPEID { get; set; }

		public uint? CHANGECOUNT { get; set; }

		public string EXPORTIMPORTKEY { get; set; }

		public uint? ISFROZEN { get; set; }

		public string JOBMODELDETAILID { get; set; }

		public string TOSTAGEID { get; set; }

		public string TOSTAGESELECTOR { get; set; }

		public uint? TOSTAGESEQUENCE { get; set; }

	}

}
