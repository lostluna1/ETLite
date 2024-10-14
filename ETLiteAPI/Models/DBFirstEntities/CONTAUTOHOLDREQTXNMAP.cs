using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class CONTAUTOHOLDREQTXNMAP {

		public string CONTAUTOHOLDREQTXNMAPID { get; set; }

		public string BASEOBJECTID { get; set; }

		public uint? CDOTYPEID { get; set; }

		public uint? CHANGECOUNT { get; set; }

		public string CONTAINERAUTOHOLDREQUIREMENTID { get; set; }

		public string CONTAUTOHOLDREQTXNMAPNAME { get; set; }

		public DateTime? EFFECTIVEFROMDATE { get; set; }

		public DateTime? EFFECTIVEFROMDATEGMT { get; set; }

		public DateTime? EFFECTIVETHRUDATE { get; set; }

		public DateTime? EFFECTIVETHRUDATEGMT { get; set; }

		public uint? ISFROZEN { get; set; }

		public uint? TXNTYPE { get; set; }

	}

}
