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
	public partial class CPDEPLOYMENT {

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)", IsPrimary = true, IsNullable = false)]
		public string CPDEPLOYMENTID { get; set; }

		[JsonProperty]
		public uint? CDOTYPEID { get; set; }

		[JsonProperty]
		public uint? CHANGECOUNT { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(256 BYTE)")]
		public string CHANGEPACKAGEEXPORTNAME { get; set; }

		[JsonProperty]
		public uint? DEPLOYMENTPOLLCOUNT { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(36 BYTE)")]
		public string EXPORTIMPORTKEY { get; set; }

		[JsonProperty]
		public uint? EXPORTPOLLCOUNT { get; set; }

		[JsonProperty, Column(DbType = "DATE(7)")]
		public DateTime? EXPORTREQUESTDATE { get; set; }

		[JsonProperty, Column(DbType = "DATE(7)")]
		public DateTime? EXPORTREQUESTDATEGMT { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(256 BYTE)")]
		public string MODELINGINSTANCEEXPORTNAME { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string PARENTID { get; set; }

		[JsonProperty]
		public uint? STATUS { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string TARGETDEPLOYMENTHEADERID { get; set; }

		[JsonProperty]
		public uint? TARGETDEPLOYMENTSTATUS { get; set; }

	}

}
