﻿using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class CIOINBOUNDADAPTERFILTERS {

		public string CIOINBOUNDADAPTERFILTERSID { get; set; }

		public uint? CDOTYPEID { get; set; }

		public uint? CHANGECOUNT { get; set; }

		public string CIOCHANNELADAPTERID { get; set; }

		public string CIOFILTERID { get; set; }

		public string EXPORTIMPORTKEY { get; set; }

		public uint? ISFROZEN { get; set; }

		public uint? SEQUENCE { get; set; }

	}

}
