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
	public partial class ISDEFECTREASON {

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)", IsPrimary = true, IsNullable = false)]
		public string ISDEFECTREASONID { get; set; }

		[JsonProperty]
		public uint? ASSOCIATEDPACKAGES { get; set; }

		[JsonProperty]
		public uint? CDOTYPEID { get; set; }

		[JsonProperty]
		public uint? CHANGECOUNT { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string CHANGEHISTORYID { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(255 BYTE)")]
		public string DESCRIPTION { get; set; }

		[JsonProperty, Column(Name = "ES_BOARD")]
		public uint? ESBOARD { get; set; }

		[JsonProperty, Column(Name = "ES_MODULE")]
		public uint? ESMODULE { get; set; }

		[JsonProperty, Column(Name = "ES_MOUNTINGTECHNOLOGY")]
		public uint? ESMOUNTINGTECHNOLOGY { get; set; }

		[JsonProperty, Column(Name = "ES_PART")]
		public uint? ESPART { get; set; }

		[JsonProperty, Column(Name = "ES_PIN")]
		public uint? ESPIN { get; set; }

		[JsonProperty, Column(Name = "ES_PINSHORT")]
		public uint? ESPINSHORT { get; set; }

		[JsonProperty, Column(Name = "ES_SEGMENT")]
		public uint? ESSEGMENT { get; set; }

		[JsonProperty, Column(Name = "ES_SHORT")]
		public uint? ESSHORT { get; set; }

		[JsonProperty, Column(Name = "ES_TRACE")]
		public uint? ESTRACE { get; set; }

		[JsonProperty, Column(Name = "ES_VIA")]
		public uint? ESVIA { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(255 BYTE)")]
		public string FILTERTAGS { get; set; }

		[JsonProperty]
		public uint? ICONID { get; set; }

		[JsonProperty]
		public uint? INSTANCELOCKED { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(40 BYTE)")]
		public string ISDEFECTREASONNAME { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string ISEMAILDISTRIBUTIONID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string ISEMAILMESSAGEID { get; set; }

		[JsonProperty]
		public uint? ISFROZEN { get; set; }

		[JsonProperty]
		public uint? ISINITIALSTATUS { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string ISREPAIRACTIONGROUPID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string ISSEVERITYID { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(2000 BYTE)")]
		public string NOTES { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string SETUPACCESS { get; set; }

	}

}
