using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class USERATTRIBUTE {

		public string USERATTRIBUTEID { get; set; }

		public string ATTRIBUTEVALUE { get; set; }

		public uint? CDOTYPEID { get; set; }

		public uint? CHANGECOUNT { get; set; }

		public uint? DATATYPE { get; set; }

		public string EXPORTIMPORTKEY { get; set; }

		public uint? ISEXPRESSION { get; set; }

		public uint? ISFROZEN { get; set; }

		public string PARENTID { get; set; }

		public string USERATTRIBUTENAME { get; set; }

	}

}
