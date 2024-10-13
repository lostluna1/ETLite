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
	public partial class ISMATERIALQUEUEDETAILS {

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)", IsPrimary = true, IsNullable = false)]
		public string ISMATERIALQUEUEDETAILSID { get; set; }

		[JsonProperty]
		public uint? CDOTYPEID { get; set; }

		[JsonProperty]
		public uint? CHANGECOUNT { get; set; }

		[JsonProperty, Column(DbType = "NUMBER(22)")]
		public decimal? ISCONSUMEDQTY { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string ISCONTAINERID { get; set; }

		[JsonProperty]
		public uint? ISERP { get; set; }

		[JsonProperty, Column(DbType = "DATE(7)")]
		public DateTime? ISEXPIRATIONDATE { get; set; }

		[JsonProperty]
		public uint? ISFROZEN { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string ISINVENTORYLOCATIONID { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(30 BYTE)")]
		public string ISLOT { get; set; }

		[JsonProperty]
		public uint? ISMANUALCONSUMED { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(36 BYTE)")]
		public string ISMATERIALQUEUEDETAILSNAME { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string ISMATERIALQUEUEID { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(30 BYTE)")]
		public string ISNAME { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string ISPRODUCTID { get; set; }

		[JsonProperty, Column(DbType = "NUMBER(22)")]
		public decimal? ISQTY { get; set; }

		[JsonProperty, Column(DbType = "NUMBER(22)")]
		public decimal? ISQTYAVAILABLE { get; set; }

		[JsonProperty]
		public uint? ISREMOVALSTRATEGY { get; set; }

		[JsonProperty]
		public uint? ISSEQUENCE { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string ISUOMID { get; set; }

	}

}
