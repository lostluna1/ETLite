using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class COMPONENTISSUEHISTORY {

		public string COMPONENTISSUEHISTORYID { get; set; }

		public string BATCHID { get; set; }

		public uint? BILLCONTROL { get; set; }

		public uint? BYPASSEXPIRATIONCHECK { get; set; }

		public uint? CDOTYPEID { get; set; }

		public uint? CHANGECOUNT { get; set; }

		public string EXPORTIMPORTKEY { get; set; }

		public string HISTORYID { get; set; }

		public string HISTORYMAINLINEID { get; set; }

		public string INTEGRATIONTXNID { get; set; }

		public string MASTERRECIPEID { get; set; }

		public string RECIPEISSUEITEMID { get; set; }

		public string RECIPELISTID { get; set; }

		public string TXNID { get; set; }

	}

}
