using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class ES_WORKFLOWMOVES {

		public string CONTAINERID { get; set; }

		public string CONTAINERNAME { get; set; }

		public decimal? ELAPSEDSECONDS { get; set; }

		public string ES_PRIMARYSERIALNUMBER { get; set; }

		public string ES_SERIALNUMBER2 { get; set; }

		public string ES_SERIALNUMBER3 { get; set; }

		public string HISTORYMAINLINEID { get; set; }

		public uint? ISFAILED { get; set; }

		public DateTime? MOVEINDATE { get; set; }

		public string OPERATIONNAME { get; set; }

		public string RESOURCENAME { get; set; }

		public uint? SEQUENCE { get; set; }

		public string SPECNAME { get; set; }

		public string SPECREVISION { get; set; }

		public uint? STATUS { get; set; }

		public DateTime? TXNDATE { get; set; }

		public string TXNTYPENAME { get; set; }

		public string WORKFLOWID { get; set; }

		public string WORKFLOWNAME { get; set; }

		public string WORKFLOWSTEPNAME { get; set; }

	}

}
