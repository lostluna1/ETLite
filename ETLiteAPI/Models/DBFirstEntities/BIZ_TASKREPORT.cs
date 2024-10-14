using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class BIZ_TASKREPORT {

		public string BIZ_TASKREPORTID { get; set; }

		public string BIZ_EQUIPDAILYINSPECTTASKID { get; set; }

		public string BIZ_TASKREPORTNAME { get; set; }

		public uint? CDOTYPEID { get; set; }

		public uint? CHANGECOUNT { get; set; }

		public uint? COLUMNPOSITION { get; set; }

		public string DATANAME { get; set; }

		public uint? DATATYPE { get; set; }

		public string DATAVALUE { get; set; }

		public uint? ISFROZEN { get; set; }

		public uint? ISLIMITOVERRIDEALLOWED { get; set; }

		public uint? ISREQUIRED { get; set; }

		public string LOWERLIMIT { get; set; }

		public uint? ROWPOSITION { get; set; }

		public string UPPERLIMIT { get; set; }

		public string USERDATACOLLECTIONDEFID { get; set; }

	}

}
