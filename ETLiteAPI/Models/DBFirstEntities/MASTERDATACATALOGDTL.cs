using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class MASTERDATACATALOGDTL {

		public string MASTERDATACATALOGDTLID { get; set; }

		public uint? ANYWORKFLOWCONTROLLED { get; set; }

		public uint? APPROVALWORKFLOWCONTROLLED { get; set; }

		public string CDODISPLAYNAME { get; set; }

		public uint? CDOTYPEID { get; set; }

		public uint? CHANGECOUNT { get; set; }

		public string COMMENTS { get; set; }

		public uint? DISPLAYNAMELABELID { get; set; }

		public string EXPORTIMPORTKEY { get; set; }

		public uint? ISFROZEN { get; set; }

		public uint? MAINTENANCETYPEID { get; set; }

		public string MASTERDATACATALOGDTLNAME { get; set; }

		public string MASTERDATACATALOGID { get; set; }

	}

}
