using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class RPPRODEFFVIEW {

		[JsonProperty, Column(Name = "ACTIVATION_RATE", DbType = "NUMBER(22)")]
		public decimal? ACTIVATIONRATE { get; set; }

		[JsonProperty, Column(DbType = "DATE(7)")]
		public DateTime? CALENDARDAY { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(40 BYTE)")]
		public string MFGLINENAME { get; set; }

		[JsonProperty, Column(Name = "MONTH_OF_YEAR", DbType = "VARCHAR2(2 BYTE)")]
		public string MONTHOFYEAR { get; set; }

		[JsonProperty, Column(DbType = "NUMBER(22)")]
		public decimal? PRDRATE { get; set; }

		[JsonProperty, Column(Name = "WEEK_OF_YEAR", DbType = "VARCHAR2(2 BYTE)")]
		public string WEEKOFYEAR { get; set; }

		[JsonProperty, Column(DbType = "NUMBER(22)")]
		public decimal? WORKRATE { get; set; }

	}

}
