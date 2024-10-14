using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class PATH {

		public string PATHID { get; set; }

		public uint? CDOTYPEID { get; set; }

		public uint? CHANGECOUNT { get; set; }

		public string DESCRIPTION { get; set; }

		public string ENDREWORKSTEPID { get; set; }

		public string EXPORTIMPORTKEY { get; set; }

		public string FROMSTEPID { get; set; }

		public uint? ISFROZEN { get; set; }

		public string NOTES { get; set; }

		public string PATHNAME { get; set; }

		public string REENTRYSTEPID { get; set; }

		public string RETURNTOSTEPID { get; set; }

		public string TOSTEPID { get; set; }

		public string TXNDETAILSID { get; set; }

	}

}
