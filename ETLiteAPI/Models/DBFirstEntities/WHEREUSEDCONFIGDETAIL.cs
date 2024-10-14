using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class WHEREUSEDCONFIGDETAIL {

		public string WHEREUSEDCONFIGDETAILSID { get; set; }

		public uint? CDOTYPEID { get; set; }

		public uint? CHANGECOUNT { get; set; }

		public uint? DBTABLEID { get; set; }

		public string DBTABLENAME { get; set; }

		public uint? ISFROZEN { get; set; }

		public string OBJECTBASECOLUMN { get; set; }

		public string OBJECTCOLUMN { get; set; }

		public string REFERENCERID { get; set; }

		public string WHEREUSEDCONFIGDETAILSNAME { get; set; }

		public string WHEREUSEDCONFIGID { get; set; }

	}

}
