using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models {

	[JsonObject(MemberSerialization.OptIn), Table(Name = "RV_TDAINFO", DisableSyncStructure = true)]
	public partial class RVTDAINFO {

		[JsonProperty, Column(Name = "ES_DOCUMENTDISPLAYNAME", DbType = "VARCHAR2(255 BYTE)")]
		public string ESDOCUMENTDISPLAYNAME { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(100 BYTE)")]
		public string IDENTIFIER { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(100 BYTE)")]
		public string PRIMARYSERIALNUMBER { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(100 BYTE)")]
		public string SERIALNUMBER2 { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(100 BYTE)")]
		public string SERIALNUMBER3 { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(30 BYTE)")]
		public string TDANAME { get; set; }

	}

}
