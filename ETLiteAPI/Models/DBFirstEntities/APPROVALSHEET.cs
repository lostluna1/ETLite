using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class APPROVALSHEET {

		public string APPROVALSHEETID { get; set; }

		public string APPROVALDECISIONLISTID { get; set; }

		public uint? APPROVALREQUIRED { get; set; }

		public string APPROVALROUTINGINFOID { get; set; }

		public string APPROVALSHEETNAME { get; set; }

		public uint? CDOTYPEID { get; set; }

		public uint? CHANGECOUNT { get; set; }

		public uint? CHILDOPENOPTION { get; set; }

		public uint? CHILDROUTINGOPTION { get; set; }

		public string COMMENTS { get; set; }

		public string DESCRIPTION { get; set; }

		public uint? DESIGNATEONAPPROVAL { get; set; }

		public string EXPORTIMPORTKEY { get; set; }

		public uint? FROMSTAGE { get; set; }

		public string GENERALINSTRUCTIONS { get; set; }

		public uint? ISFROZEN { get; set; }

		public DateTime? LASTAPPROVALCYCLE { get; set; }

		public DateTime? LASTAPPROVALCYCLEGMT { get; set; }

		public string PARENTID { get; set; }

		public uint? STATUS { get; set; }

		public uint? TOSTAGE { get; set; }

	}

}
