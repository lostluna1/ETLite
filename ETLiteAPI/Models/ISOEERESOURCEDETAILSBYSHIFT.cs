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
	public partial class ISOEERESOURCEDETAILSBYSHIFT {

		[JsonProperty, Column(DbType = "DATE(7)")]
		public DateTime? CALENDARDATE { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string CALENDARSHIFTID { get; set; }

		[JsonProperty]
		public uint? OEELOSSCATEGORY { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(255 BYTE)")]
		public string OEELOSSCATEGORYNAME { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string RESOURCEFAMILY { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string RESOURCEID { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(255 BYTE)")]
		public string RESOURCENAME { get; set; }

		[JsonProperty]
		public uint? RESOURCESTATE { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(255 BYTE)")]
		public string RESOURCESTATENAME { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(255 BYTE)")]
		public string RESOURCESTATUSCODE { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(255 BYTE)")]
		public string RESOURCESTATUSREASON { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(255 BYTE)")]
		public string SHIFT { get; set; }

		[JsonProperty, Column(DbType = "NUMBER(22)")]
		public decimal? TIMEINSTATUS { get; set; }

	}

}
