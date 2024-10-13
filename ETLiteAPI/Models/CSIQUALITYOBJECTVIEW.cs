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
	public partial class CSIQUALITYOBJECTVIEW {

		[JsonProperty, Column(DbType = "VARCHAR2(30 BYTE)")]
		public string DISCOVERYAREA { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string INSTANCEID { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(255 BYTE)")]
		public string OBJECTNAME { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(5 BYTE)")]
		public string OBJECTTYPE { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string ORGANIZATIONID { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(30 BYTE)")]
		public string ORGANIZATIONNAME { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(30 BYTE)")]
		public string OWNERNAME { get; set; }

		[JsonProperty, Column(DbType = "DATE(7)")]
		public DateTime? REPORTEDDATE { get; set; }

		[JsonProperty, Column(DbType = "DATE(7)")]
		public DateTime? REPORTEDDATEGMT { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(30 BYTE)")]
		public string ROLENAME { get; set; }

	}

}
