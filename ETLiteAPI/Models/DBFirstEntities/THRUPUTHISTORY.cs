using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class THRUPUTHISTORY {

		public string THRUPUTHISTORYID { get; set; }

		public uint? CDOTYPEID { get; set; }

		public uint? CHANGECOUNT { get; set; }

		public uint? CHILDCOUNT { get; set; }

		public string CONTAINERID { get; set; }

		public decimal? EQUIPMENTCYCLETIMEMS { get; set; }

		public string EXPORTIMPORTKEY { get; set; }

		public string HISTORYID { get; set; }

		public string HISTORYMAINLINEID { get; set; }

		public string INTEGRATIONTXNID { get; set; }

		public uint? ISFAILED { get; set; }

		public string OPERATIONID { get; set; }

		public string OWNERID { get; set; }

		public string PRODUCTID { get; set; }

		public decimal? QTY { get; set; }

		public decimal? QTY2 { get; set; }

		public string RESOURCEID { get; set; }

		public string RUN { get; set; }

		public string SETUPID { get; set; }

		public uint? THRUPUTALLQTY { get; set; }

		public string TXNID { get; set; }

		public uint? UNITCOUNT { get; set; }

		public string UOM2ID { get; set; }

		public string UOMID { get; set; }

	}

}
