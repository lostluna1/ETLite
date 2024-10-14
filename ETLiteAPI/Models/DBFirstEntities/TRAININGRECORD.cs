using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class TRAININGRECORD {

		public string TRAININGRECORDID { get; set; }

		public uint? CDOTYPEID { get; set; }

		public uint? CHANGECOUNT { get; set; }

		public string CHANGEHISTORYID { get; set; }

		public string EMPLOYEEID { get; set; }

		public string ESIGREQUIREMENTID { get; set; }

		public DateTime? EXPIRATIONDATE { get; set; }

		public string EXPORTIMPORTKEY { get; set; }

		public uint? ISFROZEN { get; set; }

		public uint? PERMISSION { get; set; }

		public string SETUPACCESSID { get; set; }

		public string STATUSID { get; set; }

		public string TRAININGREQUIREMENTID { get; set; }

		public DateTime? WARNINGEMAILDATE { get; set; }

	}

}
