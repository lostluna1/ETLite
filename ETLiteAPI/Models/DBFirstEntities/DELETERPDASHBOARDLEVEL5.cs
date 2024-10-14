using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class DELETERPDASHBOARDLEVEL5 {

		[JsonProperty, Column(DbType = "UNDEFINED(0)")]
		public string ACHIEVEMENT { get; set; }

		[JsonProperty, Column(DbType = "UNDEFINED(0)")]
		public string ADDQTY { get; set; }

		[JsonProperty, Column(Name = "BIZ_BUNAME", DbType = "UNDEFINED(0)")]
		public string BIZBUNAME { get; set; }

		[JsonProperty, Column(DbType = "UNDEFINED(0)")]
		public string COMPLETEQTY { get; set; }

		[JsonProperty, Column(Name = "CREATION_DATE", DbType = "UNDEFINED(0)")]
		public string CREATIONDATE { get; set; }

		[JsonProperty, Column(Name = "CUSTOMER_DESCRIPTION", DbType = "UNDEFINED(0)")]
		public string CUSTOMERDESCRIPTION { get; set; }

		[JsonProperty, Column(DbType = "UNDEFINED(0)")]
		public string CUSTOMERNAME { get; set; }

		[JsonProperty, Column(DbType = "UNDEFINED(0)")]
		public string EFFCIENCY { get; set; }

		[JsonProperty, Column(DbType = "UNDEFINED(0)")]
		public string FACTORYNAME { get; set; }

		[JsonProperty, Column(DbType = "UNDEFINED(0)")]
		public string FQCNGQTY { get; set; }

		[JsonProperty, Column(DbType = "UNDEFINED(0)")]
		public string FQCPASSQTY { get; set; }

		[JsonProperty, Column(DbType = "UNDEFINED(0)")]
		public string MFGLINENAME { get; set; }

		[JsonProperty, Column(DbType = "UNDEFINED(0)")]
		public string MFGORDERNAME { get; set; }

		[JsonProperty, Column(DbType = "UNDEFINED(0)")]
		public string ORDERTYPENAME { get; set; }

		[JsonProperty, Column(DbType = "UNDEFINED(0)")]
		public string PLANQTY { get; set; }

		[JsonProperty, Column(DbType = "UNDEFINED(0)")]
		public string PRODUCTNAME1 { get; set; }

		[JsonProperty, Column(DbType = "UNDEFINED(0)")]
		public string SHIFTCOMPLATEQTY { get; set; }

		[JsonProperty, Column(DbType = "UNDEFINED(0)")]
		public string SHIFTNAME { get; set; }

		[JsonProperty, Column(DbType = "UNDEFINED(0)")]
		public string WOQTY { get; set; }

		[JsonProperty, Column(DbType = "UNDEFINED(0)")]
		public string YIELD { get; set; }

	}

}
