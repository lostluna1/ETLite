using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class BIZ_LINEEQUIMENTRESOURCE {

		public string BIZ_LINEEQUIMENTRESOURCEID { get; set; }

		public string BIZ_LINEEQUIMENTRESOURCENAME { get; set; }

		public string BIZ_SMTMACHINECODEID { get; set; }

		public uint? CDOTYPEID { get; set; }

		public uint? CHANGECOUNT { get; set; }

		public string CHANGEHISTORYID { get; set; }

		public string DESCRIPTION { get; set; }

		public string FILTERTAGS { get; set; }

		public uint? ICONID { get; set; }

		public uint? ISFROZEN { get; set; }

		public string MFGLINEID { get; set; }

		public string NOTES { get; set; }

		public string RESOURCEID { get; set; }

		public string SETUPACCESSID { get; set; }

	}

}
