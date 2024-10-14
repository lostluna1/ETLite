using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class BIZAFERPROCESSINGHSG {

		[JsonProperty, Column(Name = "BIZ_AFERPROCESSINGHSGID", DbType = "CHAR(16 BYTE)", IsPrimary = true, IsNullable = false)]
		public string BIZAFERPROCESSINGHSGID { get; set; }

		[JsonProperty, Column(Name = "BIZ_AFERPROCESSINGHSGNAME", DbType = "VARCHAR2(36 BYTE)")]
		public string BIZAFERPROCESSINGHSGNAME { get; set; }

		[JsonProperty, Column(Name = "BIZ_AFTERHSGRFIDLISTID", DbType = "CHAR(16 BYTE)")]
		public string BIZAFTERHSGRFIDLISTID { get; set; }

		[JsonProperty]
		public uint? CDOTYPEID { get; set; }

		[JsonProperty]
		public uint? CHANGECOUNT { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string HISTORYID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string HISTORYMAINLINEID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string INTEGRATIONTXNID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string TXNID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string WOID { get; set; }

	}

}
