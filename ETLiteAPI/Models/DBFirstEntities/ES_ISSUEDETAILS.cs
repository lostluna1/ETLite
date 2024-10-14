using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class ES_ISSUEDETAILS {

		public decimal? ACTUALQTYISSUED { get; set; }

		public string ES_FROMLOT2 { get; set; }

		public string ES_FROMLOT3 { get; set; }

		public uint? ES_MOUNTINGTECHNOLOGY { get; set; }

		public string FROMBATCHID { get; set; }

		public string FROMBATCHNAME { get; set; }

		public string FROMCONTAINERID { get; set; }

		public string FROMCONTAINERNAME { get; set; }

		public string FROMLOT { get; set; }

		public string FROMPRIMARYSERIALNUMBER { get; set; }

		public string FROMSTOCKPOINT { get; set; }

		public string IDENTIFIER { get; set; }

		public string ISSUEACTUALSHISTORYID { get; set; }

		public uint? ISSUECONTROL { get; set; }

		public string ISSUEHISTORYDETAILID { get; set; }

		public string PRODUCTID { get; set; }

		public string PRODUCTMATERIALLISTITEMID { get; set; }

		public string PRODUCTNAME { get; set; }

		public string PRODUCTREVISION { get; set; }

		public decimal? QTY { get; set; }

		public decimal? QTYREQUIRED { get; set; }

		public string REFERENCEDESIGNATOR { get; set; }

	}

}
