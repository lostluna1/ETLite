using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class TRAININGREQUIREMENTBASE {

		public string TRAININGREQUIREMENTBASEID { get; set; }

		public uint? CDOTYPEID { get; set; }

		public uint? CHANGECOUNT { get; set; }

		public uint? ICONID { get; set; }

		public string REVOFRCDID { get; set; }

		public string TRAININGREQUIREMENTNAME { get; set; }

	}

}
