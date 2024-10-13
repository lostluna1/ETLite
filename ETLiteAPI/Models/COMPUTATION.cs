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
	public partial class COMPUTATION {

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)", IsPrimary = true, IsNullable = false)]
		public string COMPUTATIONID { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(255 BYTE)")]
		public string ATTRIBUTENAME { get; set; }

		[JsonProperty]
		public uint? CDOTYPEID { get; set; }

		[JsonProperty]
		public uint? CHANGECOUNT { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string CHANGEHISTORYID { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(4000 BYTE)")]
		public string COMPUTATIONEXPRESSION { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(40 BYTE)")]
		public string COMPUTATIONNAME { get; set; }

		[JsonProperty]
		public uint? DECIMALSCALE { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(255 BYTE)")]
		public string DESCRIPTION { get; set; }

		[JsonProperty]
		public uint? DISPLAYLIMITS { get; set; }

		[JsonProperty, Column(DbType = "CLOB")]
		public string FILTERTAGS { get; set; }

		[JsonProperty]
		public uint? ICONID { get; set; }

		[JsonProperty]
		public uint? ISFROZEN { get; set; }

		[JsonProperty]
		public uint? ISLIMITOVERRIDEALLOWED { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(255 BYTE)")]
		public string LOWERLIMIT { get; set; }

		[JsonProperty]
		public uint? MAPTOCONTAINERATTRIBUTE { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(2000 BYTE)")]
		public string NOTES { get; set; }

		[JsonProperty]
		public uint? RESULTDATATYPE { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(40 BYTE)")]
		public string RESULTNAME { get; set; }

		[JsonProperty]
		public uint? ROUNDINGRULE { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string SETUPACCESSID { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(255 BYTE)")]
		public string UPPERLIMIT { get; set; }

	}

}
