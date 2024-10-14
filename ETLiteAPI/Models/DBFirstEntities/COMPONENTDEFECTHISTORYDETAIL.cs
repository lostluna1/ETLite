﻿using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class COMPONENTDEFECTHISTORYDETAIL {

		public string COMPONENTDEFECTHISTORYDETAILID { get; set; }

		public string ACTUALCOMPONENTISSUEID { get; set; }

		public uint? CDOTYPEID { get; set; }

		public uint? CHANGECOUNT { get; set; }

		public string COMMENTS { get; set; }

		public string CONTAINERID { get; set; }

		public uint? DEFECTCOUNT { get; set; }

		public string DEFECTHISTORYID { get; set; }

		public string EXPORTIMPORTKEY { get; set; }

		public string HISTORYID { get; set; }

		public string INTEGRATIONTXNID { get; set; }

		public string LOT { get; set; }

		public string PRODUCTID { get; set; }

		public string REASONCODEID { get; set; }

		public string REFERENCEDESIGNATOR { get; set; }

		public string STOCKPOINT { get; set; }

		public string TXNID { get; set; }

		public string VENDORITEM { get; set; }

	}

}
