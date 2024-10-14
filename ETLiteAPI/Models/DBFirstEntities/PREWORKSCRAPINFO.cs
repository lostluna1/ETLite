using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class PREWORKSCRAPINFO {

		public string AB_SCRAP_RATE { get; set; }

		public string ABCONFIRMSCRAPQTY { get; set; }

		public string BUNAME { get; set; }

		public string CLASSNAME { get; set; }

		public string COMMENTS { get; set; }

		public string CONFIRMSCRAPQTY { get; set; }

		public string CONTAINERNAME { get; set; }

		public string DEFECTNAME { get; set; }

		public string DEPTNAME { get; set; }

		public string DESCRIPTIONS { get; set; }

		public string EMPLOYEE { get; set; }

		public string HIV2_ITEM_CODE { get; set; }

		public string HIV3_ITEM_CODE { get; set; }

		public string HU_USER_NAME { get; set; }

		public string MANUFACTURING_CLASS { get; set; }

		public string MFGLINENAME { get; set; }

		public string MFGORDER { get; set; }

		public string ORDERSTATUSNAME { get; set; }

		public string PREWORKSCAPNAME { get; set; }

		public string PRODUCTNAME { get; set; }

		public string QTY { get; set; }

		public decimal? REQUIREMENT_QTY { get; set; }

		public decimal? SCRAPQTY { get; set; }

		public decimal? SCRAPRATE { get; set; }

		public string SCRAPREASON { get; set; }

		public string SCRAPSTATUS { get; set; }

		public DateTime? SCRAPTIME { get; set; }

		public string SCRAPTYPE { get; set; }

		public string SENTALREADYQTY { get; set; }

		public string SENTSHOUDLEQTY { get; set; }

		public string SPEC { get; set; }

		public decimal? SUMSCRAPQTY { get; set; }

		public string UOM { get; set; }

		public decimal? WO_QTY { get; set; }

	}

}
