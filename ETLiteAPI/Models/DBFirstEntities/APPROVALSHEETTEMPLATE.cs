using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class APPROVALSHEETTEMPLATE {

		public string APPROVALSHEETTEMPLATEID { get; set; }

		public string APPROVALDECISIONLISTID { get; set; }

		public uint? APPROVALREQUIRED { get; set; }

		public string APPROVALSHEETTEMPLATENAME { get; set; }

		public uint? CDOTYPEID { get; set; }

		public uint? CHANGECOUNT { get; set; }

		public string CHANGEHISTORYID { get; set; }

		public string DESCRIPTION { get; set; }

		public string FILTERTAGS { get; set; }

		public uint? FROMSTAGE { get; set; }

		public string GENERALINSTRUCTIONS { get; set; }

		public uint? ICONID { get; set; }

		public uint? ISFROZEN { get; set; }

		public string NOTES { get; set; }

		public string SETUPACCESSID { get; set; }

		public uint? TOSTAGE { get; set; }

	}

}
