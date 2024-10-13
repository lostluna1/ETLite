using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models {

	[JsonObject(MemberSerialization.OptIn), Table(DisableSyncStructure = true)]
	public partial class EXPLODEDBOM {

		[JsonProperty, Column(DbType = "VARCHAR2(50 BYTE)")]
		public string COMPONENTLEVEL { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(50 BYTE)")]
		public string COMPONENTQTY { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(50 BYTE)")]
		public string COMPONENTREV { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(50 BYTE)")]
		public string COMPONENTUOM { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(50 BYTE)")]
		public string CONTAINERID { get; set; }

		[JsonProperty, Column(DbType = "DATE(7)")]
		public DateTime? EFFECTIVEFROM { get; set; }

		[JsonProperty, Column(DbType = "DATE(7)")]
		public DateTime? EFFECTIVETHRU { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(30 BYTE)")]
		public string ISSUETYPE { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(50 BYTE)")]
		public string MATERIAL { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(3 BYTE)")]
		public string OVERCONSUMPTION { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(3 BYTE)")]
		public string PHANTOM { get; set; }

		[JsonProperty, Column(DbType = "NUMBER(22)")]
		public decimal? RECID { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(3 BYTE)")]
		public string SUBSTITUTION { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(3 BYTE)")]
		public string UNDERCONSUMPTION { get; set; }

	}

}
