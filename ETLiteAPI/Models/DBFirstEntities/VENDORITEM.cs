using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class VENDORITEM {

		public string VENDORITEMID { get; set; }

		public uint? CDOTYPEID { get; set; }

		public uint? CHANGECOUNT { get; set; }

		public decimal? COST { get; set; }

		public string DESCRIPTION { get; set; }

		public string EXPORTIMPORTKEY { get; set; }

		public uint? ISFROZEN { get; set; }

		public string ITEMNAME { get; set; }

		public decimal? LEADTIME { get; set; }

		public decimal? MINORDERQTY { get; set; }

		public decimal? MINORDERQTY2 { get; set; }

		public string VENDORID { get; set; }

	}

}
