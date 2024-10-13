using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models {

	[JsonObject(MemberSerialization.OptIn), Table(Name = "BIZ_EQUIPBORROWTASK", DisableSyncStructure = true)]
	public partial class BIZEQUIPBORROWTASK {

		[JsonProperty, Column(Name = "BIZ_EQUIPBORROWTASKID", DbType = "CHAR(16 BYTE)", IsPrimary = true, IsNullable = false)]
		public string BIZEQUIPBORROWTASKID { get; set; }

		[JsonProperty, Column(Name = "BIZ_BORROWATTACH", DbType = "VARCHAR2(4000 BYTE)")]
		public string BIZBORROWATTACH { get; set; }

		[JsonProperty, Column(Name = "BIZ_EQUIPBORROWERID", DbType = "CHAR(16 BYTE)")]
		public string BIZEQUIPBORROWERID { get; set; }

		[JsonProperty, Column(Name = "BIZ_EQUIPBORROWQTY")]
		public uint? BIZEQUIPBORROWQTY { get; set; }

		[JsonProperty, Column(Name = "BIZ_EQUIPBORROWTASKNAME", DbType = "VARCHAR2(256 BYTE)")]
		public string BIZEQUIPBORROWTASKNAME { get; set; }

		[JsonProperty, Column(Name = "BIZ_EQUIPBORROWTIME", DbType = "DATE(7)")]
		public DateTime? BIZEQUIPBORROWTIME { get; set; }

		[JsonProperty, Column(Name = "BIZ_EQUIPDUETIME", DbType = "DATE(7)")]
		public DateTime? BIZEQUIPDUETIME { get; set; }

		[JsonProperty, Column(Name = "BIZ_EQUIPOPERATORID", DbType = "CHAR(16 BYTE)")]
		public string BIZEQUIPOPERATORID { get; set; }

		[JsonProperty, Column(Name = "BIZ_EQUIPREMARK", DbType = "VARCHAR2(255 BYTE)")]
		public string BIZEQUIPREMARK { get; set; }

		[JsonProperty, Column(Name = "BIZ_EQUIPRETURNTIME", DbType = "DATE(7)")]
		public DateTime? BIZEQUIPRETURNTIME { get; set; }

		[JsonProperty, Column(Name = "BIZ_EQUIPSTATUSID", DbType = "CHAR(16 BYTE)")]
		public string BIZEQUIPSTATUSID { get; set; }

		[JsonProperty, Column(Name = "BIZ_MATCHINGEQUIPID", DbType = "CHAR(16 BYTE)")]
		public string BIZMATCHINGEQUIPID { get; set; }

		[JsonProperty, Column(Name = "BIZ_MATCHINGPNID", DbType = "CHAR(16 BYTE)")]
		public string BIZMATCHINGPNID { get; set; }

		[JsonProperty, Column(Name = "BIZ_MAXRETURNDAYQTY")]
		public uint? BIZMAXRETURNDAYQTY { get; set; }

		[JsonProperty, Column(Name = "BIZ_OBJECTTYPE", DbType = "VARCHAR2(30 BYTE)")]
		public string BIZOBJECTTYPE { get; set; }

		[JsonProperty, Column(Name = "BIZ_OLDPARTRETURN")]
		public uint? BIZOLDPARTRETURN { get; set; }

		[JsonProperty, Column(Name = "BIZ_PARTBORROWACTUALQTY")]
		public uint? BIZPARTBORROWACTUALQTY { get; set; }

		[JsonProperty]
		public uint? CDOTYPEID { get; set; }

		[JsonProperty]
		public uint? CHANGECOUNT { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string CHANGEHISTORYID { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(2000 BYTE)")]
		public string DESCRIPTION { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(255 BYTE)")]
		public string FILTERTAGS { get; set; }

		[JsonProperty]
		public uint? ICONID { get; set; }

		[JsonProperty]
		public uint? ISFROZEN { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(2000 BYTE)")]
		public string NOTES { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string SETUPACCESSID { get; set; }

	}

}
