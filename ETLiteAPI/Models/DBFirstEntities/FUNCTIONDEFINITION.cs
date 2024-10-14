using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class FUNCTIONDEFINITION {

		public string DESCRIPTION { get; set; }

		public uint? FEATUREID { get; set; }

		public uint? FUNCTIONID { get; set; }

		public uint? FUNCTIONTYPEID { get; set; }

		public string NAME { get; set; }

		public string NOTES { get; set; }

		public string OCXGUID { get; set; }

		public string OCXVERSION { get; set; }

		public uint? SIGNATUREID { get; set; }

		public string WORKSPACECODE { get; set; }

	}

}
