﻿using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class A_PARTREQUESTORDERPART {

		public string PARTREQUESTORDERPARTID { get; set; }

		public uint? CDOTYPEID { get; set; }

		public uint? CHANGECOUNT { get; set; }

		public string EXPORTIMPORTKEY { get; set; }

		public uint? ISFROZEN { get; set; }

		public string MATERIALPARTID { get; set; }

		public string PARTID { get; set; }

		public string PARTNAME { get; set; }

		public uint? PARTQTY { get; set; }

		public string PARTREQUESTORDERID { get; set; }

	}

}
