using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class QUERYPARMS {

		public uint? CPPDATATYPEID { get; set; }

		public bool? ISINPUTPARM { get; set; }

		public bool? ISLIST { get; set; }

		public string NAME { get; set; }

		public uint? QUERYDEFID { get; set; }

		public uint? QUERYPARMID { get; set; }

		public uint? SEQUENCE { get; set; }

		public string WORKSPACECODE { get; set; }

	}

}
