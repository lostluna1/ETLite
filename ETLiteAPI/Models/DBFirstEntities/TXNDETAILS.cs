using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class TXNDETAILS {

		public string TXNDETAILSID { get; set; }

		public uint? CDOTYPEID { get; set; }

		public uint? CHANGECOUNT { get; set; }

		public string EXPORTIMPORTKEY { get; set; }

		public uint? ISFROZEN { get; set; }

		public string NEWOWNERID { get; set; }

		public string PATHID { get; set; }

		public string REWORKREASONID { get; set; }

		public string TOCONTAINERLEVELID { get; set; }

		public string TOCONTAINERNAME { get; set; }

		public uint? TOCONTAINEROPTION { get; set; }

		public uint? TXNTYPE { get; set; }

	}

}
