using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class COMPUTATIONPARAMHISTORY {

		public string COMPUTATIONPARAMHISTORYID { get; set; }

		public uint? CDOTYPEID { get; set; }

		public uint? CHANGECOUNT { get; set; }

		public string COMPUTATIONHISTORYID { get; set; }

		public uint? DATATYPE { get; set; }

		public string EXPORTIMPORTKEY { get; set; }

		public string INTEGRATIONTXNID { get; set; }

		public string PARAMNAME { get; set; }

		public string PARAMVALUE { get; set; }

		public string TXNID { get; set; }

	}

}
