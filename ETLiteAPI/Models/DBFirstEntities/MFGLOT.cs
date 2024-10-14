using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class MFGLOT {

		public string MFGLOTID { get; set; }

		public uint? ALLOWADJUSTTOLOTSIZE { get; set; }

		public uint? CDOTYPEID { get; set; }

		public uint? CHANGECOUNT { get; set; }

		public DateTime? CREATIONDATE { get; set; }

		public uint? LOTSTATUS { get; set; }

		public string MFGLOTNAME { get; set; }

		public string PRODUCTID { get; set; }

		public decimal? QTY { get; set; }

		public uint? SAMPLERATE { get; set; }

		public uint? SAMPLINGCOMPLETED { get; set; }

		public uint? SAMPLINGPASSED { get; set; }

		public string SAMPLINGPLANID { get; set; }

		public string UOMID { get; set; }

	}

}
