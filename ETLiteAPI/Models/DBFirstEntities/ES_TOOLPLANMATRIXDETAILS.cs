using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class ES_TOOLPLANMATRIXDETAILS {

		public string ES_TOOLPLANMATRIXDETAILSID { get; set; }

		public uint? CDOTYPEID { get; set; }

		public uint? CHANGECOUNT { get; set; }

		public string ES_TOOLPLANMATRIXDETAILSNAME { get; set; }

		public string ES_TOOLPLANMATRIXID { get; set; }

		public uint? ISFROZEN { get; set; }

		public string RESOURCEID { get; set; }

		public string SPECBASEID { get; set; }

		public string SPECID { get; set; }

		public string TOOLPLANID { get; set; }

	}

}
