using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class ISUOMCONVERSION {

		public string ISUOMCONVERSIONID { get; set; }

		public uint? CDOTYPEID { get; set; }

		public uint? CHANGECOUNT { get; set; }

		public string CONVERSIONFACTOR { get; set; }

		public uint? DECIMALPLACES { get; set; }

		public string FROMUOMID { get; set; }

		public uint? ISFROZEN { get; set; }

		public string ISUOMCONVERSIONNAME { get; set; }

		public string PARENTID { get; set; }

		public uint? ROUNDINGRULE { get; set; }

		public string TOUOMID { get; set; }

	}

}
