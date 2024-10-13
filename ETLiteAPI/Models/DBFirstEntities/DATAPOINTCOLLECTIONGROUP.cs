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
	public partial class DATAPOINTCOLLECTIONGROUP {

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)", IsPrimary = true, IsNullable = false)]
		public string DATAPOINTCOLLECTIONGROUPID { get; set; }

		[JsonProperty]
		public uint? CDOTYPEID { get; set; }

		[JsonProperty]
		public uint? CHANGECOUNT { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(30 BYTE)")]
		public string DATAPOINTCOLLECTIONGROUPNAME { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string DATAPOINTCOLLECTIONID { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(36 BYTE)")]
		public string EXPORTIMPORTKEY { get; set; }

		[JsonProperty]
		public uint? GROUPLAYOUT { get; set; }

		[JsonProperty]
		public uint? ISFROZEN { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string LASTENTEREDBYID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string LASTENTEREDBYROLEID { get; set; }

		[JsonProperty, Column(DbType = "DATE(7)")]
		public DateTime? LASTENTEREDON { get; set; }

		[JsonProperty, Column(DbType = "DATE(7)")]
		public DateTime? LASTENTEREDONGMT { get; set; }

		[JsonProperty]
		public uint? MINIMUMSAMPLES { get; set; }

		[JsonProperty]
		public uint? SEQUENCE { get; set; }

	}

}
