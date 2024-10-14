using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class RP_EQPT_LIFETIME {

		public uint? BIZ_LIFETIMELIMIT { get; set; }

		public uint? BIZ_USAGE { get; set; }

		public string DESCRIPTION { get; set; }

		public decimal? REMAIN_QTY { get; set; }

		public string RESOURCENAME { get; set; }

	}

}
