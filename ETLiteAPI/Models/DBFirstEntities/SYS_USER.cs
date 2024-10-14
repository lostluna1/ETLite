using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class SYS_USER {

		public int USER_ID { get; set; }

		public DateTime? CREATEDATE { get; set; }

		public int? CREATEID { get; set; }

		public string CREATOR { get; set; }

		public string DEPTIDS { get; set; }

		public string EMAIL { get; set; }

		public sbyte? ENABLE { get; set; }

		public int? GENDER { get; set; }

		public string HEADIMAGEURL { get; set; }

		public DateTime? LASTLOGINDATE { get; set; }

		public DateTime? LASTMODIFYPWDDATE { get; set; }

		public string MODIFIER { get; set; }

		public DateTime? MODIFYDATE { get; set; }

		public int? MODIFYID { get; set; }

		public int? ORDERNO { get; set; }

		public string PHONENO { get; set; }

		public string REMARK { get; set; }

		public int? ROLE_ID { get; set; }

		public string ROLEIDS { get; set; }

		public string TOKEN { get; set; }

		public string USERNAME { get; set; }

		public string USERPWD { get; set; }

		public string USERTRUENAME { get; set; }

	}

}
