using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class HVRESOURCESETUPHISTORY {

		public string HVRESOURCESETUPHISTORYID { get; set; }

		public uint? CDOTYPEID { get; set; }

		public uint? CHANGECOUNT { get; set; }

		public uint? CHANGELEVEL { get; set; }

		public uint? DEVICEID { get; set; }

		public string HISTORYID { get; set; }

		public string HISTORYMAINLINEID { get; set; }

		public string HVRESOURCESETUPHISTORYNAME { get; set; }

		public uint? MCID { get; set; }

		public string PRIORSETUPID { get; set; }

		public string RESOURCEID { get; set; }

		public DateTime? TXNDATEGMT { get; set; }

		public string TXNID { get; set; }

	}

}
