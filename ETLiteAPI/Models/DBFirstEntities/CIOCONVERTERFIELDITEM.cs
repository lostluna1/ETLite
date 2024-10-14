using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class CIOCONVERTERFIELDITEM {

		public string CIOCONVERTERFIELDITEMID { get; set; }

		public uint? CDOTYPEID { get; set; }

		public uint? CHANGECOUNT { get; set; }

		public string CIOCONVERTERFIELDITEMNAME { get; set; }

		public string CIOSUBSCRIPTRESCNVTRITEMID { get; set; }

		public string DATAPOINT { get; set; }

		public string DATAPOINTFORMAT { get; set; }

		public string DATATYPE { get; set; }

		public string EXPORTIMPORTKEY { get; set; }

		public uint? ISFROZEN { get; set; }

		public uint? ISREVOFRCD { get; set; }

		public string REVISION { get; set; }

		public string REVISIONFORMAT { get; set; }

		public uint? SIZEOFLISTVALUE { get; set; }

	}

}
