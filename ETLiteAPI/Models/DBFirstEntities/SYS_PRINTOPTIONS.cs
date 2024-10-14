using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class SYS_PRINTOPTIONS {

		public string PRINTOPTIONSID { get; set; }

		public DateTime? CREATEDATE { get; set; }

		public int? CREATEID { get; set; }

		public string CREATOR { get; set; }

		public string CUSTOMNAME { get; set; }

		public string DBSERVICE { get; set; }

		public int? ENABLE { get; set; }

		public string HTML { get; set; }

		public string MODIFIER { get; set; }

		public DateTime? MODIFYDATE { get; set; }

		public int? MODIFYID { get; set; }

		public string OPTIONS { get; set; }

		public string TABLECNNAME { get; set; }

		public string TABLENAME { get; set; }

		public string TENANCYID { get; set; }

		public int? USERID { get; set; }

	}

}
