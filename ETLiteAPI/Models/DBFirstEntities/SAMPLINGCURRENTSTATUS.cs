using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class SAMPLINGCURRENTSTATUS {

		public string SAMPLINGCURRENTSTATUSID { get; set; }

		public string AQLLEVELID { get; set; }

		public uint? CDOTYPEID { get; set; }

		public uint? CHANGECOUNT { get; set; }

		public string CURRENTINSPECTIONLEVELID { get; set; }

		public uint? CURRENTSAMPLERATE { get; set; }

		public string LASTREVTXNID { get; set; }

		public DateTime? LASTUPDATEDATE { get; set; }

		public string PRODUCTID { get; set; }

		public string RESOURCEID { get; set; }

		public string SAMPLEPLANINSPECTIONLEVELID { get; set; }

		public uint? SAMPLERATECOUNTER { get; set; }

		public string SAMPLETESTID { get; set; }

		public string SAMPLINGLOTID { get; set; }

		public string SAMPLINGPLANID { get; set; }

		public string SPECID { get; set; }

		public string VENDORID { get; set; }

		public string VENDORITEMID { get; set; }

	}

}
