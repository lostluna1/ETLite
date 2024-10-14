using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class ESBOARDTOTESTIDHISTORY {

		[JsonProperty, Column(Name = "ES_BOARDTOTESTIDHISTORYID", DbType = "CHAR(16 BYTE)", IsPrimary = true, IsNullable = false)]
		public string ESBOARDTOTESTIDHISTORYID { get; set; }

		[JsonProperty]
		public uint? CDOTYPEID { get; set; }

		[JsonProperty]
		public uint? CHANGECOUNT { get; set; }

		[JsonProperty, Column(Name = "ES_BOARDTOTESTIDHISTORYNAME", DbType = "VARCHAR2(36 BYTE)")]
		public string ESBOARDTOTESTIDHISTORYNAME { get; set; }

		[JsonProperty, Column(Name = "ES_SEQUENCEID")]
		public uint? ESSEQUENCEID { get; set; }

		[JsonProperty, Column(Name = "ES_TESTID", DbType = "VARCHAR2(36 BYTE)")]
		public string ESTESTID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string HISTORYID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string HISTORYMAINLINEID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string INTEGRATIONTXNID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string TXNID { get; set; }

	}

}
