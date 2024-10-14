using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class ISMATERIALREQUESTSTATUSDETAILS {

		public string ISMATERIALREQUESTSTATUSDETAIID { get; set; }

		public uint? ACCEPTNOCONTAINER { get; set; }

		public uint? CANCELREQUEST { get; set; }

		public uint? CDOTYPEID { get; set; }

		public uint? CHANGECOUNT { get; set; }

		public string CONTAINERID { get; set; }

		public string EXPORTIMPORTKEY { get; set; }

		public uint? ISFROZEN { get; set; }

		public string ISLOT { get; set; }

		public DateTime? ISMATERIALREQSTATUSDATE { get; set; }

		public DateTime? ISMATERIALREQSTATUSDATEGMT { get; set; }

		public uint? ISMATERIALREQUESTSTATEID { get; set; }

		public string ISMATERIALREQUESTSTATUSID { get; set; }

		public string ISMFGORDERID { get; set; }

		public string ISUOMID { get; set; }

		public string PRODUCTID { get; set; }

		public decimal? QTYREQUESTED { get; set; }

		public decimal? RECEIVEDQTY { get; set; }

		public decimal? REMAININGQTY { get; set; }

	}

}
