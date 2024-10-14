using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class CIOJOURNALPERSIST {

		public string CIOJOURNALPERSISTID { get; set; }

		public string BROADCASTADDRESS { get; set; }

		public uint? BROADCASTPORT { get; set; }

		public uint? CDOTYPEID { get; set; }

		public uint? CHANGECOUNT { get; set; }

		public string CIOJOURNALTYPE { get; set; }

		public uint? COMPRESSINTERVAL { get; set; }

		public string CONNECTIONNAME { get; set; }

		public string EXPORTIMPORTKEY { get; set; }

		public uint? ISFROZEN { get; set; }

		public string PARENTID { get; set; }

		public uint? PERSISTINTERVAL { get; set; }

		public string STORENAME { get; set; }

	}

}
