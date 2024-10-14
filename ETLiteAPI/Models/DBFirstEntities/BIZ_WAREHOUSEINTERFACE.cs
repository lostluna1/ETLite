using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class BIZ_WAREHOUSEINTERFACE {

		public string BIZ_WAREHOUSEINTERFACEID { get; set; }

		public string BARCODE { get; set; }

		public string BIZ_WAREHOUSEINTERFACENAME { get; set; }

		public uint? CDOTYPEID { get; set; }

		public uint? CHANGECOUNT { get; set; }

		public string CHANGEHISTORYID { get; set; }

		public DateTime? CREATTIME { get; set; }

		public string CUSTOMERPN { get; set; }

		public string CUSTOMERPO { get; set; }

		public string CUSTOMERREV { get; set; }

		public string DESCRIPTION { get; set; }

		public string EMPLOYEE { get; set; }

		public string FACTORY { get; set; }

		public string FILTERTAGS { get; set; }

		public string GROSSWEIGHT { get; set; }

		public uint? ICONID { get; set; }

		public uint? IFTYPE { get; set; }

		public uint? ISFROZEN { get; set; }

		public string LOCATION { get; set; }

		public string LOT { get; set; }

		public string MESSAGE { get; set; }

		public string MFGORDER { get; set; }

		public string NETWEIGHT { get; set; }

		public string NOTES { get; set; }

		public string PRODUCT { get; set; }

		public DateTime? PROTIME { get; set; }

		public string QCSTATUS { get; set; }

		public decimal? QTY { get; set; }

		public string SCRAPCOMMENTS { get; set; }

		public string SCRAPDEPT { get; set; }

		public string SCRAPNO { get; set; }

		public string SCRAPREASON { get; set; }

		public string SETUPACCESSID { get; set; }

		public uint? STATUS { get; set; }

		public string UOM { get; set; }

	}

}
