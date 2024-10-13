using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models {

	[JsonObject(MemberSerialization.OptIn), Table(Name = "ES_TOOLPLANMATRIXDETAILS", DisableSyncStructure = true)]
	public partial class ESTOOLPLANMATRIXDETAILS {

		[JsonProperty, Column(Name = "ES_TOOLPLANMATRIXDETAILSID", DbType = "CHAR(16 BYTE)", IsPrimary = true, IsNullable = false)]
		public string ESTOOLPLANMATRIXDETAILSID { get; set; }

		[JsonProperty]
		public uint? CDOTYPEID { get; set; }

		[JsonProperty]
		public uint? CHANGECOUNT { get; set; }

		[JsonProperty, Column(Name = "ES_TOOLPLANMATRIXDETAILSNAME", DbType = "VARCHAR2(36 BYTE)")]
		public string ESTOOLPLANMATRIXDETAILSNAME { get; set; }

		[JsonProperty, Column(Name = "ES_TOOLPLANMATRIXID", DbType = "CHAR(16 BYTE)")]
		public string ESTOOLPLANMATRIXID { get; set; }

		[JsonProperty]
		public uint? ISFROZEN { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string RESOURCEID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string SPECBASEID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string SPECID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string TOOLPLANID { get; set; }

	}

}
