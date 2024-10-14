using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class ES_CONTAINERMOVEHISTORY {

		public string CONTAINERID { get; set; }

		public string CONTAINERNAME { get; set; }

		public decimal? CYCLETIME { get; set; }

		public string ES_PRIMARYSERIALNUMBER { get; set; }

		public string ES_RECIPEID { get; set; }

		public string ES_SERIALNUMBER2 { get; set; }

		public string ES_SERIALNUMBER3 { get; set; }

		public uint? ISFAILED { get; set; }

		public DateTime? MOVEINDATE { get; set; }

		public DateTime? MOVEOUTDATE { get; set; }

		public string OPERATION { get; set; }

		public string PARENTCONTAINERID { get; set; }

		public string RESOURCENAME { get; set; }

		public string SPEC { get; set; }

		public string STEP { get; set; }

		public string TOSTEP { get; set; }

		public string TOSTEPID { get; set; }

		public DateTime? TOSTEPMOVEINDATE { get; set; }

		public string TOTALCYCLETIME { get; set; }

		public decimal? TOTALQTY { get; set; }

		public decimal? TOTALQTY2 { get; set; }

		public DateTime? TXNDATE { get; set; }

		public string TXNTYPENAME { get; set; }

		public string WORKFLOWID { get; set; }

		public string WORKFLOWSTEPID { get; set; }

	}

}
