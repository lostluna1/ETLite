using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class ASSOCIATEACTIONTXNMAP {

		public string ASSOCIATEACTIONTXNMAPID { get; set; }

		public string ASSOCIATEACTIONTXNMAPNAME { get; set; }

		public uint? CDOTYPEID { get; set; }

		public uint? CHANGECOUNT { get; set; }

		public uint? CLOSEPARENT { get; set; }

		public uint? ISFROZEN { get; set; }

		public string PARENTID { get; set; }

		public uint? SPECASSOCIATEACTION { get; set; }

		public uint? SPECDISASSOCIATELVL { get; set; }

		public uint? TXNTYPE { get; set; }

	}

}
