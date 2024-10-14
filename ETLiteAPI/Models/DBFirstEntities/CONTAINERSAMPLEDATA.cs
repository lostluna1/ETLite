using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class CONTAINERSAMPLEDATA {

		public string CONTAINERSAMPLEDATAID { get; set; }

		public uint? ALLOWEDREJECTS { get; set; }

		public string AQLLEVELID { get; set; }

		public uint? CDOTYPEID { get; set; }

		public uint? CHANGECOUNT { get; set; }

		public uint? COMPLETEDSAMPLES { get; set; }

		public string CONTAINERID { get; set; }

		public string EXPORTIMPORTKEY { get; set; }

		public uint? INSPECTALLCONTQTY { get; set; }

		public uint? INSPECTALLQTYONFAILURE { get; set; }

		public string INSPECTIONLEVELID { get; set; }

		public uint? REJECTS { get; set; }

		public string SAMPLETESTID { get; set; }

		public string SAMPLINGPLANID { get; set; }

		public uint? TOTALSAMPLESREQUIRED { get; set; }

	}

}
