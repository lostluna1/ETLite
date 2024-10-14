using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class CIOMESSAGE {

		public string CIOMESSAGEID { get; set; }

		public string ATTRIBUTES { get; set; }

		public uint? CDOTYPEID { get; set; }

		public uint? CHANGECOUNT { get; set; }

		public string CHANNELSOURCENAME { get; set; }

		public string CONTENTS { get; set; }

		public uint? CONTENTTYPE { get; set; }

		public string DESCRIPTION { get; set; }

		public string DESTINATION { get; set; }

		public string DICTKEY { get; set; }

		public uint? ISCACHE { get; set; }

		public string MESSAGENAME { get; set; }

		public DateTime? MESSAGETIMESTAMP { get; set; }

		public DateTime? MESSAGETIMESTAMPGMT { get; set; }

		public string MESSAGETYPE { get; set; }

		public uint? OKTODELETE { get; set; }

		public string ORIGINATOR { get; set; }

		public uint? OWNERS { get; set; }

		public string TAGDATA { get; set; }

	}

}
