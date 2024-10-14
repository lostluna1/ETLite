using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class A_PARTTXNHISTORYDETAIL {

		public string PARTTXNHISTORYDETAILID { get; set; }

		public uint? CDOTYPEID { get; set; }

		public uint? CHANGECOUNT { get; set; }

		public string EXPORTIMPORTKEY { get; set; }

		public string HISTORYID { get; set; }

		public string INTEGRATIONTXNID { get; set; }

		public string MATERIALPARTID { get; set; }

		public string PARTID { get; set; }

		public string PARTNAME { get; set; }

		public uint? PARTQTY { get; set; }

		public string PARTTXNHISTORYID { get; set; }

		public string PHYSICALLOCATIONID { get; set; }

		public string PHYSICALPOSITIONID { get; set; }

		public uint? REQUESTPARTQTY { get; set; }

		public uint? SCRAPQTY { get; set; }

		public string TXNID { get; set; }

	}

}
