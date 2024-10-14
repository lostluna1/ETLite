using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class ERPBOM {

		public string ERPBOMID { get; set; }

		public string BILLTYPEID { get; set; }

		public string BIZ_BOMTYPE { get; set; }

		public DateTime? BIZ_EFFECTIVEFROMDATE { get; set; }

		public DateTime? BIZ_EFFECTIVETHROUGHDATE { get; set; }

		public string BIZ_PRODUCTID { get; set; }

		public string BIZ_STATUS { get; set; }

		public uint? CDOTYPEID { get; set; }

		public uint? CHANGECOUNT { get; set; }

		public string CHANGEHISTORYID { get; set; }

		public string DESCRIPTION { get; set; }

		public string ECO { get; set; }

		public string ERPBOMBASEID { get; set; }

		public string ERPBOMREVISION { get; set; }

		public string ERPROUTEBASEID { get; set; }

		public string ERPROUTEID { get; set; }

		public uint? EXTERNALLYCONTROLLED { get; set; }

		public string FILTERTAGS { get; set; }

		public uint? ICONID { get; set; }

		public uint? ISFROZEN { get; set; }

		public string NOTES { get; set; }

		public string SETUPACCESSID { get; set; }

		public uint? STATUS { get; set; }

		public string WIPMSGDEFMGRID { get; set; }

	}

}
