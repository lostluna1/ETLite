using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class OUTBOUNDXMLDOCPROCESSING {

		public uint DOCID { get; set; }

		public string TXNID { get; set; }

		public string DATATRANSPORTID { get; set; }

		public string OWNEDBYUUID { get; set; }

		public DateTime? STARTTIMESTAMP { get; set; }

	}

}
