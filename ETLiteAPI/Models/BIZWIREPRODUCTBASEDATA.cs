using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models {

	[JsonObject(MemberSerialization.OptIn), Table(Name = "BIZ_WIREPRODUCTBASEDATA", DisableSyncStructure = true)]
	public partial class BIZWIREPRODUCTBASEDATA {

		[JsonProperty, Column(Name = "BIZ_WIREPRODUCTBASEDATAID", DbType = "CHAR(16 BYTE)", IsPrimary = true, IsNullable = false)]
		public string BIZWIREPRODUCTBASEDATAID { get; set; }

		[JsonProperty, Column(Name = "BIZ_WIREPRODUCTBASEDATANAME", DbType = "VARCHAR2(64 BYTE)")]
		public string BIZWIREPRODUCTBASEDATANAME { get; set; }

		[JsonProperty]
		public uint? CDOTYPEID { get; set; }

		[JsonProperty]
		public uint? CHANGECOUNT { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string CHANGEHISTORYID { get; set; }

		[JsonProperty, Column(DbType = "NUMBER(22)")]
		public decimal? CONDUCTOROD { get; set; }

		[JsonProperty, Column(DbType = "NUMBER(22)")]
		public decimal? CONDUCTORSA { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(2000 BYTE)")]
		public string DESCRIPTION { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string FACTORYID { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(255 BYTE)")]
		public string FILTERTAGS { get; set; }

		[JsonProperty]
		public uint? ICONID { get; set; }

		[JsonProperty]
		public uint? ISAVAILABLE { get; set; }

		[JsonProperty]
		public uint? ISFROZEN { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(2000 BYTE)")]
		public string NOTES { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string SETUPACCESSID { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(100 BYTE)")]
		public string SPECIFICATIONCODE { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(40 BYTE)")]
		public string WIRECOLOR { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string WIRERODPRODUCTID { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(40 BYTE)")]
		public string WIRESPECIFICATIONS { get; set; }

	}

}
