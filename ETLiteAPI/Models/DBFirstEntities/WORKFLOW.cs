using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class WORKFLOW {

		public string WORKFLOWID { get; set; }

		public uint? CDOTYPEID { get; set; }

		public uint? CHANGECOUNT { get; set; }

		public string CHANGEHISTORYID { get; set; }

		public string DESCRIPTION { get; set; }

		public string ECO { get; set; }

		public string ERPROUTEBASEID { get; set; }

		public string ERPROUTEID { get; set; }

		public string FILTERTAGS { get; set; }

		public string FIRSTSTEPID { get; set; }

		public uint? ICONID { get; set; }

		public string IMAGE { get; set; }

		public uint? ISFROZEN { get; set; }

		public string NOTES { get; set; }

		public string SCHEDULINGROUTEID { get; set; }

		public string SETUPACCESSID { get; set; }

		public uint? STATUS { get; set; }

		public decimal? TOTALCYCLETIME { get; set; }

		public decimal? TOTALYIELD { get; set; }

		public string WIPMSGDEFMGRID { get; set; }

		public string WORKFLOWBASEID { get; set; }

		public string WORKFLOWREVISION { get; set; }

	}

}
