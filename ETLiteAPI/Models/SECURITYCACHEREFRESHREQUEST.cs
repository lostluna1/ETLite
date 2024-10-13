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
	public partial class SECURITYCACHEREFRESHREQUEST {

		[JsonProperty, Column(IsPrimary = true)]
		public uint SECURITYCACHEREFRESHREQUESTID { get; set; }

		[JsonProperty, Column(DbType = "DATE(7)")]
		public DateTime? CREATEDDATE { get; set; }

		[JsonProperty, Column(DbType = "DATE(7)")]
		public DateTime? CREATEDDATEGMT { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(30 BYTE)")]
		public string ENTITYNAME { get; set; }

		[JsonProperty]
		public uint? ENTITYTYPE { get; set; }

	}

}
