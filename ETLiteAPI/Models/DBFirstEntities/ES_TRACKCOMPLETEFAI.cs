using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class ES_TRACKCOMPLETEFAI {

		public string ES_TRACKCOMPLETEFAIID { get; set; }

		public uint? CDOTYPEID { get; set; }

		public uint? CHANGECOUNT { get; set; }

		public DateTime? COMPLETEFAIDATETIME { get; set; }

		public uint? COMPONENTINSPECTED { get; set; }

		public string CONTAINERID { get; set; }

		public string EMPLOYEEID { get; set; }

		public uint? ES_FAITRACKINGMODE { get; set; }

		public string EXPORTIMPORTKEY { get; set; }

		public uint? ISFROZEN { get; set; }

		public string MFGORDERID { get; set; }

		public string PRODUCTID { get; set; }

		public string SPECID { get; set; }

		public DateTime? STARTFAIDATETIME { get; set; }

	}

}
