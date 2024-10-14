using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class PERSISTENCESTORE {

		public string CONTENTID { get; set; }

		public string CONTENTTEXT { get; set; }

		public uint? PARTLENGTH { get; set; }

		public uint? PARTSEQUENCE { get; set; }

		public DateTime? SAVINGTIME { get; set; }

		public string WORKFLOWID { get; set; }

	}

}
