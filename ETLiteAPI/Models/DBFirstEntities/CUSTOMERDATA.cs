using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class CUSTOMERDATA {

		public string CUSTOMERDATAID { get; set; }

		public uint? CDOTYPEID { get; set; }

		public uint? CHANGECOUNT { get; set; }

		public string CONTACTCELLPHONE { get; set; }

		public string CONTACTEMAIL { get; set; }

		public string CONTACTFAXNUMBER { get; set; }

		public string CONTACTFULLNAME { get; set; }

		public string CONTACTPHONENUMBER { get; set; }

		public string CUSTOMERADDRESSLINE1 { get; set; }

		public string CUSTOMERADDRESSLINE2 { get; set; }

		public string CUSTOMERCITY { get; set; }

		public string CUSTOMERCOUNTRY { get; set; }

		public string CUSTOMERFAXNUMBER { get; set; }

		public string CUSTOMERNAME { get; set; }

		public string CUSTOMERPHONENUMBER { get; set; }

		public string CUSTOMERPOSTALCODE { get; set; }

		public string CUSTOMERSTATE { get; set; }

		public string CUSTOMERWEBSITE { get; set; }

		public string EVENTDATAID { get; set; }

		public string EXPORTIMPORTKEY { get; set; }

	}

}
