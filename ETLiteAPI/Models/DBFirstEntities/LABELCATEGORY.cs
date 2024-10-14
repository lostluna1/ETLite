using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class LABELCATEGORY {

		public uint CATEGORYID { get; set; }

		public string DESCRIPTION { get; set; }

		public uint? ENDLABELID { get; set; }

		public uint? LABELTYPEID { get; set; }

		public string NAME { get; set; }

		public uint? STARTLABELID { get; set; }

	}

}
