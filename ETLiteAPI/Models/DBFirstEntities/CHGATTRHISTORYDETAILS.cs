using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class CHGATTRHISTORYDETAILS {

		public string CHGATTRHISTORYDETAILSID { get; set; }

		public uint? CDOTYPEID { get; set; }

		public uint? CHANGECOUNT { get; set; }

		public string CHGATTRHISTORYID { get; set; }

		public string EXPORTIMPORTKEY { get; set; }

		public uint? FIELDID { get; set; }

		public string FIELDNAME { get; set; }

		public string HISTORYID { get; set; }

		public string INTEGRATIONTXNID { get; set; }

		public uint? NEWBOOLEANVALUE { get; set; }

		public string NEWDISPLAYVALUE { get; set; }

		public decimal? NEWDURATIONVALUE { get; set; }

		public decimal? NEWFIXEDVALUE { get; set; }

		public decimal? NEWFLOATVALUE { get; set; }

		public uint? NEWINTEGERVALUE { get; set; }

		public string NEWOBJECTID { get; set; }

		public string NEWSTRINGVALUE { get; set; }

		public DateTime? NEWTIMESTAMPVALUE { get; set; }

		public uint? OLDBOOLEANVALUE { get; set; }

		public string OLDDISPLAYVALUE { get; set; }

		public decimal? OLDDURATIONVALUE { get; set; }

		public decimal? OLDFIXEDVALUE { get; set; }

		public decimal? OLDFLOATVALUE { get; set; }

		public uint? OLDINTEGERVALUE { get; set; }

		public string OLDOBJECTID { get; set; }

		public string OLDSTRINGVALUE { get; set; }

		public DateTime? OLDTIMESTAMPVALUE { get; set; }

		public string TXNID { get; set; }

	}

}
