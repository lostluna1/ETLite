using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class CSIYIELDSTVIEW {

		public string CDONAME { get; set; }

		public string CONTAINERNAME { get; set; }

		public string EMPLOYEENAME { get; set; }

		public string HISTORYID { get; set; }

		public string HISTORYMAINLINEID { get; set; }

		public string OPERATIONNAME { get; set; }

		public string PRODUCTID { get; set; }

		public string PRODUCTNAME { get; set; }

		public string PRODUCTREVISION { get; set; }

		public decimal? QTY { get; set; }

		public uint? SEQUENCE { get; set; }

		public DateTime? TXNDATE { get; set; }

		public string TXNID { get; set; }

		public string WORKFLOWSTEPNAME { get; set; }

	}

}
