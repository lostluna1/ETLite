using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class ISMATERIALREQUESTSTATUS {

		public string ISMATERIALREQUESTSTATUSID { get; set; }

		public uint? CDOTYPEID { get; set; }

		public uint? CHANGECOUNT { get; set; }

		public string CHANGEHISTORYID { get; set; }

		public string DESCRIPTION { get; set; }

		public string FILTERTAGS { get; set; }

		public uint? ICONID { get; set; }

		public uint? ISFROZEN { get; set; }

		public string ISINVENTORYLOCATIONID { get; set; }

		public string ISMATERIALQUEUEID { get; set; }

		public string ISMATERIALREQUESTSTATUSNAME { get; set; }

		public string ISMFGORDERID { get; set; }

		public string NOTES { get; set; }

		public string OPERATIONID { get; set; }

		public DateTime? REQUESTDATE { get; set; }

		public DateTime? REQUESTDATEGMT { get; set; }

		public string REQUESTTYPE { get; set; }

		public string RESOURCEID { get; set; }

		public string SETUPACCESSID { get; set; }

	}

}
