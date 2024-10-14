using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class PROCESSMODELTEMPLATE {

		public string PROCESSMODELTEMPLATEID { get; set; }

		public uint? ALLOWREASSIGNMENT { get; set; }

		public string ASSIGNEEID { get; set; }

		public uint? ASSIGNEEOPTION { get; set; }

		public string ASSIGNEEROLEID { get; set; }

		public uint? AUTOCOMPLETE { get; set; }

		public uint? CDOTYPEID { get; set; }

		public uint? CHANGECOUNT { get; set; }

		public string CHANGEHISTORYID { get; set; }

		public uint? DEFAULTASSIGNEEINFO { get; set; }

		public string DESCRIPTION { get; set; }

		public string DOCUMENTSETID { get; set; }

		public DateTime? EFFECTIVEFROMDATE { get; set; }

		public DateTime? EFFECTIVEFROMDATEGMT { get; set; }

		public DateTime? EFFECTIVETHRUDATE { get; set; }

		public DateTime? EFFECTIVETHRUDATEGMT { get; set; }

		public string FILTERTAGS { get; set; }

		public uint? ICONID { get; set; }

		public uint? ISFROZEN { get; set; }

		public string NOTES { get; set; }

		public string PROCESSMODELTEMPLATEBASEID { get; set; }

		public string REVISION { get; set; }

		public string SETUPACCESSID { get; set; }

		public uint? STATUS { get; set; }

	}

}
