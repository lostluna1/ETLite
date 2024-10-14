using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class BIZAXISLABELPRINTINGBIZAXISL {

		[JsonProperty, Column(Name = "BIZ_AXISLABELPRINTINGID", DbType = "CHAR(16 BYTE)", IsPrimary = true, IsNullable = false)]
		public string BIZAXISLABELPRINTINGID { get; set; }

		[JsonProperty, Column(IsPrimary = true)]
		public uint FIELDID { get; set; }

		[JsonProperty, Column(IsPrimary = true)]
		public uint SEQUENCE { get; set; }

		[JsonProperty, Column(Name = "BIZ_AXISLABELHISTORYID", DbType = "CHAR(16 BYTE)")]
		public string BIZAXISLABELHISTORYID { get; set; }

	}

}
