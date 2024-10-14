using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class BIZ_PREFEEDING {

		public string BIZ_PREFEEDINGID { get; set; }

		public string BIZ_PREFEEDINGNAME { get; set; }

		public uint? CDOTYPEID { get; set; }

		public uint? CHANGECOUNT { get; set; }

		public string CHANGEHISTORYID { get; set; }

		public string CONTAINERID { get; set; }

		public string DESCRIPTION { get; set; }

		public string FEEDERID { get; set; }

		public string FEEDERSLOTID { get; set; }

		public string FILTERTAGS { get; set; }

		public uint? ICONID { get; set; }

		public string IPQCAUDITORID { get; set; }

		public string IPQCAUDITORNOTE { get; set; }

		public DateTime? IPQCAUDITORTIME { get; set; }

		public uint? ISFROZEN { get; set; }

		public string LOADERID { get; set; }

		public DateTime? LOADTIME { get; set; }

		public string MFGAUDITORID { get; set; }

		public string MFGAUDITORNOTE { get; set; }

		public DateTime? MFGAUDITORTIME { get; set; }

		public string MFGLINEID { get; set; }

		public string MFGORDERID { get; set; }

		public string NOTES { get; set; }

		public string PRODUCTID { get; set; }

		public decimal? QTY { get; set; }

		public decimal? REMAINQTY { get; set; }

		public string REPLACEAUDITORID { get; set; }

		public string REPLACEAUDNOTE { get; set; }

		public DateTime? REPLACEAUDTIME { get; set; }

		public string RESOURCEID { get; set; }

		public decimal? SCRAPQTY { get; set; }

		public string SETUPACCESSID { get; set; }

		public uint? STATU { get; set; }

		public string UNLOADERID { get; set; }

		public DateTime? UNLOADTIME { get; set; }

	}

}
