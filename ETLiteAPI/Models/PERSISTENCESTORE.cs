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
	public partial class PERSISTENCESTORE {

		[JsonProperty, Column(DbType = "CHAR(32 BYTE)")]
		public string CONTENTID { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(4000 BYTE)")]
		public string CONTENTTEXT { get; set; }

		[JsonProperty]
		public uint? PARTLENGTH { get; set; }

		[JsonProperty]
		public uint? PARTSEQUENCE { get; set; }

		[JsonProperty, Column(DbType = "DATE(7)")]
		public DateTime? SAVINGTIME { get; set; }

		[JsonProperty, Column(DbType = "CHAR(32 BYTE)")]
		public string WORKFLOWID { get; set; }

	}

}
