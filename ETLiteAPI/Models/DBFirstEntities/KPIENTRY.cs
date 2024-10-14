using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class KPIENTRY {

		public string KPIENTRYID { get; set; }

		public uint? ACTIVE { get; set; }

		public uint? CDOTYPEID { get; set; }

		public uint? CHANGECOUNT { get; set; }

		public decimal? HIGHLIMIT { get; set; }

		public uint? ISFROZEN { get; set; }

		public string KPIENTRYNAME { get; set; }

		public string KPIMATRIXID { get; set; }

		public string KPITIMEFRAMEID { get; set; }

		public string KPITYPEID { get; set; }

		public decimal? LOWLIMIT { get; set; }

		public string OPERATIONID { get; set; }

		public uint? PRIORITY { get; set; }

		public string PRODUCTBASEID { get; set; }

		public string PRODUCTID { get; set; }

		public string RECIPENAME { get; set; }

		public string RESOURCEID { get; set; }

		public string RESOURCETYPEID { get; set; }

		public string ROUTESTEPID { get; set; }

		public string SPECBASEID { get; set; }

		public string SPECID { get; set; }

		public decimal? TARGETVALUE { get; set; }

		public string UOMID { get; set; }

	}

}
