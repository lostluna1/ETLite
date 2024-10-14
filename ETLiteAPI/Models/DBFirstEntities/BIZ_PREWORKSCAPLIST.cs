using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class BIZ_PREWORKSCAPLIST {

		public string BIZ_PREWORKSCAPLISTID { get; set; }

		public string BIZ_BUID { get; set; }

		public string BIZ_DEPTID { get; set; }

		public string BIZ_PREWORKSCAPLISTNAME { get; set; }

		public string BIZ_PREWORKSCRAPID { get; set; }

		public string BU { get; set; }

		public uint? CDOTYPEID { get; set; }

		public uint? CHANGECOUNT { get; set; }

		public string COMMENTS { get; set; }

		public string CONTAINERID { get; set; }

		public string EMPLOYEEID { get; set; }

		public string ISDEFECTREASONID { get; set; }

		public uint? ISFROZEN { get; set; }

		public string LINE { get; set; }

		public string MFGLINEID { get; set; }

		public string MFGORDERID { get; set; }

		public string PRODUCTID { get; set; }

		public string PRODUCTNAME { get; set; }

		public string RESOURCEID { get; set; }

		public decimal? SCRAPQTY { get; set; }

		public string SCRAPRATIO { get; set; }

		public string SCRAPREASON { get; set; }

		public string SCRAPRESOURCEID { get; set; }

		public string SCRAPSPECID { get; set; }

		public DateTime? SCRAPTIME { get; set; }

		public string SCRAPTYPE { get; set; }

		public string SHIFTID { get; set; }

		public string SPECID { get; set; }

		public string UOMID { get; set; }

	}

}
