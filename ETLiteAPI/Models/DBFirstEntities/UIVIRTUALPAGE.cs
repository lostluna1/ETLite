using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class UIVIRTUALPAGE {

		public string UIVIRTUALPAGEID { get; set; }

		public uint? CDOTYPEID { get; set; }

		public uint? CHANGECOUNT { get; set; }

		public string CHANGEHISTORYID { get; set; }

		public string CODEBEHINDFILE { get; set; }

		public string CREATEDBYID { get; set; }

		public string DESCRIPTION { get; set; }

		public string DEVELOPERPERSONALIZATIONID { get; set; }

		public uint? EPROCENABLED { get; set; }

		public string FILTERTAGS { get; set; }

		public uint? ICONID { get; set; }

		public uint? INCLUDESREPORTSORCHARTS { get; set; }

		public uint? ISFROZEN { get; set; }

		public string NOTES { get; set; }

		public string SETUPACCESSID { get; set; }

		public string SUBMENUNAME { get; set; }

		public string TEMPLATEPAGE { get; set; }

		public string UIVIRTUALPAGENAME { get; set; }

	}

}
