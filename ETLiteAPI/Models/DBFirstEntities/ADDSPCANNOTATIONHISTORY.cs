using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class ADDSPCANNOTATIONHISTORY {

		public string ADDSPCANNOTATIONHISTORYID { get; set; }

		public string ANNOTATION { get; set; }

		public uint? CDOTYPEID { get; set; }

		public uint? CHANGECOUNT { get; set; }

		public string CUSTOMSPCDATAID { get; set; }

		public string DATACOLLECTIONDEFID { get; set; }

		public string DATACOLLECTIONNAME { get; set; }

		public string DATAPOINTID { get; set; }

		public string DATAPOINTNAME { get; set; }

		public uint? EXCLUDE { get; set; }

		public string EXPORTIMPORTKEY { get; set; }

		public string HISTORYID { get; set; }

		public string HISTORYMAINLINEID { get; set; }

		public string TXNID { get; set; }

	}

}
