using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class SPCCHARTCUSTOMINFO {

		public string SPCCHARTCUSTOMINFOID { get; set; }

		public uint? CDOTYPEID { get; set; }

		public uint? CHANGECOUNT { get; set; }

		public string COLUMNNAME { get; set; }

		public uint? INTOOLTIP { get; set; }

		public uint? ISFROZEN { get; set; }

		public uint? ISREMARK { get; set; }

		public string LABELTEXT { get; set; }

		public string PARENTID { get; set; }

		public string SPCCHARTCUSTOMINFONAME { get; set; }

		public uint? SUBGROUPITEM { get; set; }

		public uint? XAXISLABEL { get; set; }

	}

}
