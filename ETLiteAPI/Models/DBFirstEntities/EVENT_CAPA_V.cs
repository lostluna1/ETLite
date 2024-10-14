using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class EVENT_CAPA_V {

		public uint? CATEGORY { get; set; }

		public string CATEGORYNAME { get; set; }

		public string CDONAME { get; set; }

		public string CLASSIFICATIONID { get; set; }

		public string CLASSIFICATIONNAME { get; set; }

		public string DISCOVERYAREA { get; set; }

		public string INCLUDEALLROLES { get; set; }

		public string INITIATORID { get; set; }

		public string INITIATORNAME { get; set; }

		public string INITIATORORGID { get; set; }

		public string INITIATORORGNAME { get; set; }

		public decimal? ISCARREQUIREDTOCLOSE { get; set; }

		public string LOGINID { get; set; }

		public string OBJECTID { get; set; }

		public string OBJECTNAME { get; set; }

		public string OWNERID { get; set; }

		public string OWNERNAME { get; set; }

		public string OWNERORGID { get; set; }

		public string OWNERORGNAME { get; set; }

		public string PRIORITYLEVELID { get; set; }

		public string PRIORITYLEVELNAME { get; set; }

		public DateTime? REPORTEDDATE { get; set; }

		public DateTime? REPORTEDDATEGMT { get; set; }

		public string REPORTERID { get; set; }

		public string REPORTERNAME { get; set; }

		public string REPORTERORGID { get; set; }

		public string REPORTERORGNAME { get; set; }

		public string ROLEID { get; set; }

		public string ROLENAME { get; set; }

		public uint? STATUS { get; set; }

		public string STATUSNAME { get; set; }

		public string SUBCLASSIFICATIONID { get; set; }

		public string SUBCLASSIFICATIONNAME { get; set; }

		public uint? TRIAGECOMPLETE { get; set; }

	}

}
