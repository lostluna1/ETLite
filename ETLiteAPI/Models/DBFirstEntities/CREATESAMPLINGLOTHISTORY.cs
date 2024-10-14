using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class CREATESAMPLINGLOTHISTORY {

		public string CREATESAMPLINGLOTHISTORYID { get; set; }

		public uint? ALLOWADJUSTTOLOTSIZE { get; set; }

		public uint? CDOTYPEID { get; set; }

		public uint? CHANGECOUNT { get; set; }

		public string COMMENTS { get; set; }

		public DateTime? CREATIONDATE { get; set; }

		public string EXPORTIMPORTKEY { get; set; }

		public string HISTORYID { get; set; }

		public string HISTORYMAINLINEID { get; set; }

		public string LOTNAME { get; set; }

		public string PRODUCTID { get; set; }

		public decimal? QTY { get; set; }

		public uint? SAMPLERATE { get; set; }

		public string SAMPLINGPLANID { get; set; }

		public string TXNID { get; set; }

		public string UOMID { get; set; }

	}

}
