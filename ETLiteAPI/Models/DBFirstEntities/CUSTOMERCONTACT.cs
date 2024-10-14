using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class CUSTOMERCONTACT {

		public string CUSTOMERCONTACTID { get; set; }

		public uint? CDOTYPEID { get; set; }

		public string CELLPHONENUMBER { get; set; }

		public uint? CHANGECOUNT { get; set; }

		public string CUSTOMERCONTACTNAME { get; set; }

		public string CUSTOMERID { get; set; }

		public string EMAILADDRESS { get; set; }

		public string EXPORTIMPORTKEY { get; set; }

		public string FAXNUMBER { get; set; }

		public uint? ISFROZEN { get; set; }

		public string PHONENUMBER { get; set; }

		public uint? PRIMARYCONTACT { get; set; }

	}

}
