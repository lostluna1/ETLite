using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class ISIDEALCYCLETIMES {

		public string ISIDEALCYCLETIMESID { get; set; }

		public uint? CDOTYPEID { get; set; }

		public uint? CHANGECOUNT { get; set; }

		public decimal? IDEALCYCLETIME { get; set; }

		public uint? ISFROZEN { get; set; }

		public string ISIDEALCYCLETIMESNAME { get; set; }

		public string PARENTID { get; set; }

		public string PRODUCTFAMILYID { get; set; }

		public string PRODUCTID { get; set; }

	}

}
