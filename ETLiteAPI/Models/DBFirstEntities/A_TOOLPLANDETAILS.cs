using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class A_TOOLPLANDETAILS {

		public string TOOLPLANDETAILSID { get; set; }

		public uint? CDOTYPEID { get; set; }

		public uint? CHANGECOUNT { get; set; }

		public string EXPORTIMPORTKEY { get; set; }

		public uint? ISFROZEN { get; set; }

		public string ITEMNAME { get; set; }

		public uint? MAXREQUIRED { get; set; }

		public uint? MINREQUIRED { get; set; }

		public string TOOLFAMILYID { get; set; }

		public string TOOLGROUPID { get; set; }

		public string TOOLID { get; set; }

		public string TOOLPLANID { get; set; }

		public uint? TOOLSEQUENCE { get; set; }

	}

}
