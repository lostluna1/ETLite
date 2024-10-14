using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class COLLECTSAMPLINGDATAHISTORY {

		public string COLLECTSAMPLINGDATAHISTORYID { get; set; }

		public uint? ALLOWEDREJECTS { get; set; }

		public string AQLLEVELID { get; set; }

		public uint? CDOTYPEID { get; set; }

		public uint? CHANGECOUNT { get; set; }

		public string EXPORTIMPORTKEY { get; set; }

		public string HISTORYID { get; set; }

		public string HISTORYMAINLINEID { get; set; }

		public string INSPECTIONLEVELID { get; set; }

		public string MFGORDERID { get; set; }

		public string PRODUCTID { get; set; }

		public uint? REQUIREDSAMPLES { get; set; }

		public string RESOURCEID { get; set; }

		public uint? SAMPLESTESTED { get; set; }

		public string SAMPLETESTID { get; set; }

		public string SAMPLINGLOTID { get; set; }

		public string SAMPLINGPLANID { get; set; }

		public string SAMPLINGSTATUS { get; set; }

		public string SPECID { get; set; }

		public uint? TOTALPASSEDSAMPLES { get; set; }

		public uint? TOTALREJECTS { get; set; }

		public uint? TOTALSAMPLESCOMPLETED { get; set; }

		public DateTime? TXNDATEGMT { get; set; }

		public string TXNID { get; set; }

		public string VENDORID { get; set; }

		public string VENDORITEMID { get; set; }

	}

}
