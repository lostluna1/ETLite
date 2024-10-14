using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class PACKAGECREATIONTEMPLATE {

		public string PACKAGECREATIONTEMPLATEID { get; set; }

		public string APPROVALTEMPLATEID { get; set; }

		public uint? CDOTYPEID { get; set; }

		public uint? CHANGECOUNT { get; set; }

		public string CHANGEHISTORYID { get; set; }

		public string COLLABORATORTEMPLATEID { get; set; }

		public string DESCRIPTION { get; set; }

		public string ECOECN { get; set; }

		public string FILTERTAGS { get; set; }

		public uint? ICONID { get; set; }

		public uint? ISFROZEN { get; set; }

		public string NOTES { get; set; }

		public string OWNERROLEID { get; set; }

		public string PACKAGECREATIONREASONID { get; set; }

		public string PACKAGECREATIONTEMPLATENAME { get; set; }

		public string PACKAGEDESCRIPTION { get; set; }

		public string PACKAGEOWNERID { get; set; }

		public string PACKAGEPRIORITYCODEID { get; set; }

		public string PACKAGETYPEID { get; set; }

		public string SOURCESYSTEMID { get; set; }

		public uint? USECONTENTCOLLABORATORS { get; set; }

		public string WORKFLOWID { get; set; }

	}

}
