using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class LOTSIZEDETAILS {

		public string LOTSIZEDETAILSID { get; set; }

		public uint? CDOTYPEID { get; set; }

		public uint? CHANGECOUNT { get; set; }

		public string EXPORTIMPORTKEY { get; set; }

		public string INSPECTIONLEVELID { get; set; }

		public uint? ISFROZEN { get; set; }

		public uint? MAXLOTQTY { get; set; }

		public uint? MINLOTQTY { get; set; }

		public string SAMPLESIZECODE { get; set; }

	}

}
