using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class RP_QTYEFFICIENCYDATA {

		public decimal? ACHIEVEMENT { get; set; }

		public decimal? ACTUALOUTPUT { get; set; }

		public string BREAKTIME { get; set; }

		public string CUSTOMERNAME { get; set; }

		public decimal? EFFICIENCY { get; set; }

		public string ETUBOMNAME { get; set; }

		public string FACTORYNAME { get; set; }

		public decimal? HOURSINVESTED { get; set; }

		public string ISDEFECTREASONNAME { get; set; }

		public string MANPOWER { get; set; }

		public string MFGLINENAME { get; set; }

		public string MFGORDERNAME { get; set; }

		public uint? NG_QTY { get; set; }

		public DateTime? NOWDATE { get; set; }

		public string PBDESC { get; set; }

		public DateTime? PLANNEDCOMPLETIONDATE { get; set; }

		public DateTime? PLANNEDSTARTDATE { get; set; }

		public decimal? PLANOUTPUT { get; set; }

		public string PRODUCTNAME { get; set; }

		public decimal? RETURNQTY { get; set; }

		public decimal? SHIFT_QTY { get; set; }

		public DateTime? SHIFT_TIME_END { get; set; }

		public DateTime? SHIFT_TIME_START { get; set; }

		public string SHIFTNAME { get; set; }

		public decimal? STA_TIME { get; set; }

		public decimal? TEST_QTY { get; set; }

		public decimal? TOTQTY { get; set; }

		public string UOMNAME { get; set; }

		public decimal? WOQTY { get; set; }

		public decimal? YIELD { get; set; }

	}

}
