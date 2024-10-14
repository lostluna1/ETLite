using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class BIZ_ATETESTDATA {

		public string BIZ_ATETESTDATAID { get; set; }

		public string BIZ_ATETESTDATANAME { get; set; }

		public uint? CDOTYPEID { get; set; }

		public uint? CHANGECOUNT { get; set; }

		public string CONTAINERID { get; set; }

		public string CURRENTSPEC { get; set; }

		public string HISTORYID { get; set; }

		public string HISTORYMAINLINEID { get; set; }

		public string INTEGRATIONTXNID { get; set; }

		public uint? ISPASS { get; set; }

		public string MFGORDERID { get; set; }

		public string MODELNAME { get; set; }

		public string SPECID { get; set; }

		public DateTime? TESTDATE { get; set; }

		public string TESTSPEC { get; set; }

		public string TXNID { get; set; }

	}

}
