using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class CLFEVENTMAPORDEREDVIEW {

		public uint? CALLERID { get; set; }

		public uint? CDODEFID { get; set; }

		public string CDONAME { get; set; }

		public decimal? CHILDLEVEL { get; set; }

		public uint? CLFEVENTID { get; set; }

		public uint? CLFEVENTMAPID { get; set; }

		public uint? CLFID { get; set; }

		public string DESCRIPTION { get; set; }

		public string NAME { get; set; }

		public uint? PERMISSIONMASK { get; set; }

		public string WORKSPACECODE { get; set; }

		public uint? WORKSPACESEQUENCE { get; set; }

	}

}
