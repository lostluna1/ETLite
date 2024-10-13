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
	public partial class CIOOUTBOUNDDEFINITION {

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)", IsPrimary = true, IsNullable = false)]
		public string CIOOUTBOUNDDEFINITIONID { get; set; }

		[JsonProperty]
		public uint? CDOTYPEID { get; set; }

		[JsonProperty]
		public uint? CHANGECOUNT { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(1000 BYTE)")]
		public string CHANNELADAPTEREXPRESSION { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(100 BYTE)")]
		public string CHANNELADAPTERNAME { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(30 BYTE)")]
		public string CIOACCEPT { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string CIOCAMSTARCONNECTIONID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string CIOCHANNELADAPTERID { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(1000 BYTE)")]
		public string CIOCONDITIONEXPRESSION { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string CIOCONDITIONQUERYID { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(30 BYTE)")]
		public string CIOCONTENTTYPE { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(1000 BYTE)")]
		public string CIOLISTEXPRESSION { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string CIOLISTTEMPLATEDEFID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string CIOMESSAGECHANNELID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string CIOMESSAGETYPEID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string CIOOUTBOUNDMSGDEFID { get; set; }

		[JsonProperty]
		public uint? CIORESPONSERESULTOBJECT { get; set; }

		[JsonProperty]
		public uint? CIOSYNCHTIMING { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string CIOTEMPLATEID { get; set; }

		[JsonProperty, Column(DbType = "CLOB")]
		public string ENDPOINTURL { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(36 BYTE)")]
		public string EXPORTIMPORTKEY { get; set; }

		[JsonProperty]
		public uint? ISENABLED { get; set; }

		[JsonProperty]
		public uint? ISFROZEN { get; set; }

		[JsonProperty]
		public uint? ISRESPONSE { get; set; }

		[JsonProperty]
		public uint? ISSYNCHRONOUS { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(100 BYTE)")]
		public string MESSAGETYPENAME { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string USERQUERYID { get; set; }

	}

}
