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
	public partial class WIPMSGDETAILS {

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)", IsPrimary = true, IsNullable = false)]
		public string WIPMSGDETAILSID { get; set; }

		[JsonProperty]
		public uint? ACKNOWLEDGMENTREQUIRED { get; set; }

		[JsonProperty]
		public uint? CDOTYPEID { get; set; }

		[JsonProperty]
		public uint? CHANGECOUNT { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string CHANGESTATUSID { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(2000 BYTE)")]
		public string CONTACTINFO { get; set; }

		[JsonProperty, Column(DbType = "DATE(7)")]
		public DateTime? CREATIONDATE { get; set; }

		[JsonProperty, Column(DbType = "DATE(7)")]
		public DateTime? CREATIONDATEGMT { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string DOCUMENTBASEID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string DOCUMENTID { get; set; }

		[JsonProperty, Column(DbType = "DATE(7)")]
		public DateTime? EFFECTIVEFROMDATE { get; set; }

		[JsonProperty, Column(DbType = "DATE(7)")]
		public DateTime? EFFECTIVEFROMDATEGMT { get; set; }

		[JsonProperty, Column(DbType = "DATE(7)")]
		public DateTime? EFFECTIVETHRUDATE { get; set; }

		[JsonProperty, Column(DbType = "DATE(7)")]
		public DateTime? EFFECTIVETHRUDATEGMT { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(36 BYTE)")]
		public string EXPORTIMPORTKEY { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string HOLDREASONID { get; set; }

		[JsonProperty]
		public uint? ISFROZEN { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string MSGACTIONID { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(2000 BYTE)")]
		public string MSGTEXT { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(255 BYTE)")]
		public string NOTIFICATIONTEXT { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string PARENTID { get; set; }

		[JsonProperty]
		public uint? PASSWORDREQUIRED { get; set; }

		[JsonProperty]
		public uint? RELEVANTSERVICETYPE { get; set; }

		[JsonProperty]
		public uint? SENDNOTIFICATION { get; set; }

		[JsonProperty]
		public uint? STATUS { get; set; }

		[JsonProperty]
		public uint? STOPPROCESSING { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(2000 BYTE)")]
		public string TEXTVARIABLES { get; set; }

		[JsonProperty]
		public uint? TRIGGERACTION { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(30 BYTE)")]
		public string WIPMSGDETAILSNAME { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(30 BYTE)")]
		public string WIPMSGPASSWORD { get; set; }

		[JsonProperty]
		public uint? WRITETOHISTORY { get; set; }

	}

}
