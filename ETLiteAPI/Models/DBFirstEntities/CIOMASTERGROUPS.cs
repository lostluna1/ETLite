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
	public partial class CIOMASTERGROUPS {

		[JsonProperty]
		public uint? CIOMASTERGROUPID { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(30 BYTE)")]
		public string CIOMESSAGETYPENAME { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(24 BYTE)")]
		public string MACHINENAME { get; set; }

		[JsonProperty, Column(DbType = "DATE(7)")]
		public DateTime? MSGTYPELASTUPDATE { get; set; }

	}

}
