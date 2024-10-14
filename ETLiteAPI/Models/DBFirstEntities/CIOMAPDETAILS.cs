using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class CIOMAPDETAILS {

		public string CIOMAPDETAILSID { get; set; }

		public uint? CDOTYPEID { get; set; }

		public uint? CHANGECOUNT { get; set; }

		public string CIOMAPDETAILSNAME { get; set; }

		public string CIOMESSAGEMAPID { get; set; }

		public string CONDITIONAL { get; set; }

		public uint? DISABLED { get; set; }

		public string EXPORTIMPORTKEY { get; set; }

		public uint? ISFROZEN { get; set; }

		public string MAPDETAILDESCRIPTION { get; set; }

		public string NAMESPACE { get; set; }

		public uint? SEQUENCE { get; set; }

		public string SOURCEEXPRESSION { get; set; }

		public string SOURCEPARENTEXPRESSION { get; set; }

		public string TARGETEXPRESSION { get; set; }

		public string TARGETFIELDNAME { get; set; }

		public string TARGETFIELDTYPE { get; set; }

		public string TARGETVALUE { get; set; }

		public uint? USECDATA { get; set; }

	}

}
