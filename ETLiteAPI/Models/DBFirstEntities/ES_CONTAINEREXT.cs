using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class ES_CONTAINEREXT {

		public string BOMID { get; set; }

		public string CARRIERID { get; set; }

		public string CONTAINERID { get; set; }

		public string CONTAINERNAME { get; set; }

		public string ES_PRIMARYSERIALNUMBER { get; set; }

		public string ES_SERIALNUMBER2 { get; set; }

		public string ES_SERIALNUMBER3 { get; set; }

		public uint? FAILED { get; set; }

		public decimal? FAILEDASNUMBER { get; set; }

		public string IDENTIFIER { get; set; }

		public uint? ISCARRIER { get; set; }

		public string MFGORDERNAME { get; set; }

		public string PRODUCTNAME { get; set; }

		public string PRODUCTREVISION { get; set; }

		public decimal? QTY { get; set; }

		public uint? STATUS { get; set; }

		public string WORKFLOWNAME { get; set; }

		public string WORKFLOWREVISION { get; set; }

		public uint? XOUT { get; set; }

		public decimal? XOUTASNUMBER { get; set; }

	}

}
