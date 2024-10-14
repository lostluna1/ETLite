using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class CIOMASTERGROUPS {

		public uint? CIOMASTERGROUPID { get; set; }

		public string CIOMESSAGETYPENAME { get; set; }

		public string MACHINENAME { get; set; }

		public DateTime? MSGTYPELASTUPDATE { get; set; }

	}

}
