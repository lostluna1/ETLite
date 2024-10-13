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
	public partial class CIOLASTUPDATE {

		[JsonProperty, Column(DbType = "DATE(7)")]
		public DateTime? CREATETIME { get; set; }

		[JsonProperty, Column(DbType = "DATE(7)")]
		public DateTime? LASTUPDATE { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(30 BYTE)")]
		public string MACHINENAME { get; set; }

		[JsonProperty]
		public uint? OWNERID { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(127 BYTE)")]
		public string TABLENAME { get; set; }

	}

}
