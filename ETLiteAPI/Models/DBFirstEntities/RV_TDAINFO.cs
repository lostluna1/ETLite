using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class RV_TDAINFO {

		public string ES_DOCUMENTDISPLAYNAME { get; set; }

		public string IDENTIFIER { get; set; }

		public string PRIMARYSERIALNUMBER { get; set; }

		public string SERIALNUMBER2 { get; set; }

		public string SERIALNUMBER3 { get; set; }

		public string TDANAME { get; set; }

	}

}
