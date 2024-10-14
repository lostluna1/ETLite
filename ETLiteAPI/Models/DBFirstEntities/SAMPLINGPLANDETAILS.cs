using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class SAMPLINGPLANDETAILS {

		public string SAMPLINGPLANDETAILSID { get; set; }

		public string AQLLEVELID { get; set; }

		public uint? CDOTYPEID { get; set; }

		public uint? CHANGECOUNT { get; set; }

		public string EXPORTIMPORTKEY { get; set; }

		public uint? INSPECTALL { get; set; }

		public uint? INSPECTALLCONTQTY { get; set; }

		public uint? INSPECTALLQTYONFAILURE { get; set; }

		public string INSPECTIONLEVELID { get; set; }

		public uint? ISFROZEN { get; set; }

		public string RESOURCEID { get; set; }

		public uint? SAMPLERATE { get; set; }

		public string SAMPLETESTBASEID { get; set; }

		public string SAMPLETESTID { get; set; }

		public string SAMPLINGPLANID { get; set; }

		public uint? SEQUENCE { get; set; }

		public string SPECBASEID { get; set; }

		public string SPECID { get; set; }

		public string SWITCHINGRULEBASEID { get; set; }

		public string SWITCHINGRULEID { get; set; }

		public string VENDORID { get; set; }

		public string VENDORITEMID { get; set; }

	}

}
