using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class CONTAINERATTRHISTORYDETAIL {

		public string CONTAINERATTRHISTORYDETAILID { get; set; }

		public string ATTRIBUTENAME_AFTER { get; set; }

		public string ATTRIBUTENAME_BEFORE { get; set; }

		public string ATTRIBUTEVALUE_AFTER { get; set; }

		public string ATTRIBUTEVALUE_BEFORE { get; set; }

		public uint? CDOTYPEID { get; set; }

		public uint? CHANGECOUNT { get; set; }

		public string CONTAINERATTRMAINTHISTORYID { get; set; }

		public uint? DATATYPE_AFTER { get; set; }

		public uint? DATATYPE_BEFORE { get; set; }

		public string EXPORTIMPORTKEY { get; set; }

		public string HISTORYID { get; set; }

		public string INTEGRATIONTXNID { get; set; }

		public string TXNID { get; set; }

	}

}
