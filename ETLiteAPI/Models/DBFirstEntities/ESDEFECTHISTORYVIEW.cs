using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class ESDEFECTHISTORYVIEW {

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string CHILDID { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(255 BYTE)")]
		public string DESCRIPTION { get; set; }

		[JsonProperty, Column(Name = "ES_NET1", DbType = "VARCHAR2(64 BYTE)")]
		public string ESNET1 { get; set; }

		[JsonProperty, Column(Name = "ES_NET2", DbType = "VARCHAR2(64 BYTE)")]
		public string ESNET2 { get; set; }

		[JsonProperty, Column(Name = "ES_PIN", DbType = "VARCHAR2(64 BYTE)")]
		public string ESPIN { get; set; }

		[JsonProperty, Column(Name = "ES_SYMPTOM", DbType = "VARCHAR2(255 BYTE)")]
		public string ESSYMPTOM { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)", IsNullable = false)]
		public string ISDEFECTHISTORYDETAILID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string ISDEFECTREASONID { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(40 BYTE)")]
		public string ISDEFECTREASONNAME { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(2000 BYTE)")]
		public string ISINSPECTNOTE { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(30 BYTE)")]
		public string ISREFDES { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string PRODUCTID { get; set; }

		[JsonProperty, Column(DbType = "DATE(7)")]
		public DateTime? TXNDATE { get; set; }

	}

}
