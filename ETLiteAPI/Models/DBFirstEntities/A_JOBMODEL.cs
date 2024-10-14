using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class A_JOBMODEL {

		public string JOBMODELID { get; set; }

		public uint? CDOTYPEID { get; set; }

		public uint? CHANGECOUNT { get; set; }

		public string CHANGEHISTORYID { get; set; }

		public string DESCRIPTION { get; set; }

		public string DOCUMENTSETID { get; set; }

		public string FILTERTAGS { get; set; }

		public uint? ICONID { get; set; }

		public uint? ISFROZEN { get; set; }

		public uint? ISSIMPLEMODE { get; set; }

		public string JOBMODELNAME { get; set; }

		public uint? JOBTYPE { get; set; }

		public string NOTES { get; set; }

		public string SETUPACCESSID { get; set; }

	}

}
