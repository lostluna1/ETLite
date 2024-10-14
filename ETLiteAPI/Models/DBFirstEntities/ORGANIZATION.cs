using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class ORGANIZATION {

		public string ORGANIZATIONID { get; set; }

		public uint? CDOTYPEID { get; set; }

		public uint? CHANGECOUNT { get; set; }

		public string CHANGEHISTORYID { get; set; }

		public uint? COLLECTESIGFORALLQUALITYTXNS { get; set; }

		public string DESCRIPTION { get; set; }

		public string FILTERTAGS { get; set; }

		public uint? ICONID { get; set; }

		public uint? ISFROZEN { get; set; }

		public string NOTES { get; set; }

		public string ORGANIZATIONNAME { get; set; }

		public string ORGANIZATIONNUMBER { get; set; }

		public string PARENTORGANIZATIONID { get; set; }

		public string PORTALHOMEPAGEID { get; set; }

		public string PORTALMOBILEHOMEPAGEID { get; set; }

		public string PORTALV8HOMEPAGEID { get; set; }

		public string PRINTQUEUEID { get; set; }

		public string SETUPACCESSID { get; set; }

		public string SMTPTRANSPORTID { get; set; }

		public uint? USERREQUIREDFORESIG { get; set; }

	}

}
