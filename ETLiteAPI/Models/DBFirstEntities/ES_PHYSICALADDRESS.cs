using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class ES_PHYSICALADDRESS {

		public string ES_PHYSICALADDRESSID { get; set; }

		public uint? ASSIGNED { get; set; }

		public DateTime? ASSIGNEDDATE { get; set; }

		public DateTime? ASSIGNEDDATEGMT { get; set; }

		public uint? CDOTYPEID { get; set; }

		public uint? CHANGECOUNT { get; set; }

		public string CONTAINERID { get; set; }

		public string ES_ADDRESSPOOLID { get; set; }

		public string ES_PHYSICALADDRESSNAME { get; set; }

		public string EXPORTIMPORTKEY { get; set; }

		public uint? ISFROZEN { get; set; }

	}

}
