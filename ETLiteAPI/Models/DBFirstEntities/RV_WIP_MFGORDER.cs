using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class RV_WIP_MFGORDER {

		public string AVGPROCESSTIME { get; set; }

		public decimal? FAILCOUNT { get; set; }

		public decimal? INPROCESSCOUNT { get; set; }

		public decimal? INQUEUECOUNT { get; set; }

		public decimal? ISOPTIONAL { get; set; }

		public string MFGORDERID { get; set; }

		public string MFGORDERNAME { get; set; }

		public decimal? ORDERQTY { get; set; }

		public decimal? PANELIZED { get; set; }

		public decimal? PCBCOUNT { get; set; }

		public decimal? PROCESSEDCOUNT { get; set; }

		public string PROCESSTIME { get; set; }

		public string PRODUCTDISPLAY { get; set; }

		public decimal? QTY { get; set; }

		public decimal? QTYSTARTED { get; set; }

		public decimal? SEQUENCE { get; set; }

		public decimal? STARTEDQTY { get; set; }

		public string STEPDISPLAYNAME { get; set; }

		public string WORKFLOWID { get; set; }

		public string WORKFLOWNAME { get; set; }

		public string WORKFLOWSTEPNAME { get; set; }

		public decimal? XOUTCOUNT { get; set; }

	}

}
