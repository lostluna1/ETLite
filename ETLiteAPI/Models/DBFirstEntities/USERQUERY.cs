using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class USERQUERY {

		public string USERQUERYID { get; set; }

		public uint? ALLOWONLINEQUERY { get; set; }

		public uint? CDOTYPEID { get; set; }

		public uint? CHANGECOUNT { get; set; }

		public string CHANGEHISTORYID { get; set; }

		public string DESCRIPTION { get; set; }

		public string FILTERTAGS { get; set; }

		public uint? ICONID { get; set; }

		public uint? ISFROZEN { get; set; }

		public string NAMECOLUMN { get; set; }

		public string NOTES { get; set; }

		public string QUERYTEXT { get; set; }

		public uint? QUERYTYPEID { get; set; }

		public uint? RESULTSETSIZELIMIT { get; set; }

		public string SETUPACCESSID { get; set; }

		public string USERQUERYNAME { get; set; }

		public uint? USERQUERYTYPE { get; set; }

	}

}
