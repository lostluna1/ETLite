using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class RESOURCEGROUP {

		public string RESOURCEGROUPID { get; set; }

		public uint? CDOTYPEID { get; set; }

		public uint? CHANGECOUNT { get; set; }

		public string CHANGEHISTORYID { get; set; }

		public string DESCRIPTION { get; set; }

		public string ENTRYTYPE { get; set; }

		public string FILTERTAGS { get; set; }

		public uint? ICONID { get; set; }

		public uint? ISFROZEN { get; set; }

		public uint? ISSMTRESOURCES { get; set; }

		public string NOTES { get; set; }

		public string OBJECTCATEGORY { get; set; }

		public string OBJECTTYPE { get; set; }

		public string RESOURCEGROUPNAME { get; set; }

		public string SETUPACCESSID { get; set; }

	}

}
