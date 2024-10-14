using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class ISRESOLVEDDOWNTIMESCHD {

		public string ISRESOLVEDDOWNTIMESCHDID { get; set; }

		public uint? CDOTYPEID { get; set; }

		public uint? CHANGECOUNT { get; set; }

		public DateTime? ISCALDATE { get; set; }

		public decimal? ISDURATION { get; set; }

		public DateTime? ISENDTIME { get; set; }

		public uint? ISFROZEN { get; set; }

		public string ISRESOLVEDDOWNTIMESCHDNAME { get; set; }

		public string ISSHIFTID { get; set; }

		public DateTime? ISSTARTTIME { get; set; }

		public string RESOURCEID { get; set; }

	}

}
