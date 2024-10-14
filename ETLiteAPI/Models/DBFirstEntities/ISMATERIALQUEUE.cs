using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class ISMATERIALQUEUE {

		public string ISMATERIALQUEUEID { get; set; }

		public uint? CDOTYPEID { get; set; }

		public uint? CHANGECOUNT { get; set; }

		public string CHANGEHISTORYID { get; set; }

		public string DESCRIPTION { get; set; }

		public string FILTERTAGS { get; set; }

		public uint? ICONID { get; set; }

		public uint? ISACTIVE { get; set; }

		public string ISCONTAINEROBJECTID { get; set; }

		public uint? ISFROZEN { get; set; }

		public uint? ISISKIT { get; set; }

		public string ISMATERIALQUEUENAME { get; set; }

		public string ISMFGORDERID { get; set; }

		public string ISOPERATIONID { get; set; }

		public string ISRESOURCEID { get; set; }

		public uint? ISVALIDATEQUEUE { get; set; }

		public string NOTES { get; set; }

		public string SETUPACCESS { get; set; }

	}

}
