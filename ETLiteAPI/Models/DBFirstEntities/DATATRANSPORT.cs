using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class DATATRANSPORT {

		public string DATATRANSPORTID { get; set; }

		public uint? BYTEORDERMARK { get; set; }

		public uint? CDOTYPEID { get; set; }

		public uint? CHANGECOUNT { get; set; }

		public string CHANGEHISTORYID { get; set; }

		public string CONNECTIONDOCINIT { get; set; }

		public uint? CONNECTIONTIMEOUT { get; set; }

		public string DATATRANSPORTNAME { get; set; }

		public uint? DELIVERYTIMEOUT { get; set; }

		public string DESCRIPTION { get; set; }

		public string FILTERTAGS { get; set; }

		public uint? ICONID { get; set; }

		public uint? ISFROZEN { get; set; }

		public uint? ISSYNCHRONOUS { get; set; }

		public string LABELFORMAT { get; set; }

		public string NOTES { get; set; }

		public uint? OKTOTERMINATEIFFAILS { get; set; }

		public string PASSWORD { get; set; }

		public uint? PORT { get; set; }

		public string PRIORITY { get; set; }

		public string REMOTEFILENAME { get; set; }

		public string REMOTEPATH { get; set; }

		public string SETUPACCESSID { get; set; }

		public string TRANSFERTYPE { get; set; }

		public string TRANSPORTASSEMBLY { get; set; }

		public string TRANSPORTTYPE { get; set; }

		public string URL { get; set; }

		public string USERNAME { get; set; }

		public uint? USESSL { get; set; }

	}

}
