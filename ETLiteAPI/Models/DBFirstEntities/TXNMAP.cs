using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class TXNMAP {

		public string TXNMAPID { get; set; }

		public uint? CDOTYPEID { get; set; }

		public uint? CHANGECOUNT { get; set; }

		public string DATACOLLECTIONDEFINITIONBASEID { get; set; }

		public string DATACOLLECTIONDEFINITIONID { get; set; }

		public string EXPORTIMPORTKEY { get; set; }

		public uint? ISFROZEN { get; set; }

		public uint? REQUIRED { get; set; }

		public uint? SEQUENCE { get; set; }

		public string SPECID { get; set; }

		public uint? TXNTOUSE { get; set; }

		public uint? TXNTYPE { get; set; }

	}

}
