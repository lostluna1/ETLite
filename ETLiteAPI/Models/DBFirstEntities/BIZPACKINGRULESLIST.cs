using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class BIZPACKINGRULESLIST {

		[JsonProperty, Column(Name = "BIZ_PACKINGRULESLISTID", DbType = "CHAR(16 BYTE)", IsPrimary = true, IsNullable = false)]
		public string BIZPACKINGRULESLISTID { get; set; }

		[JsonProperty, Column(Name = "BIZ_PACKINGRULESID", DbType = "CHAR(16 BYTE)")]
		public string BIZPACKINGRULESID { get; set; }

		[JsonProperty, Column(Name = "BIZ_PACKINGRULESLISTNAME", DbType = "VARCHAR2(36 BYTE)")]
		public string BIZPACKINGRULESLISTNAME { get; set; }

		[JsonProperty, Column(DbType = "NUMBER(22)")]
		public decimal? BOXSTDQTY { get; set; }

		[JsonProperty]
		public uint? CDOTYPEID { get; set; }

		[JsonProperty]
		public uint? CHANGECOUNT { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(255 BYTE)")]
		public string COMMENTS { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string CUSTOMERID { get; set; }

		[JsonProperty, Column(DbType = "NUMBER(22)")]
		public decimal? HEIGHT { get; set; }

		[JsonProperty]
		public uint? ISFROZEN { get; set; }

		[JsonProperty, Column(DbType = "NUMBER(22)")]
		public decimal? LENTH { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string PRODUCTID { get; set; }

		[JsonProperty, Column(DbType = "NUMBER(22)")]
		public decimal? STDQTYPERPALLET { get; set; }

		[JsonProperty, Column(DbType = "NUMBER(22)")]
		public decimal? WIDTH { get; set; }

		[JsonProperty, Column(DbType = "NUMBER(22)")]
		public decimal? WTOFPACKING { get; set; }

	}

}
