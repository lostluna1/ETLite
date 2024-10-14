using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class ASPRODUCTBOMROUTESELECT {

		[JsonProperty, Column(Name = "BIZ_EFFECTIVEFROMDATE", DbType = "UNDEFINED(0)")]
		public string BIZEFFECTIVEFROMDATE { get; set; }

		[JsonProperty, Column(Name = "BIZ_EFFECTIVETHROUGHDATA", DbType = "UNDEFINED(0)")]
		public string BIZEFFECTIVETHROUGHDATA { get; set; }

		[JsonProperty, Column(DbType = "UNDEFINED(0)")]
		public string BOMID { get; set; }

		[JsonProperty, Column(DbType = "UNDEFINED(0)")]
		public string BOMNAME { get; set; }

		[JsonProperty, Column(DbType = "UNDEFINED(0)")]
		public string BOMREVISION { get; set; }

		[JsonProperty, Column(DbType = "UNDEFINED(0)")]
		public string DESCRIPTION { get; set; }

		[JsonProperty, Column(DbType = "UNDEFINED(0)")]
		public string ERPBOMID { get; set; }

		[JsonProperty, Column(DbType = "UNDEFINED(0)")]
		public string ERPBOMNAME { get; set; }

		[JsonProperty, Column(DbType = "UNDEFINED(0)")]
		public string ERPBOMREVISION { get; set; }

		[JsonProperty, Column(DbType = "UNDEFINED(0)")]
		public string ERPROUTENAME { get; set; }

		[JsonProperty, Column(DbType = "UNDEFINED(0)")]
		public string ERPROUTEREVISION { get; set; }

		[JsonProperty, Column(DbType = "UNDEFINED(0)")]
		public string PRODUCTNAME { get; set; }

		[JsonProperty, Column(DbType = "UNDEFINED(0)")]
		public string PRODUCTREVISION { get; set; }

		[JsonProperty, Column(DbType = "UNDEFINED(0)")]
		public string WORKFLOWNAME { get; set; }

		[JsonProperty, Column(DbType = "UNDEFINED(0)")]
		public string WORKFLOWREVISION { get; set; }

	}

}
