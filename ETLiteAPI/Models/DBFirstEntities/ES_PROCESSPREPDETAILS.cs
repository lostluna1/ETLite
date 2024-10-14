using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class ES_PROCESSPREPDETAILS {

		public string ES_PROCESSPREPDETAILSID { get; set; }

		public string BASEOBJECTID { get; set; }

		public uint? CDOTYPEID { get; set; }

		public uint? CHANGECOUNT { get; set; }

		public uint? ES_ANGLE { get; set; }

		public uint? ES_PLACEMENTTIMEMSEC { get; set; }

		public string ES_PROCESSPREPDETAILSNAME { get; set; }

		public string ES_PRODUCTID { get; set; }

		public decimal? ES_QTY { get; set; }

		public string ES_REFDES { get; set; }

		public decimal? ES_XMM { get; set; }

		public decimal? ES_YMM { get; set; }

		public string EXPORTIMPORTKEY { get; set; }

		public uint? ISFROZEN { get; set; }

	}

}
