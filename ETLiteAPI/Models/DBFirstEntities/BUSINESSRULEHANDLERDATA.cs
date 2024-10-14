using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class BUSINESSRULEHANDLERDATA {

		public string BUSINESSRULEHANDLERDATAID { get; set; }

		public uint? BIZRULEHANDLERTYPE { get; set; }

		public string BUSINESSRULEHANDLERDATANAME { get; set; }

		public string BUSINESSRULEHANDLERID { get; set; }

		public uint? CDOTYPEID { get; set; }

		public uint? CHANGECOUNT { get; set; }

		public string EXPORTIMPORTKEY { get; set; }

		public uint? ISFROZEN { get; set; }

		public string SCRIPT { get; set; }

		public uint? SERVICETYPE { get; set; }

	}

}
