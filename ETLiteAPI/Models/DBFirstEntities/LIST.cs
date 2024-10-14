using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class LIST {

		public string LISTID { get; set; }

		public string BIZ_LABLEDEFINITIONID { get; set; }

		public string BIZ_LABLEPRINTSETUPID { get; set; }

		public uint? CDOTYPEID { get; set; }

		public uint? CHANGECOUNT { get; set; }

		public string CUSTOMERID { get; set; }

		public uint? ISFROZEN { get; set; }

		public string LISTNAME { get; set; }

		public string SPECID { get; set; }

	}

}
