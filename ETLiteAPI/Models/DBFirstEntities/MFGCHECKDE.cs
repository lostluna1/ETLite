using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class MFGCHECKDE {

		public string MFGCHECKDEID { get; set; }

		public DateTime? BIZ_COMPLETEDATE { get; set; }

		public string BIZ_MFGCHECKLISTID { get; set; }

		public string BIZ_PRINCIPALID { get; set; }

		public uint? CDOTYPEID { get; set; }

		public uint? CHANGECOUNT { get; set; }

		public string DATANAME { get; set; }

		public uint? DATATYPE { get; set; }

		public string DATAVALUE { get; set; }

		public string IMPROVETTHESITUATION { get; set; }

		public uint? ISFROZEN { get; set; }

		public string MFGCHECKDENAME { get; set; }

		public string PRODUCTIONTYPE { get; set; }

		public string REMARK { get; set; }

		public uint? STATUSDETERMINATION { get; set; }

	}

}
