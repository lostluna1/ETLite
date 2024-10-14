using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class BIZ_LABELSETUPLIST {

		public string BIZ_LABELSETUPLISTID { get; set; }

		public string BIZ_LABELDEFINITIONID { get; set; }

		public string BIZ_LABELPRINTSETUPID { get; set; }

		public string BIZ_LABELSETUPLISTNAME { get; set; }

		public uint? CDOTYPEID { get; set; }

		public uint? CHANGECOUNT { get; set; }

		public string CUSTOMERID { get; set; }

		public uint? ISFROZEN { get; set; }

		public string SPECID { get; set; }

	}

}
