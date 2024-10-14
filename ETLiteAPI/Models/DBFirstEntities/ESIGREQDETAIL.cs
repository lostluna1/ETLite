using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class ESIGREQDETAIL {

		public string ESIGREQDETAILID { get; set; }

		public uint? CDOTYPEID { get; set; }

		public uint? CHANGECOUNT { get; set; }

		public string COSIGNERROLEID { get; set; }

		public string ESIGMEANINGID { get; set; }

		public string ESIGREQDETAILNAME { get; set; }

		public string ESIGREQUIREMENTID { get; set; }

		public string ESIGROLEID { get; set; }

		public string EXPORTIMPORTKEY { get; set; }

		public uint? ISFROZEN { get; set; }

		public uint? SIGNATURECOUNT { get; set; }

		public uint? VERIFICATIONMETHOD { get; set; }

	}

}
