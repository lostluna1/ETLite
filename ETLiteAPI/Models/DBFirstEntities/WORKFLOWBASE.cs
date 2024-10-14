using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class WORKFLOWBASE {

		public uint? CDOTYPEID { get; set; }

		public uint? CHANGECOUNT { get; set; }

		public uint? ICONID { get; set; }

		public string REVOFRCDID { get; set; }

		public string WORKFLOWBASEID { get; set; }

		public string WORKFLOWNAME { get; set; }

	}

}
