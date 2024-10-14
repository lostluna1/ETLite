using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class SPCCHARTHISTORYDETAIL {

		public string RECORDSPCCHARTVIOLATIONHISTDID { get; set; }

		public uint? CDOTYPEID { get; set; }

		public uint? CHANGECOUNT { get; set; }

		public string EXPORTIMPORTKEY { get; set; }

		public string FILEDIRECTORY { get; set; }

		public string FILENAME { get; set; }

		public string RECORDSPCVIOLATIONSUMMARYID { get; set; }

		public string SPCCHARTDEFID { get; set; }

		public string SPCCHARTDEFNAME { get; set; }

		public string TXNID { get; set; }

	}

}
