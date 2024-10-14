using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class ISRECIPEPLANDETAILS {

		public string ISRECIPEPLANDETAILSID { get; set; }

		public uint? CDOTYPEID { get; set; }

		public uint? CHANGECOUNT { get; set; }

		public uint? ISFROZEN { get; set; }

		public string ISRECIPEPLANDETAILSNAME { get; set; }

		public string ISRECIPEPLANID { get; set; }

		public string RECIPEBASEID { get; set; }

		public string RECIPEID { get; set; }

		public string RESOURCEID { get; set; }

		public string SPECBASEID { get; set; }

		public string SPECID { get; set; }

	}

}
