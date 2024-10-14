using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class BIZ_SVCTAGSNPRINT {

		public string BIZ_SVCTAGSNPRINTID { get; set; }

		public string BIZ_DATE { get; set; }

		public string BIZ_SVCTAGSNPRINTNAME { get; set; }

		public uint? CDOTYPEID { get; set; }

		public uint? CHANGECOUNT { get; set; }

		public string CONTAINERID { get; set; }

		public uint? CONTAINERTYPE { get; set; }

		public DateTime? CREATETIME { get; set; }

		public string CREATORID { get; set; }

		public string DOCKREV { get; set; }

		public string DPN { get; set; }

		public string HISTORYID { get; set; }

		public string HISTORYMAINLINEID { get; set; }

		public string INTEGRATIONTXNID { get; set; }

		public string LABELTEMPLATE { get; set; }

		public string LASTPRINTINGEMPLOYEEID { get; set; }

		public DateTime? LASTPRINTINGTIME { get; set; }

		public string MAC { get; set; }

		public string MFGDATE { get; set; }

		public string MFGORDERID { get; set; }

		public string PPID { get; set; }

		public string PPIDVIEW { get; set; }

		public uint? PRINTCOUNT { get; set; }

		public string PRODUCTID { get; set; }

		public string SERVICECODE { get; set; }

		public string SPECID { get; set; }

		public string STPPID { get; set; }

		public string TXNID { get; set; }

		public string WT { get; set; }

	}

}
