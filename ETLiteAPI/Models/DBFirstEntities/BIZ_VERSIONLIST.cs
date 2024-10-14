using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class BIZ_VERSIONLIST {

		public string BIZ_VERSIONLISTID { get; set; }

		public string BASEOBJECTID { get; set; }

		public string BIZ_VERSIONLISTNAME { get; set; }

		public string BOMID { get; set; }

		public uint? CDOTYPEID { get; set; }

		public uint? CHANGECOUNT { get; set; }

		public string DESCRIPTION { get; set; }

		public DateTime? EFFECTIVEFROMDATE { get; set; }

		public DateTime? EFFECTIVETHROUGHDATE { get; set; }

		public string ERPBOMID { get; set; }

		public string ERPROUTEID { get; set; }

		public uint? ISFROZEN { get; set; }

		public string PRODUCTIONVERSION { get; set; }

		public string WORKFLOWID { get; set; }

	}

}
