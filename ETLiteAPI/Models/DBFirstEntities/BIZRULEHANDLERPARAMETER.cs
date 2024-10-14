using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class BIZRULEHANDLERPARAMETER {

		public string BIZRULEHANDLERPARAMETERID { get; set; }

		public string BIZRULEHANDLERPARAMETERNAME { get; set; }

		public string BUSINESSRULEHANDLERDATAID { get; set; }

		public uint? CDOTYPEID { get; set; }

		public uint? CHANGECOUNT { get; set; }

		public uint? DATATYPE { get; set; }

		public string DEFAULTVALUE { get; set; }

		public string EXPORTIMPORTKEY { get; set; }

		public uint? ISFROZEN { get; set; }

	}

}
