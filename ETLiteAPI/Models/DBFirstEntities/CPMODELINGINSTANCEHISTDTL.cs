using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class CPMODELINGINSTANCEHISTDTL {

		public string CPMODELINGINSTANCEHISTDTLID { get; set; }

		public DateTime? ADDEDTOPACKAGEGMT { get; set; }

		public uint? CDOTYPEID { get; set; }

		public uint? CHANGECOUNT { get; set; }

		public string EXPORTIMPORTKEY { get; set; }

		public string HISTORYDETAILSID { get; set; }

		public string HISTORYID { get; set; }

		public uint? ISREFERENCE { get; set; }

		public uint? ISROR { get; set; }

		public string OBJECTINSTANCEID { get; set; }

		public string OBJECTNAME { get; set; }

		public uint? OBJECTTYPE { get; set; }

		public string OBJECTTYPENAME { get; set; }

		public string REVISION { get; set; }

		public uint? SEQUENCE { get; set; }

		public string TXNID { get; set; }

	}

}
