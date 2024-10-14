using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class EVENTCLASSIFICATIONSPECMAP {

		public string EVENTCLASSIFICATIONSPECMAPID { get; set; }

		public uint? CDOTYPEID { get; set; }

		public uint? CHANGECOUNT { get; set; }

		public string CHECKLISTTEMPLATEID { get; set; }

		public string CLASSIFICATIONID { get; set; }

		public string EXPORTIMPORTKEY { get; set; }

		public string FAILUREMODEGROUPID { get; set; }

		public uint? ISFROZEN { get; set; }

		public string ORGANIZATIONID { get; set; }

		public string OWNERID { get; set; }

		public uint? PEDEFAULT { get; set; }

		public string ROLEID { get; set; }

		public string SUBCLASSIFICATIONID { get; set; }

	}

}
