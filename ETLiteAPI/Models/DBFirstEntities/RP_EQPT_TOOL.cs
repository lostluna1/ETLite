using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class RP_EQPT_TOOL {

		public string BIZ_EQUIPBINDTASKNAME { get; set; }

		public DateTime? BIZ_EQUIPBINDTIME { get; set; }

		public DateTime? BIZ_EQUIPUNBINDTIME { get; set; }

		public string CONTAINER_NAME { get; set; }

		public DateTime? CREATION_DATE { get; set; }

		public string RESOURCE_FAMILY_DESC { get; set; }

		public string RESOURCE_FAMILY_NAME { get; set; }

		public string RESOURCE_NAME { get; set; }

		public string SPEC_NAME { get; set; }

		public string TOOL_FAMILY_DESC { get; set; }

		public string TOOL_FAMILY_NAME { get; set; }

		public string TOOL_NAME { get; set; }

		public DateTime? TXNDATE { get; set; }

		public string TXNSERVICE_NAME { get; set; }

	}

}
