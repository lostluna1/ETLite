using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class PRODUCTOPTION {

		public string PRODUCTOPTIONID { get; set; }

		public uint? CDOTYPEID { get; set; }

		public uint? CHANGECOUNT { get; set; }

		public string DESCRIPTION { get; set; }

		public DateTime? EFFECTIVEFROM { get; set; }

		public DateTime? EFFECTIVETHRU { get; set; }

		public string EXPORTIMPORTKEY { get; set; }

		public string FROMPRODUCTBASEID { get; set; }

		public string FROMPRODUCTID { get; set; }

		public uint? ICONID { get; set; }

		public uint? ISFROZEN { get; set; }

		public decimal? OPTIONPERCENTAGE { get; set; }

		public string PARENTID { get; set; }

		public string PRODUCTOPTIONNAME { get; set; }

		public uint? STATUS { get; set; }

		public string STEPID { get; set; }

		public string TOPRODUCTBASEID { get; set; }

		public string TOPRODUCTID { get; set; }

	}

}
