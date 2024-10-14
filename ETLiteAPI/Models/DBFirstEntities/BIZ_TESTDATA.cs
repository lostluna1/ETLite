using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class BIZ_TESTDATA {

		public string BIZ_TESTDATAID { get; set; }

		public string BIZ_TESTDATANAME { get; set; }

		public uint? CDOTYPEID { get; set; }

		public uint? CHANGECOUNT { get; set; }

		public string CONTAINERID { get; set; }

		public string CONTAINERNAME { get; set; }

		public DateTime? CREATETIME { get; set; }

		public string HISTORYID { get; set; }

		public string HISTORYMAINLINEID { get; set; }

		public string INTEGRATIONTXNID { get; set; }

		public uint? ISPASS { get; set; }

		public string MFGLINE { get; set; }

		public string MFGORDERID { get; set; }

		public string MFGORDERNAME { get; set; }

		public DateTime? MOVEDATE { get; set; }

		public string MOVEREMARK { get; set; }

		public uint? QTY { get; set; }

		public string RESOURCEID { get; set; }

		public string SPECID { get; set; }

		public uint? STATUS { get; set; }

		public DateTime? TESTDATE { get; set; }

		public string TXNID { get; set; }

	}

}
