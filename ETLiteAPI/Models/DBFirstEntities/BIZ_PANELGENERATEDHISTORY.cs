using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class BIZ_PANELGENERATEDHISTORY {

		public string BIZ_PANELGENERATEDHISTORYID { get; set; }

		public string BIZ_PANELGENERATEDHISTORYNAME { get; set; }

		public uint? CDOTYPEID { get; set; }

		public uint? CHANGECOUNT { get; set; }

		public string CREATEEMPLOYEEID { get; set; }

		public DateTime? CREATETIME { get; set; }

		public string HISTORYID { get; set; }

		public string HISTORYMAINLINEID { get; set; }

		public string INTEGRATIONTXNID { get; set; }

		public uint? ISLASER { get; set; }

		public uint? ISUPLOAD { get; set; }

		public DateTime? LASERTIME { get; set; }

		public string MFGORDERID { get; set; }

		public string PANELCODE { get; set; }

		public string PCBSIDE { get; set; }

		public string SERIALCODE { get; set; }

		public string TXNID { get; set; }

		public DateTime? UPLOADTIME { get; set; }

	}

}
