using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class ESBOARDTOTESTID {

		[JsonProperty, Column(Name = "ES_BOARDTOTESTID", DbType = "CHAR(16 BYTE)", IsPrimary = true, IsNullable = false)]
		public string ES_BOARDTOTESTID { get; set; }

		[JsonProperty]
		public uint? CDOTYPEID { get; set; }

		[JsonProperty]
		public uint? CHANGECOUNT { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string CONTAINERID { get; set; }

		[JsonProperty, Column(Name = "ES_BOARDTOTESTIDNAME", DbType = "VARCHAR2(36 BYTE)")]
		public string ESBOARDTOTESTIDNAME { get; set; }

		[JsonProperty, Column(Name = "ES_SEQUENCEID")]
		public uint? ESSEQUENCEID { get; set; }

		[JsonProperty, Column(Name = "ES_TESTID", DbType = "VARCHAR2(36 BYTE)")]
		public string ESTESTID { get; set; }

		[JsonProperty, Column(DbType = "DATE(7)")]
		public DateTime? TXNDATE { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string TXNID { get; set; }

	}

}
