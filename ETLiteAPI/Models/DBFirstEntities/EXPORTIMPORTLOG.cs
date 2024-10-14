using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class EXPORTIMPORTLOG {

		public uint EXPORTIMPORTLOGID { get; set; }

		public string COMPLETIONMESSAGE { get; set; }

		public uint? EXPORTIMPORTDETAILID { get; set; }

		public uint? EXPORTIMPORTHEADERID { get; set; }

		public string IMPORTEDOBJECTID { get; set; }

		public DateTime? PROCESSDATE { get; set; }

		public DateTime? PROCESSDATEGMT { get; set; }

		public uint? STATUS { get; set; }

	}

}
