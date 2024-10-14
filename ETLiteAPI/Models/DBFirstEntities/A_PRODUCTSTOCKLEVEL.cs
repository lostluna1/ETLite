using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class A_PRODUCTSTOCKLEVEL {

		public string PRODUCTSTOCKLEVELID { get; set; }

		public uint? CDOTYPEID { get; set; }

		public uint? CHANGECOUNT { get; set; }

		public string EXPORTIMPORTKEY { get; set; }

		public uint? ISFROZEN { get; set; }

		public decimal? MAXQTY { get; set; }

		public decimal? MAXQTY2 { get; set; }

		public decimal? MINQTY { get; set; }

		public decimal? MINQTY2 { get; set; }

		public string OPERATIONID { get; set; }

		public string PRODUCTID { get; set; }

	}

}
