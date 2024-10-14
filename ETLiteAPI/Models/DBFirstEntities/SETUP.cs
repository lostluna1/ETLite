using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class SETUP {

		public string SETUPID { get; set; }

		public uint? CDOTYPEID { get; set; }

		public uint? CHANGECOUNT { get; set; }

		public string CHANGEHISTORYID { get; set; }

		public string DESCRIPTION { get; set; }

		public string DOCUMENTSETID { get; set; }

		public string ECO { get; set; }

		public string FILTERTAGS { get; set; }

		public uint? ICONID { get; set; }

		public uint? ISFROZEN { get; set; }

		public string NOTES { get; set; }

		public string RESOURCEGROUPID { get; set; }

		public string SETUPACCESSID { get; set; }

		public string SETUPBASEID { get; set; }

		public string SETUPREVISION { get; set; }

		public uint? STATUS { get; set; }

		public decimal? STDSETUPLABORTIME { get; set; }

		public decimal? STDSETUPTIME { get; set; }

		public string WIPMSGDEFMGRID { get; set; }

	}

}
