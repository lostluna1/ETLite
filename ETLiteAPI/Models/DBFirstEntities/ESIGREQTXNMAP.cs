using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class ESIGREQTXNMAP {

		public string ESIGREQTXNMAPID { get; set; }

		public uint? ALLTXNS { get; set; }

		public uint? CDOTYPEID { get; set; }

		public uint? CHANGECOUNT { get; set; }

		public string ESIGREQUIREMENTID { get; set; }

		public string EXPORTIMPORTKEY { get; set; }

		public uint? ISFROZEN { get; set; }

		public string PARENTID { get; set; }

		public uint? TXNID { get; set; }

		public string TXNTOUSE { get; set; }

	}

}
