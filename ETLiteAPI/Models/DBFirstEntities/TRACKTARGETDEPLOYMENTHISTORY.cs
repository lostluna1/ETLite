﻿using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class TRACKTARGETDEPLOYMENTHISTORY {

		public string TRACKTARGETDEPLOYMENTHISTORYID { get; set; }

		public uint? CDOTYPEID { get; set; }

		public uint? CHANGECOUNT { get; set; }

		public uint? EXPORTHEADERID { get; set; }

		public string EXPORTIMPORTKEY { get; set; }

		public uint? EXPORTTARGETID { get; set; }

		public string HISTORYID { get; set; }

		public string HISTORYMAINLINEID { get; set; }

		public DateTime? LASTUPDATEDDATE { get; set; }

		public DateTime? LASTUPDATEDDATEGMT { get; set; }

		public string MESSAGE { get; set; }

		public string OWNER { get; set; }

		public uint? STATUS { get; set; }

		public string TXNID { get; set; }

	}

}
