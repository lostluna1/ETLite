using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class SYS_DICTIONARYLIST {

		public int DICLIST_ID { get; set; }

		public DateTime? CREATEDATE { get; set; }

		public int? CREATEID { get; set; }

		public string CREATOR { get; set; }

		public int? DIC_ID { get; set; }

		public string DICNAME { get; set; }

		public string DICVALUE { get; set; }

		public sbyte? ENABLE { get; set; }

		public string MODIFIER { get; set; }

		public DateTime? MODIFYDATE { get; set; }

		public int? MODIFYID { get; set; }

		public int? ORDERNO { get; set; }

		public string REMARK { get; set; }

	}

}
