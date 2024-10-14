using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class SYS_LANGUAGE {

		public string DEFAULTKEY { get; set; }

		public string ARABIC { get; set; }

		public DateTime? CREATEDATE { get; set; }

		public int? CREATEID { get; set; }

		public string CREATOR { get; set; }

		public string ENGLISH { get; set; }

		public string FRENCH { get; set; }

		public int ID { get; set; }

		public int? ISPACKAGECONTENT { get; set; }

		public string MODIFIER { get; set; }

		public DateTime? MODIFYDATE { get; set; }

		public int? MODIFYID { get; set; }

		public string MODULE { get; set; }

		public string RUSSIAN { get; set; }

		public string SPANISH { get; set; }

		public string THAI { get; set; }

		public string VIETNAMESE { get; set; }

		public string ZHCN { get; set; }

		public string ZHTW { get; set; }

	}

}
