using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class SYS_USERAUTH {

		public decimal ID { get; set; }

		public string AUTHUSERIDS { get; set; }

		public DateTime? CREATEDATE { get; set; }

		public decimal? CREATEID { get; set; }

		public string CREATOR { get; set; } = "NULL";

		public decimal ENABLE { get; set; }

		public decimal? MENUID { get; set; }

		public string MODIFIER { get; set; } = "NULL";

		public DateTime? MODIFYDATE { get; set; }

		public decimal? MODIFYID { get; set; }

		public decimal? TABLENAME { get; set; }

		public decimal USERID { get; set; }

	}

}
