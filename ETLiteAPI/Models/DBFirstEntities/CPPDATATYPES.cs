using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class CPPDATATYPES {

		public uint DATATYPEID { get; set; }

		public string DATATYPEDESCRIPTION { get; set; }

		public bool? ISCUSTOM { get; set; }

		public bool? ISFIELDTYPE { get; set; }

		public bool? ISFUNDAMENTAL { get; set; }

		public bool? ISNUMERIC { get; set; }

		public bool? ISPARAMTYPE { get; set; }

		public bool? ISTRIVIAL { get; set; }

		public string LISTTYPEDEF { get; set; }

		public string LISTTYPEDESCRIPTION { get; set; }

		public string NAME { get; set; }

		public string TYPEDEF { get; set; }

	}

}
