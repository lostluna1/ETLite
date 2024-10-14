using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class CIODATAELEMENTS {

		public string CIODATAELEMENTID { get; set; }

		public uint? CDOTYPEID { get; set; }

		public uint? CHANGECOUNT { get; set; }

		public string CIODATAELEMENTNAME { get; set; }

		public string CIOSERIALPORTADAPTERID { get; set; }

		public uint? DATATYPE { get; set; }

		public string EXPORTIMPORTKEY { get; set; }

		public string EXPRESSION { get; set; }

		public uint? EXPRESSIONTYPE { get; set; }

		public uint? ISFROZEN { get; set; }

		public uint? SCALE { get; set; }

	}

}
