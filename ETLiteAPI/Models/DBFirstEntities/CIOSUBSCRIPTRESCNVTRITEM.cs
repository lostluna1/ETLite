using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class CIOSUBSCRIPTRESCNVTRITEM {

		public string CIOSUBSCRIPTRESCNVTRITEMID { get; set; }

		public uint? CDOTYPEID { get; set; }

		public string CEPSERVICETYPE { get; set; }

		public uint? CHANGECOUNT { get; set; }

		public string CIOSUBSCRIPTIONITEMID { get; set; }

		public string CIOSUBSCRIPTRESCNVTRITEMNAME { get; set; }

		public string CONDITIONALFUNCTION { get; set; }

		public string DESCRIPTION { get; set; }

		public string EXPORTIMPORTKEY { get; set; }

		public uint? ISACTIVE { get; set; }

		public uint? ISFROZEN { get; set; }

		public string MESSAGEFORMAT { get; set; }

		public string MESSAGETYPEOVERRIDEID { get; set; }

	}

}
