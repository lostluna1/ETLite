using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class EXPORTIMPORTQUEUE {

		public uint EXPORTIMPORTQUEUEID { get; set; }

		public DateTime? CREATIONDATE { get; set; }

		public uint? EXPORTIMPORTHEADERID { get; set; }

		public string LOCKGUID { get; set; }

		public uint? REQUESTACTION { get; set; }

	}

}
