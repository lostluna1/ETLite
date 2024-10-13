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
	public partial class CDODEFINITIONORDEREDVIEW {

		[JsonProperty]
		public uint? CDODEFID { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(4000 BYTE)")]
		public string CDODESCRIPTION { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(37 BYTE)")]
		public string CDONAME { get; set; }

		[JsonProperty]
		public uint? CDOUSAGEMASK { get; set; }

		[JsonProperty, Column(DbType = "NUMBER(22)")]
		public decimal? CHILDLEVEL { get; set; }

		[JsonProperty]
		public uint? DEFAULTTABLEID { get; set; }

		[JsonProperty]
		public uint? DISPLAYNAMELABELID { get; set; }

		[JsonProperty]
		public bool? ENFORCEINTEGRITY { get; set; }

		[JsonProperty]
		public bool? ISABSTRACT { get; set; }

		[JsonProperty]
		public bool? ISEXPOSEDTOCLIENTUI { get; set; }

		[JsonProperty]
		public uint? MAINTENANCETYPEID { get; set; }

		[JsonProperty]
		public uint? OBJECTSTOCACHE { get; set; }

		[JsonProperty]
		public uint? PARENTCDOID { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(50 BYTE)")]
		public string READOVERRIDE { get; set; }

		[JsonProperty]
		public uint? REVISIONTYPEID { get; set; }

		[JsonProperty]
		public uint? SECURITYTYPEID { get; set; }

		[JsonProperty]
		public uint? SELVALQUERYDEFID { get; set; }

		[JsonProperty]
		public uint? UIDETAILSID { get; set; }

		[JsonProperty]
		public bool? USEINSTANCESECURITY { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(50 BYTE)")]
		public string WRITEOVERRIDE { get; set; }

	}

}
