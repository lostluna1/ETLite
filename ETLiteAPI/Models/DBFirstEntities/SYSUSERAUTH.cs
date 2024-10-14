using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class SYSUSERAUTH {

		[JsonProperty, Column(DbType = "NUMBER(22)", IsPrimary = true, InsertValueSql = "\"SIEMENSPRD\".\"ISEQ$$_313563\".nextval")]
		public decimal ID { get; set; }

		[JsonProperty, Column(DbType = "CLOB", IsNullable = false)]
		public string AUTHUSERIDS { get; set; }

		[JsonProperty, Column(DbType = "DATE(7)", InsertValueSql = "NULL")]
		public DateTime? CREATEDATE { get; set; }

		[JsonProperty, Column(DbType = "NUMBER(22)", InsertValueSql = "NULL")]
		public decimal? CREATEID { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(255 BYTE)")]
		public string CREATOR { get; set; } = "NULL";

		[JsonProperty, Column(DbType = "NUMBER(22)")]
		public decimal ENABLE { get; set; }

		[JsonProperty, Column(DbType = "NUMBER(22)", InsertValueSql = "NULL")]
		public decimal? MENUID { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(255 BYTE)")]
		public string MODIFIER { get; set; } = "NULL";

		[JsonProperty, Column(DbType = "DATE(7)", InsertValueSql = "NULL")]
		public DateTime? MODIFYDATE { get; set; }

		[JsonProperty, Column(DbType = "NUMBER(22)", InsertValueSql = "NULL")]
		public decimal? MODIFYID { get; set; }

		[JsonProperty, Column(DbType = "NUMBER(22)", InsertValueSql = "NULL")]
		public decimal? TABLENAME { get; set; }

		[JsonProperty, Column(DbType = "NUMBER(22)")]
		public decimal USERID { get; set; }

	}

}
