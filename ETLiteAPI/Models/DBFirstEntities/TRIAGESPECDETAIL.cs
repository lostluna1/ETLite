using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class TRIAGESPECDETAIL {

		public string TRIAGESPECDETAILID { get; set; }

		public uint? AUTOROUTE { get; set; }

		public uint? CARREQUIRED { get; set; }

		public uint? CDOTYPEID { get; set; }

		public uint? CHANGECOUNT { get; set; }

		public string CHECKLISTTEMPLATEID { get; set; }

		public string EXPORTIMPORTKEY { get; set; }

		public uint? ISFROZEN { get; set; }

		public string OWNERID { get; set; }

		public string PROCESSMODELID { get; set; }

		public string ROLEID { get; set; }

		public uint? TOCATEGORY { get; set; }

		public string TRIAGESPECDETAILNAME { get; set; }

		public string TRIAGESPECID { get; set; }

	}

}
