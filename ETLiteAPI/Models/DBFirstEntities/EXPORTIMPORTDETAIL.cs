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
	public partial class EXPORTIMPORTDETAIL {

		[JsonProperty, Column(IsPrimary = true)]
		public uint EXPORTIMPORTDETAILID { get; set; }

		[JsonProperty]
		public uint? ENCRYPTFILE { get; set; }

		[JsonProperty, Column(DbType = "CLOB")]
		public string EXPORTDATA { get; set; }

		[JsonProperty]
		public uint? EXPORTIMPORTHEADERID { get; set; }

		[JsonProperty]
		public uint? EXPORTIMPORTSEQUENCE { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string OBJECTINSTANCEID { get; set; }

		[JsonProperty]
		public uint? OBJECTISROR { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(255 BYTE)")]
		public string OBJECTNAME { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(30 BYTE)")]
		public string OBJECTREVISION { get; set; }

		[JsonProperty]
		public uint? OBJECTTYPEID { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(32 BYTE)")]
		public string OBJECTTYPENAME { get; set; }

		[JsonProperty]
		public uint? STATUS { get; set; }

	}

}
