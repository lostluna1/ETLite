using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class ES_PROCESSPREPDETAILLIST {

		public string ES_PROCESSPREPDETAILLISTID { get; set; }

		public string BASEOBJECTID { get; set; }

		public uint? CDOTYPEID { get; set; }

		public uint? CHANGECOUNT { get; set; }

		public decimal? ES_ANGLE { get; set; }

		public uint? ES_PLACEMENTTIMEINMSEC { get; set; }

		public string ES_PROCESSPREPDETAILLISTNAME { get; set; }

		public string ES_PRODUCTID { get; set; }

		public decimal? ES_QTY { get; set; }

		public string ES_REFDES { get; set; }

		public decimal? ES_XMM { get; set; }

		public decimal? ES_YMM { get; set; }

		public uint? ISFROZEN { get; set; }

	}

}
