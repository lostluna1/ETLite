using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class CIODETAILSECTION {

		public string CIODETAILSECTIONID { get; set; }

		public uint? CDOTYPEID { get; set; }

		public uint? CHANGECOUNT { get; set; }

		public string CIODETAILSECTIONNAME { get; set; }

		public string CIOFLATFILEADAPTERID { get; set; }

		public string DESCRIPTION { get; set; }

		public string ELEMENTNAME { get; set; }

		public string EXPORTIMPORTKEY { get; set; }

		public uint? ISFROZEN { get; set; }

		public uint? STARTLINE { get; set; }

	}

}
