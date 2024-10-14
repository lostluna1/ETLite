using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class ASSIGNEDMAINTREQ {

		public string ASSIGNEDMAINTREQID { get; set; }

		public DateTime? ACTIVATIONDATE { get; set; }

		public DateTime? ACTIVATIONDATEGMT { get; set; }

		public uint? CDOTYPEID { get; set; }

		public uint? CHANGECOUNT { get; set; }

		public string CHANGEHISTORYID { get; set; }

		public string EXPORTIMPORTKEY { get; set; }

		public uint? ISFROZEN { get; set; }

		public string MAINTENANCEREQID { get; set; }

		public string PARENTID { get; set; }

		public string SETUPACCESSID { get; set; }

	}

}
