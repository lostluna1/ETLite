using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class AYIELDLIMITSTXNDETAIL {

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)", IsPrimary = true, IsNullable = false)]
		public string YIELDLIMITSTXNDETAILID { get; set; }

		[JsonProperty, Column(DbType = "NUMBER(22)")]
		public decimal? BASEQTY { get; set; }

		[JsonProperty, Column(DbType = "NUMBER(22)")]
		public decimal? BASEQTY2 { get; set; }

		[JsonProperty]
		public uint? CDOTYPEID { get; set; }

		[JsonProperty]
		public uint? CHANGECOUNT { get; set; }

		[JsonProperty]
		public uint? DETAILSEQUENCE { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(36 BYTE)")]
		public string EXPORTIMPORTKEY { get; set; }

		[JsonProperty]
		public uint? FAILLOWERLIMIT { get; set; }

		[JsonProperty]
		public uint? FAILLOWERLIMIT2 { get; set; }

		[JsonProperty]
		public uint? FAILUPPERLIMIT { get; set; }

		[JsonProperty]
		public uint? FAILUPPERLIMIT2 { get; set; }

		[JsonProperty]
		public uint? FAILYIELDCUTLIMIT { get; set; }

		[JsonProperty]
		public uint? FAILYIELDCUTLIMIT2 { get; set; }

		[JsonProperty]
		public uint? ISFROZEN { get; set; }

		[JsonProperty, Column(DbType = "NUMBER(22)")]
		public decimal? LOWERLIMIT { get; set; }

		[JsonProperty, Column(DbType = "NUMBER(22)")]
		public decimal? LOWERLIMIT2 { get; set; }

		[JsonProperty, Column(DbType = "NUMBER(22)")]
		public decimal? QTY { get; set; }

		[JsonProperty, Column(DbType = "NUMBER(22)")]
		public decimal? QTY2 { get; set; }

		[JsonProperty, Column(DbType = "NUMBER(22)")]
		public decimal? UPPERLIMIT { get; set; }

		[JsonProperty, Column(DbType = "NUMBER(22)")]
		public decimal? UPPERLIMIT2 { get; set; }

		[JsonProperty]
		public uint? YIELDASPECT { get; set; }

		[JsonProperty, Column(DbType = "NUMBER(22)")]
		public decimal? YIELDCUTLIMIT { get; set; }

		[JsonProperty, Column(DbType = "NUMBER(22)")]
		public decimal? YIELDCUTLIMIT2 { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string YIELDLIMITSTXNID { get; set; }

		[JsonProperty, Column(DbType = "NUMBER(22)")]
		public decimal? YIELDVALUE { get; set; }

		[JsonProperty, Column(DbType = "NUMBER(22)")]
		public decimal? YIELDVALUE2 { get; set; }

	}

}
