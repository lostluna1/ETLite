using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class DISPOSITIONDATA {

		public string DISPOSITIONDATAID { get; set; }

		public uint? CDOTYPEID { get; set; }

		public uint? CHANGECOUNT { get; set; }

		public string EVENTLOTID { get; set; }

		public string EXPORTIMPORTKEY { get; set; }

		public uint? ISFROZEN { get; set; }

		public string PARENTID { get; set; }

		public decimal? QUANTITYASSIGNED { get; set; }

		public decimal? QUANTITYCONFORMING { get; set; }

		public decimal? QUANTITYDISPOSITIONED { get; set; }

	}

}
