using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class MODELINGESIGHISTORYDETAIL {

		public string MODELINGESIGHISTORYDETAILID { get; set; }

		public uint? CDOTYPEID { get; set; }

		public uint? CHANGECOUNT { get; set; }

		public string COMMENTS { get; set; }

		public string COSIGNERFULLNAME { get; set; }

		public string COSIGNERROLEID { get; set; }

		public string COSIGNREASONID { get; set; }

		public string EXPORTIMPORTKEY { get; set; }

		public uint? ISFROZEN { get; set; }

		public string MEANINGID { get; set; }

		public string PARENTID { get; set; }

		public string SIGNERFULLNAME { get; set; }

		public string SIGNERROLEID { get; set; }

		public uint? VERIFICATIONMETHOD { get; set; }

	}

}
