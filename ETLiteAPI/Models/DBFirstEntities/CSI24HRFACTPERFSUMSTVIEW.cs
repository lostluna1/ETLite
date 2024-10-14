using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class CSI24HRFACTPERFSUMSTVIEW {

		public string CALENDARSHIFTID { get; set; }

		public string CDONAME { get; set; }

		public string CONTAINERNAME { get; set; }

		public string FACTORYID { get; set; }

		public string FROMSTEP { get; set; }

		public string FROMSTEPID { get; set; }

		public decimal? FROMSTEPSEQUENCE { get; set; }

		public string HISTORYID { get; set; }

		public string HISTORYMAINLINEID { get; set; }

		public uint? ISLASTSTEP { get; set; }

		public DateTime? LASTREFRESHDATE { get; set; }

		public string MFGORDERID { get; set; }

		public decimal? MOVECYCLETIME { get; set; }

		public string OWNERID { get; set; }

		public string PRODUCTID { get; set; }

		public string PRODUCTNAME { get; set; }

		public string PRODUCTREVISION { get; set; }

		public decimal? QTY { get; set; }

		public string REASONCODEID { get; set; }

		public string SHIFTNAME { get; set; }

		public string STEPID { get; set; }

		public uint? STEPPASS { get; set; }

		public uint? STEPSEQUENCE { get; set; }

		public decimal? TARGETCYCLETIME { get; set; }

		public decimal? TARGETUNITSPERHOUR { get; set; }

		public decimal? TARGETYIELD { get; set; }

		public string TORESOURCEID { get; set; }

		public DateTime? TXNDATE { get; set; }

		public string WORKFLOWID { get; set; }

		public string WORKFLOWSTEPNAME { get; set; }

	}

}
