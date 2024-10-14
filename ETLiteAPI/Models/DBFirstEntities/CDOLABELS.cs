using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class CDOLABELS {

		public uint CDOLABELID { get; set; }

		public uint? CDODEFID { get; set; }

		public uint? LABELID { get; set; }

		public uint? LABELTYPEID { get; set; }

		public string WORKSPACECODE { get; set; }

	}

}
