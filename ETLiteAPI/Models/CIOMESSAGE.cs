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
	public partial class CIOMESSAGE {

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)", IsPrimary = true, IsNullable = false)]
		public string CIOMESSAGEID { get; set; }

		[JsonProperty, Column(DbType = "CLOB")]
		public string ATTRIBUTES { get; set; }

		[JsonProperty]
		public uint? CDOTYPEID { get; set; }

		[JsonProperty]
		public uint? CHANGECOUNT { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(30 BYTE)")]
		public string CHANNELSOURCENAME { get; set; }

		[JsonProperty, Column(DbType = "CLOB")]
		public string CONTENTS { get; set; }

		[JsonProperty]
		public uint? CONTENTTYPE { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(255 BYTE)")]
		public string DESCRIPTION { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(255 BYTE)")]
		public string DESTINATION { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(50 BYTE)")]
		public string DICTKEY { get; set; }

		[JsonProperty]
		public uint? ISCACHE { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(255 BYTE)")]
		public string MESSAGENAME { get; set; }

		[JsonProperty, Column(DbType = "DATE(7)")]
		public DateTime? MESSAGETIMESTAMP { get; set; }

		[JsonProperty, Column(DbType = "DATE(7)")]
		public DateTime? MESSAGETIMESTAMPGMT { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(255 BYTE)")]
		public string MESSAGETYPE { get; set; }

		[JsonProperty]
		public uint? OKTODELETE { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(255 BYTE)")]
		public string ORIGINATOR { get; set; }

		[JsonProperty]
		public uint? OWNERS { get; set; }

		[JsonProperty, Column(DbType = "CLOB")]
		public string TAGDATA { get; set; }

	}

}
