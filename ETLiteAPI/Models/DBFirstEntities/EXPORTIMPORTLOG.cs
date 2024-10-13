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
	public partial class EXPORTIMPORTLOG {

		[JsonProperty, Column(IsPrimary = true)]
		public uint EXPORTIMPORTLOGID { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(2000 BYTE)")]
		public string COMPLETIONMESSAGE { get; set; }

		[JsonProperty]
		public uint? EXPORTIMPORTDETAILID { get; set; }

		[JsonProperty]
		public uint? EXPORTIMPORTHEADERID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string IMPORTEDOBJECTID { get; set; }

		[JsonProperty, Column(DbType = "DATE(7)")]
		public DateTime? PROCESSDATE { get; set; }

		[JsonProperty, Column(DbType = "DATE(7)")]
		public DateTime? PROCESSDATEGMT { get; set; }

		[JsonProperty]
		public uint? STATUS { get; set; }

	}

}
