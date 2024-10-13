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
	public partial class CALENDARSHIFT {

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)", IsPrimary = true, IsNullable = false)]
		public string CALENDARSHIFTID { get; set; }

		[JsonProperty, Column(DbType = "DATE(7)")]
		public DateTime? CALENDARDATE { get; set; }

		[JsonProperty]
		public uint? CDOTYPEID { get; set; }

		[JsonProperty]
		public uint? CHANGECOUNT { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(36 BYTE)")]
		public string EXPORTIMPORTKEY { get; set; }

		[JsonProperty]
		public uint? FISCALMONTH { get; set; }

		[JsonProperty]
		public uint? FISCALQUARTER { get; set; }

		[JsonProperty]
		public uint? FISCALWEEK { get; set; }

		[JsonProperty]
		public uint? FISCALYEAR { get; set; }

		[JsonProperty]
		public uint? ISFROZEN { get; set; }

		[JsonProperty, Column(DbType = "NUMBER(22)")]
		public decimal? ISNONSCHEDULEDTIME { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string MFGCALENDARID { get; set; }

		[JsonProperty, Column(DbType = "DATE(7)")]
		public DateTime? SHIFTEND { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string SHIFTID { get; set; }

		[JsonProperty, Column(DbType = "DATE(7)")]
		public DateTime? SHIFTSTART { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string TEAMID { get; set; }

	}

}
