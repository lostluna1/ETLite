using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class CUSTOMER {

		public string CUSTOMERID { get; set; }

		public string ADDRESSLINE1 { get; set; }

		public string ADDRESSLINE2 { get; set; }

		public uint? CDOTYPEID { get; set; }

		public uint? CHANGECOUNT { get; set; }

		public string CHANGEHISTORYID { get; set; }

		public string CITY { get; set; }

		public string COMPANY { get; set; }

		public string COUNTRY { get; set; }

		public string CUSTOMERNAME { get; set; }

		public string DESCRIPTION { get; set; }

		public string FAXNUMBER { get; set; }

		public string FILTERTAGS { get; set; }

		public uint? ICONID { get; set; }

		public uint? ISFROZEN { get; set; }

		public string NOTES { get; set; }

		public string PHONENUMBER { get; set; }

		public string SETUPACCESSID { get; set; }

		public string STATE { get; set; }

		public string WEBSITE { get; set; }

		public string WIPMSGDEFMGRID { get; set; }

		public string ZIPCODE { get; set; }

	}

}
