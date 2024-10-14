using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class SYS_MENU {

		public int MENU_ID { get; set; }

		public string AUTH { get; set; }

		public int? AUTHDATA { get; set; }

		public DateTime? CREATEDATE { get; set; }

		public string CREATOR { get; set; }

		public string DESCRIPTION { get; set; }

		public sbyte? ENABLE { get; set; }

		public string ICON { get; set; }

		public int? LINKTYPE { get; set; }

		public string MENUNAME { get; set; }

		public int? MENUTYPE { get; set; }

		public string MODIFIER { get; set; }

		public DateTime? MODIFYDATE { get; set; }

		public int? ORDERNO { get; set; }

		public int PARENTID { get; set; }

		public string TABLENAME { get; set; }

		public string URL { get; set; }

	}

}
