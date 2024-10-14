using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class BIZ_PREWORKSCRAPMANAGEMENT {

		public string BIZ_PREWORKSCRAPMANAGEMENTID { get; set; }

		public string BIZ_BUID { get; set; }

		public string BIZ_PREWORKSCRAPMANAGEMENTNAME { get; set; }

		public uint? CDOTYPEID { get; set; }

		public uint? CHANGECOUNT { get; set; }

		public string CHANGEHISTORYID { get; set; }

		public string DESCRIPTION { get; set; }

		public string EMPLOYEEID { get; set; }

		public string FILTERTAGS { get; set; }

		public uint? ICONID { get; set; }

		public uint? ISFROZEN { get; set; }

		public string MFGLINEID { get; set; }

		public string NOTES { get; set; }

		public string PRODUCTID { get; set; }

		public string RESOURCEID { get; set; }

		public string SCRAPCOMMENT { get; set; }

		public decimal? SCRAPQTY { get; set; }

		public string SCRAPRESOURCEID { get; set; }

		public string SCRAPSPECID { get; set; }

		public DateTime? SCRAPTIME { get; set; }

		public string SETUPACCESSID { get; set; }

		public string SHIFTID { get; set; }

		public string SPECID { get; set; }

		public string WOID { get; set; }

	}

}
