using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class SWITCHINGRULEDETAILS {

		public string SWITCHINGRULEDETAILSID { get; set; }

		public uint? ALLOWAUTOMATICSWITCHING { get; set; }

		public uint? CDOTYPEID { get; set; }

		public uint? CHANGECOUNT { get; set; }

		public string EMAILDISTRIBUTIONID { get; set; }

		public string EXPORTIMPORTKEY { get; set; }

		public string EXPRESSION { get; set; }

		public string FROMINSPECTIONLEVELID { get; set; }

		public uint? ISFROZEN { get; set; }

		public uint? LASTCONTAINERSETCOUNT { get; set; }

		public uint? PASSORFAILCONTAINERCOUNT { get; set; }

		public uint? REQUIRENOTIFICATION { get; set; }

		public string SWITCHINGRULEID { get; set; }

		public uint? SWITCHINGRULETYPE { get; set; }

		public string TOINSPECTIONLEVELID { get; set; }

	}

}
