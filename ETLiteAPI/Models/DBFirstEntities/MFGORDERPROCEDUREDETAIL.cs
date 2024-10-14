using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class MFGORDERPROCEDUREDETAIL {

		public string MFGORDERPROCEDUREDETAILID { get; set; }

		public uint? CDOTYPEID { get; set; }

		public uint? CHANGECOUNT { get; set; }

		public uint? ISFROZEN { get; set; }

		public string MFGORDERPROCEDUREDETAILNAME { get; set; }

		public string MFGORDERPROCEDUREID { get; set; }

		public string MFGORDERTASKLISTBASEID { get; set; }

		public string MFGORDERTASKLISTID { get; set; }

		public uint? SEQUENCE { get; set; }

	}

}
