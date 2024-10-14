using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class IDCONTROL {

		public string IDTYPE { get; set; }

		public uint? NEXTID { get; set; }

		public uint? NOSKIP { get; set; }

	}

}
