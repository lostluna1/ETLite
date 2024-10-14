using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class CIOMESSAGEMAPBASE {

		public string CIOMESSAGEMAPBASEID { get; set; }

		public uint? CDOTYPEID { get; set; }

		public uint? CHANGECOUNT { get; set; }

		public string CIOMESSAGEMAPNAME { get; set; }

		public uint? ICONID { get; set; }

		public string REVOFRCDID { get; set; }

	}

}
