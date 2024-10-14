using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class RESOURCESTATUSCODE {

		public string RESOURCESTATUSCODEID { get; set; }

		public uint? AVAILABILITY { get; set; }

		public uint? CDOTYPEID { get; set; }

		public uint? CHANGECOUNT { get; set; }

		public string CHANGEHISTORYID { get; set; }

		public string DESCRIPTION { get; set; }

		public string FILTERTAGS { get; set; }

		public uint? ICONID { get; set; }

		public uint? ISFROZEN { get; set; }

		public uint? ISOEELOSSCATEGORY { get; set; }

		public uint? ISORDER { get; set; }

		public uint? NEXTTXNTYPE { get; set; }

		public string NOTES { get; set; }

		public string OMLSTATUS { get; set; }

		public string RESOURCECDOTYPENAME { get; set; }

		public uint? RESOURCESTATE { get; set; }

		public string RESOURCESTATUSCODENAME { get; set; }

		public string RESOURCESTATUSREASONSID { get; set; }

		public string SETUPACCESSID { get; set; }

		public uint? STATUSCODEBEHAVIOR { get; set; }

		public uint? STATUSID { get; set; }

	}

}
