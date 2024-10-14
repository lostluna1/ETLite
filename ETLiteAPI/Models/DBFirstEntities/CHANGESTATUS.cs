using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class CHANGESTATUS {

		public string CHANGESTATUSID { get; set; }

		public uint? CDOTYPEID { get; set; }

		public uint? CHANGECOUNT { get; set; }

		public string CIOMESSAGEID { get; set; }

		public uint? CONTROL { get; set; }

		public DateTime? CREATIONDATE { get; set; }

		public DateTime? CREATIONDATEGMT { get; set; }

		public string CREATIONUSERNAME { get; set; }

		public uint? CURRENTSTATUS { get; set; }

		public string EXPORTIMPORTKEY { get; set; }

		public uint? ISFROZEN { get; set; }

		public DateTime? LASTCHANGEDATE { get; set; }

		public DateTime? LASTCHANGEDATEGMT { get; set; }

		public string NOTES { get; set; }

		public uint? PARENTCDOID { get; set; }

		public string PARENTID { get; set; }

		public string USERID { get; set; }

	}

}
