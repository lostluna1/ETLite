using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class CIOSMSENTRY {

		public string CIOSMSENTRYID { get; set; }

		public uint? CDOTYPEID { get; set; }

		public uint? CHANGECOUNT { get; set; }

		public string CIOSMSADAPTERID { get; set; }

		public string CIOSMSENTRYNAME { get; set; }

		public string DESCRIPTION { get; set; }

		public string EXPORTIMPORTKEY { get; set; }

		public string INBOUNDTEMPLATE { get; set; }

		public uint? ISFROZEN { get; set; }

		public string OUTBOUNDTEMPLATE { get; set; }

		public string USERQUERYID { get; set; }

	}

}
