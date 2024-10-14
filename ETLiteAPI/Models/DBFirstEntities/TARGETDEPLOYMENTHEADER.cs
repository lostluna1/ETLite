using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class TARGETDEPLOYMENTHEADER {

		public string TARGETDEPLOYMENTHEADERID { get; set; }

		public uint? CDOTYPEID { get; set; }

		public uint? CHANGECOUNT { get; set; }

		public DateTime? EXPORTDATE { get; set; }

		public DateTime? EXPORTDATEGMT { get; set; }

		public string EXPORTIMPORTKEY { get; set; }

		public DateTime? LASTUPDATEDDATE { get; set; }

		public DateTime? LASTUPDATEDDATEGMT { get; set; }

		public string OWNER { get; set; }

		public string PARENTID { get; set; }

		public uint? STATUS { get; set; }

	}

}
