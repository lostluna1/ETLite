using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models {

	[JsonObject(MemberSerialization.OptIn), Table(Name = "RP_EQPT_MAINTENANCE", DisableSyncStructure = true)]
	public partial class RPEQPTMAINTENANCE {

		[JsonProperty, Column(Name = "BIZ_ASSETDEPT", DbType = "VARCHAR2(30 BYTE)")]
		public string BIZASSETDEPT { get; set; }

		[JsonProperty, Column(Name = "BIZ_ASSETDES", DbType = "VARCHAR2(255 BYTE)")]
		public string BIZASSETDES { get; set; }

		[JsonProperty, Column(Name = "BIZ_EQUIPMAINTTASK", DbType = "VARCHAR2(30 BYTE)")]
		public string BIZEQUIPMAINTTASK { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(40 BYTE)")]
		public string PHYSICALLOCATIONNAME { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(40 BYTE)")]
		public string RESOURCEFAMILYNAME { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(100 BYTE)")]
		public string RESOURCENAME { get; set; }

	}

}
