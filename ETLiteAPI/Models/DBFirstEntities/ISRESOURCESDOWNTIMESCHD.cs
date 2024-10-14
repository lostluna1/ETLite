using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class ISRESOURCESDOWNTIMESCHD {

		public uint? CDOTYPEID { get; set; }

		public string ISDOWNTIMESCHEDULEID { get; set; }

		public DateTime? ISENDTIME { get; set; }

		public DateTime? ISSTARTTIME { get; set; }

		public string RESOURCEFAMILYID { get; set; }

		public string RESOURCEFAMILYNAME { get; set; }

		public string RESOURCEID { get; set; }

		public string RESOURCENAME { get; set; }

	}

}
