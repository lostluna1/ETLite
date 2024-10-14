using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class BUSINESSRULEPARAMETERVALUES {

		public string BUSINESSRULEPARAMETERVALUESID { get; set; }

		public string BUSINESSRULEEXECUTIONHISTORYID { get; set; }

		public uint? CDOTYPEID { get; set; }

		public uint? CHANGECOUNT { get; set; }

		public string EXPORTIMPORTKEY { get; set; }

		public string HANDLERID { get; set; }

		public string HANDLERNAME { get; set; }

		public uint? HANDLERTYPE { get; set; }

		public string INTEGRATIONTXNID { get; set; }

		public string PARAMETEREXPRESSION { get; set; }

		public string PARAMETERNAME { get; set; }

		public string PARAMETERVALUE { get; set; }

		public string TXNID { get; set; }

	}

}
