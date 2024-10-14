using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class SYS_ROLEAUTHDATA {

		public int AUTH_ID { get; set; }

		public string AUTHVALUE { get; set; }

		public DateTime? CREATEDATE { get; set; }

		public string CREATOR { get; set; }

		public int? DATATYPE_ID { get; set; }

		public int? LEVELID { get; set; }

		public string MODIFIER { get; set; }

		public DateTime? MODIFYDATE { get; set; }

		public string NODE_ID { get; set; }

		public int? ROLE_ID { get; set; }

		public int? USER_ID { get; set; }

	}

}
