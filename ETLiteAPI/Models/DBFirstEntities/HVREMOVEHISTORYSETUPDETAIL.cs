using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class HVREMOVEHISTORYSETUPDETAIL {

		public string HVREMOVEHISTORYSETUPDETAILID { get; set; }

		public uint? CDOTYPEID { get; set; }

		public uint? CHANGECOUNT { get; set; }

		public string CONTAINERID { get; set; }

		public string HISTORYID { get; set; }

		public string HVISSUEHISTORYDETAILID { get; set; }

		public string HVREMOVEHISTORYSETUPDETAILNAME { get; set; }

		public string HVSETUPDETAILID { get; set; }

		public string HVSETUPID { get; set; }

		public string INTEGRATIONTXNID { get; set; }

		public string MATERIALLISTITEMID { get; set; }

		public string PARENTID { get; set; }

		public string TXNID { get; set; }

	}

}
