using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class SAMPLESIZEDETAILS {

		public string SAMPLESIZEDETAILSID { get; set; }

		public uint? ACCEPTS { get; set; }

		public string AQLLEVELID { get; set; }

		public uint? CDOTYPEID { get; set; }

		public uint? CHANGECOUNT { get; set; }

		public string EXPORTIMPORTKEY { get; set; }

		public uint? ISFROZEN { get; set; }

		public uint? REJECTS { get; set; }

		public string SAMPLESIZE { get; set; }

		public string SAMPLESIZECODE { get; set; }

	}

}
