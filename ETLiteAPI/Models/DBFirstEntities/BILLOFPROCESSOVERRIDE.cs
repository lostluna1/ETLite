using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class BILLOFPROCESSOVERRIDE {

		public string BILLOFPROCESSOVERRIDEID { get; set; }

		public string BILLOFPROCESSID { get; set; }

		public string BILLOFPROCESSOVERRIDENAME { get; set; }

		public uint? CDOTYPEID { get; set; }

		public uint? CHANGECOUNT { get; set; }

		public string DOCUMENTSETID { get; set; }

		public string ELECTRONICPROCEDUREBASEID { get; set; }

		public string ELECTRONICPROCEDUREID { get; set; }

		public string ES_TOOLPLANMATRIXID { get; set; }

		public string EXPORTIMPORTKEY { get; set; }

		public uint? ISFROZEN { get; set; }

		public string RECIPEFILEBASEID { get; set; }

		public string RECIPEFILEID { get; set; }

		public string RESOURCEGROUPID { get; set; }

		public string SETUPBASEID { get; set; }

		public string SETUPID { get; set; }

		public string SPECBASEID { get; set; }

		public string SPECID { get; set; }

		public string TRAININGREQGROUPID { get; set; }

	}

}
