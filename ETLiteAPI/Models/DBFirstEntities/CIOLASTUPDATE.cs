using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class CIOLASTUPDATE {

		public DateTime? CREATETIME { get; set; }

		public DateTime? LASTUPDATE { get; set; }

		public string MACHINENAME { get; set; }

		public uint? OWNERID { get; set; }

		public string TABLENAME { get; set; }

	}

}
