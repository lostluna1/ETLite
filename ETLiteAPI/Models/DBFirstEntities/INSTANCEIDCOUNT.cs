using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class INSTANCEIDCOUNT {

		public uint CDODEFID { get; set; }

		public string CLIENTINSTANCEID { get; set; }

		public string CSIINSTANCEID { get; set; }

	}

}
