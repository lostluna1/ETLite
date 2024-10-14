using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class UIPORTALPROFILE {

		public string UIPORTALPROFILEID { get; set; }

		public uint? CDOTYPEID { get; set; }

		public uint? CHANGECOUNT { get; set; }

		public string EXPORTIMPORTKEY { get; set; }

		public uint? ISFROZEN { get; set; }

		public string MASTERPAGE { get; set; }

		public string PARENTID { get; set; }

		public string PORTALHOMEPAGEID { get; set; }

		public string PORTALMOBILEHOMEPAGEID { get; set; }

		public string PORTALV8HOMEPAGEID { get; set; }

		public string THEME { get; set; }

	}

}
