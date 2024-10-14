using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class TRAININGPLANDETAIL {

		public string TRAININGPLANDETAILID { get; set; }

		public uint? CDOTYPEID { get; set; }

		public uint? CHANGECOUNT { get; set; }

		public string EXPORTIMPORTKEY { get; set; }

		public uint? ISFROZEN { get; set; }

		public string SUBTRAININGPLANID { get; set; }

		public DateTime? TARGETTRAININGDATE { get; set; }

		public string TRAININGPLANID { get; set; }

		public string TRAININGREQUIREMENTBASEID { get; set; }

		public string TRAININGREQUIREMENTID { get; set; }

	}

}
