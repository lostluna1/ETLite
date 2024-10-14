using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class BIZ_MATERIALLIST {

		public string BIZ_MATERIALLISTID { get; set; }

		public string APPLYEMP { get; set; }

		public DateTime? APPLYTIME { get; set; }

		public string BIZ_MATERIALLISTNAME { get; set; }

		public uint? CDOTYPEID { get; set; }

		public uint? CHANGECOUNT { get; set; }

		public string CHANGEHISTORYID { get; set; }

		public string DESCRIPTION { get; set; }

		public string FILTERTAGS { get; set; }

		public uint? ICONID { get; set; }

		public uint? ISFROZEN { get; set; }

		public decimal? ISSUEQTY { get; set; }

		public decimal? LEFTQTY { get; set; }

		public string MFGORDERID { get; set; }

		public string NOTES { get; set; }

		public string ORDERSTATUSID { get; set; }

		public string PRODUCTID { get; set; }

		public string RESOURCEID { get; set; }

		public string SETUPACCESSID { get; set; }

		public string SPECID { get; set; }

		public decimal? TOTALQTY { get; set; }

	}

}
