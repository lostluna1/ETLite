using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models {

	[JsonObject(MemberSerialization.OptIn), Table(Name = "ISRESOURCESDWNTSCHD_CALENDAR", DisableSyncStructure = true)]
	public partial class ISRESOURCESDWNTSCHDCALENDAR {

		[JsonProperty, Column(DbType = "DATE(7)")]
		public DateTime? CALENDARDATE { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)", IsNullable = false)]
		public string CALENDARSHIFTID { get; set; }

		[JsonProperty]
		public uint? CDOTYPEID { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(30 BYTE)")]
		public string FACTORYNAME { get; set; }

		[JsonProperty, Column(DbType = "DATE(7)")]
		public DateTime? ISENDTIME { get; set; }

		[JsonProperty, Column(DbType = "DATE(7)")]
		public DateTime? ISSTARTTIME { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(30 BYTE)")]
		public string MFGCALENDARNAME { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(40 BYTE)")]
		public string RESOURCEFAMILYNAME { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)", IsNullable = false)]
		public string RESOURCEID { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(100 BYTE)")]
		public string RESOURCENAME { get; set; }

		[JsonProperty, Column(DbType = "DATE(7)")]
		public DateTime? SHIFTEND { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string SHIFTID { get; set; }

		[JsonProperty, Column(DbType = "DATE(7)")]
		public DateTime? SHIFTSTART { get; set; }

	}

}
