using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class RP_EQPT_ACCOUNT_REPORT {

		public string BIZ_ASSETDEPT { get; set; }

		public string BIZ_ASSETDES { get; set; }

		public string BIZ_ASSETOWNER1 { get; set; }

		public string BIZ_ASSETOWNER2 { get; set; }

		public string BIZ_ASSETOWNER3 { get; set; }

		public string BIZ_EQUIPSTATUSNAME { get; set; }

		public string BIZ_SAPASSETCODE { get; set; }

		public string FACTORYNAME { get; set; }

		public string FAMILY_DESCRIPTION { get; set; }

		public string PHYSICALLOCATIONNAME { get; set; }

		public string PHYSICALPOSITIONNAME { get; set; }

		public string RESC_DESCRIPTION { get; set; }

		public string RESC_FAMILY { get; set; }

		public string RESOURCEGROUPNAME { get; set; }

		public string RESOURCENAME { get; set; }

		public DateTime? SAP_EFFECTIVE_DATE { get; set; }

	}

}
