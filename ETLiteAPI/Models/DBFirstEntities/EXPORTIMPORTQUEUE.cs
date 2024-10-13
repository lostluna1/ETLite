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
	public partial class EXPORTIMPORTQUEUE {

		[JsonProperty, Column(IsPrimary = true)]
		public uint EXPORTIMPORTQUEUEID { get; set; }

		[JsonProperty, Column(DbType = "DATE(7)")]
		public DateTime? CREATIONDATE { get; set; }

		[JsonProperty]
		public uint? EXPORTIMPORTHEADERID { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(100 BYTE)")]
		public string LOCKGUID { get; set; }

		[JsonProperty]
		public uint? REQUESTACTION { get; set; }

	}

}
