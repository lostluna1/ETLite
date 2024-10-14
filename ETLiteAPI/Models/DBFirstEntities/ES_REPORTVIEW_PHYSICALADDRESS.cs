using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class ES_REPORTVIEW_PHYSICALADDRESS {

		public string ADDRESSPOOL { get; set; }

		public string ADDRESSTYPE { get; set; }

		public decimal? CHILDCOUNT { get; set; }

		public string CONTAINERNAME { get; set; }

		public uint? ES_PCBNUMBER { get; set; }

		public string IDENTIFIER { get; set; }

		public string PARENTCONTAINERIDENTIFIER { get; set; }

		public string PHYSICALADDRESS { get; set; }

	}

}
