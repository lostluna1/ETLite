﻿using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class UIPERSONALIZATION {

		public string UIPERSONALIZATIONID { get; set; }

		public uint? CDOTYPEID { get; set; }

		public uint? CHANGECOUNT { get; set; }

		public string CHANGEHISTORYID { get; set; }

		public string CONTENT { get; set; }

		public string EXPORTIMPORTKEY { get; set; }

		public uint? ISFROZEN { get; set; }

		public string OWNERID { get; set; }

		public string UIVIRTUALPAGEID { get; set; }

		public uint? WORKSPACEID { get; set; }

	}

}
