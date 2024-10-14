using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class COLLECTSAMPLINGTESTDTLHISTORY {

		public string COLLECTSAMPLINGTESTDTLHISTORID { get; set; }

		public uint? CDOTYPEID { get; set; }

		public uint? CHANGECOUNT { get; set; }

		public uint? DATATYPE { get; set; }

		public string DATAVALUE { get; set; }

		public string ENTEREDQTY { get; set; }

		public string EXPORTIMPORTKEY { get; set; }

		public string HISTORYDETAILSID { get; set; }

		public string HISTORYID { get; set; }

		public string LOWERLIMIT { get; set; }

		public uint? PASSED { get; set; }

		public string REJECTREASONID { get; set; }

		public string SAMPLEDATAPOINTID { get; set; }

		public string TXNID { get; set; }

		public string UPPERLIMIT { get; set; }

	}

}
