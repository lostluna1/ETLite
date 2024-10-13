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
	public partial class EMAILQUEUE {

		[JsonProperty, Column(DbType = "DATE(7)")]
		public DateTime? CREATEDDATE { get; set; }

		[JsonProperty]
		public uint? EMAILQUEUEID { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(512 BYTE)")]
		public string LASTERRORMESSAGE { get; set; }

		[JsonProperty, Column(DbType = "DATE(7)")]
		public DateTime? LASTSENDATTEMPTDATE { get; set; }

		[JsonProperty, Column(DbType = "CLOB")]
		public string MESSAGEBODY { get; set; }

		[JsonProperty]
		public uint? MESSAGEFORMAT { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(50 BYTE)")]
		public string PROCESSINGSERVER { get; set; }

		[JsonProperty]
		public uint? PROCESSINGSTATUS { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(512 BYTE)")]
		public string RECIPIENTS { get; set; }

		[JsonProperty]
		public uint? SENDATTEMPTS { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(100 BYTE)")]
		public string SENDER { get; set; }

		[JsonProperty, Column(DbType = "DATE(7)")]
		public DateTime? SENTDATE { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string SMTPTRANSPORTID { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(512 BYTE)")]
		public string SUBJECT { get; set; }

	}

}
