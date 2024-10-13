using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models {

	[JsonObject(MemberSerialization.OptIn), Table(Name = "ES_MFGORDERREASSIGNPLANDETAILS", DisableSyncStructure = true)]
	public partial class ESMFGORDERREASSIGNPLANDETAILS {

		[JsonProperty, Column(Name = "ES_MFGORDERREASSIGNPLANDETAIID", DbType = "CHAR(16 BYTE)", IsPrimary = true, IsNullable = false)]
		public string ESMFGORDERREASSIGNPLANDETAIID { get; set; }

		[JsonProperty]
		public uint? CDOTYPEID { get; set; }

		[JsonProperty]
		public uint? CHANGECOUNT { get; set; }

		[JsonProperty, Column(Name = "ES_CADDESIGNID", DbType = "VARCHAR2(30 BYTE)")]
		public string ESCADDESIGNID { get; set; }

		[JsonProperty, Column(Name = "ES_FROMMFGORDERID", DbType = "CHAR(16 BYTE)")]
		public string ESFROMMFGORDERID { get; set; }

		[JsonProperty, Column(Name = "ES_MFGORDERREASSIGNPLANDETNAME", DbType = "VARCHAR2(36 BYTE)")]
		public string ESMFGORDERREASSIGNPLANDETNAME { get; set; }

		[JsonProperty, Column(Name = "ES_MFGORDERREASSIGNPLANID", DbType = "CHAR(16 BYTE)")]
		public string ESMFGORDERREASSIGNPLANID { get; set; }

		[JsonProperty, Column(Name = "ES_TOMFGORDERID", DbType = "CHAR(16 BYTE)")]
		public string ESTOMFGORDERID { get; set; }

		[JsonProperty, Column(Name = "ES_WORKFLOWID", DbType = "CHAR(16 BYTE)")]
		public string ESWORKFLOWID { get; set; }

		[JsonProperty]
		public uint? ISFROZEN { get; set; }

	}

}
