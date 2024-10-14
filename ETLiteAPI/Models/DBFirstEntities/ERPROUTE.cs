using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class ERPROUTE {

		public string ERPROUTEID { get; set; }

		public DateTime? BIZ_EFFECTIVEFROMDATE { get; set; }

		public DateTime? BIZ_EFFECTIVETHROUGHDATA { get; set; }

		public DateTime? BIZ_EFFECTIVETHROUGHDATE { get; set; }

		public uint? CDOTYPEID { get; set; }

		public uint? CHANGECOUNT { get; set; }

		public string CHANGEHISTORYID { get; set; }

		public string DESCRIPTION { get; set; }

		public string ECO { get; set; }

		public string ERPITEM { get; set; }

		public string ERPROUTEBASEID { get; set; }

		public string ERPROUTEREVISION { get; set; }

		public string FILTERTAGS { get; set; }

		public uint? ICONID { get; set; }

		public uint? ISFROZEN { get; set; }

		public string NOTES { get; set; }

		public string PRODUCTBASEID { get; set; }

		public string PRODUCTID { get; set; }

		public string SETUPACCESSID { get; set; }

		public uint? STATUS { get; set; }

		public string WIPMSGDEFMGRID { get; set; }

	}

}
