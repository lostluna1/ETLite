using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class SECURITYMASKDETAIL {

		public uint SECURITYMASKDETAILID { get; set; }

		public uint? BITNUMBER { get; set; }

		public string DESCRIPTION { get; set; }

		public uint? DISPLAYTEXTLABELID { get; set; }

		public uint? SECURITYMASKID { get; set; }

	}

}
