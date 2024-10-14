using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class COLLABORATORDATA {

		public string COLLABORATORDATAID { get; set; }

		public uint? CDOTYPEID { get; set; }

		public uint? CHANGECOUNT { get; set; }

		public string COLLABORATORDATANAME { get; set; }

		public string EMAILMESSAGETOCOLLABORATORID { get; set; }

		public string EMAILMESSAGETOOWNERID { get; set; }

		public string GENERALINSTRUCTIONS { get; set; }

		public uint? NOTIFYCOLLABORATORS { get; set; }

		public string PARENTID { get; set; }

	}

}
