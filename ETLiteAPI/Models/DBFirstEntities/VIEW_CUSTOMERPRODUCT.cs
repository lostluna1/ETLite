using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class VIEW_CUSTOMERPRODUCT {

		public string BIZ_CUSTOMERPRODUCTID { get; set; }

		public string BIZ_CUSTOMERPRODUCTNAME { get; set; }

		public uint? CDOTYPEID { get; set; }

		public uint? CHANGECOUNT { get; set; }

		public string CHANGEHISTORYID { get; set; }

		public string CUSTOMERID { get; set; }

		public string CUSTOMERPRODUCT { get; set; }

		public string DESCRIPTION { get; set; }

		public string DISPATCHCHANNEL { get; set; }

		public string FACTORYID { get; set; }

		public string FILTERTAGS { get; set; }

		public uint? ICONID { get; set; }

		public uint? ISFROZEN { get; set; }

		public string NOTES { get; set; }

		public string PRODUCTID { get; set; }

		public string SETUPACCESSID { get; set; }

		public string STATUS { get; set; }

		public string TERMINALCUSTOMER { get; set; }

		public string TERMINALCUSTOMERDESCRIPTION { get; set; }

		public string TERMINALCUSTOMERPRODUCT { get; set; }

		public string TERMINALCUSTOMERPRODUCTREV { get; set; }

		public string TRADEROUTES { get; set; }

	}

}
