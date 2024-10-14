using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class BIZ_PRODUCTRESOURCECHECKDET {

		public string BIZ_PRODUCTRESOURCECHECKDETID { get; set; }

		public string BIZ_PRODUCTRESOURCECHECKDENAME { get; set; }

		public string BIZ_PRODUCTRESOURCECHECKID { get; set; }

		public uint? CDOTYPEID { get; set; }

		public uint? CHANGECOUNT { get; set; }

		public string EXPORTIMPORTKEY { get; set; }

		public uint? ISFROZEN { get; set; }

		public uint? ISLIFETIMEUPDATED { get; set; }

		public uint? ISMAINRESOURCE { get; set; }

		public uint? ISVERIFYDAILYINSPECT { get; set; }

		public string PARTFAMILYID { get; set; }

		public string RESOURCEFAMILYID { get; set; }

		public string TOOLFAMILYID { get; set; }

	}

}
