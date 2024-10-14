using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class BIZ_PRCGROUPLIST {

		public string BIZ_PRCGROUPLISTID { get; set; }

		public string BIZ_PRCGROUPID { get; set; }

		public string BIZ_PRCGROUPLISTNAME { get; set; }

		public string BIZ_PRODUCTRESOURCECHECKID { get; set; }

		public uint? CDOTYPEID { get; set; }

		public uint? CHANGECOUNT { get; set; }

		public string EXPORTIMPORTKEY { get; set; }

		public uint? ISFROZEN { get; set; }

		public string RESOURCEFAMILYID { get; set; }

	}

}
