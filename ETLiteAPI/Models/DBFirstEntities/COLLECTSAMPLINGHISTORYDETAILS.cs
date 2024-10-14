using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class COLLECTSAMPLINGHISTORYDETAILS {

		public string COLLECTSAMPLINGHISTORYDETAILID { get; set; }

		public uint? CDOTYPEID { get; set; }

		public uint? CHANGECOUNT { get; set; }

		public string EXPORTIMPORTKEY { get; set; }

		public string HISTORYDETAILSID { get; set; }

		public string HISTORYID { get; set; }

		public uint? REJECTED { get; set; }

		public uint? REJECTS { get; set; }

		public string SAMPLETESTID { get; set; }

		public string SAMPLETESTNAME { get; set; }

		public string TXNID { get; set; }

	}

}
