using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class SITESTATE {

		public string STATEVALUE { get; set; }

		public string LASTUPDATEPROCESS { get; set; }

		public DateTime? LASTUPDATETIME { get; set; }

		public uint? LICEXPNOTIFICATIONSTATE { get; set; }

		public string SITENAME { get; set; }

	}

}
