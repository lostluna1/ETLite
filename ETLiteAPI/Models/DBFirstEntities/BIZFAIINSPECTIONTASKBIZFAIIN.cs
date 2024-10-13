using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models {

	[JsonObject(MemberSerialization.OptIn), Table(Name = "BIZ_FAIINSPECTIONTASKBIZ_FAIIN", DisableSyncStructure = true)]
	public partial class BIZFAIINSPECTIONTASKBIZFAIIN {

		[JsonProperty, Column(Name = "BIZ_FAIINSPECTIONTASKID", DbType = "CHAR(16 BYTE)", IsPrimary = true, IsNullable = false)]
		public string BIZFAIINSPECTIONTASKID { get; set; }

		[JsonProperty, Column(IsPrimary = true)]
		public uint FIELDID { get; set; }

		[JsonProperty, Column(IsPrimary = true)]
		public uint SEQUENCE { get; set; }

		[JsonProperty, Column(Name = "BIZ_FAIINSPECTIONTASKDETAILID", DbType = "CHAR(16 BYTE)")]
		public string BIZFAIINSPECTIONTASKDETAILID { get; set; }

	}

}
