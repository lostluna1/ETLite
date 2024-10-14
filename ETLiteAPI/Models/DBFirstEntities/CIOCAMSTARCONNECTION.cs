using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class CIOCAMSTARCONNECTION {

		public string CIOCAMSTARCONNECTIONID { get; set; }

		public string BODY { get; set; }

		public uint? CDOTYPEID { get; set; }

		public uint? CHANGECOUNT { get; set; }

		public string CHANGEHISTORYID { get; set; }

		public uint? CIOAUTHENTICATIONTYPE { get; set; }

		public string CIOCAMSTARCONNECTIONNAME { get; set; }

		public string DESCRIPTION { get; set; }

		public string EXTERNALUSERNAME { get; set; }

		public string FILTERTAGS { get; set; }

		public string HOST { get; set; }

		public uint? ICONID { get; set; }

		public uint? ISFROZEN { get; set; }

		public string NOTES { get; set; }

		public string PASSWORD { get; set; }

		public uint? PORT { get; set; }

		public string SETUPACCESS { get; set; }

		public string TOKENURL { get; set; }

		public string USERNAMEID { get; set; }

	}

}
