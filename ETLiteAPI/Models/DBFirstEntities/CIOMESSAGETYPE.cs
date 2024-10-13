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
	public partial class CIOMESSAGETYPE {

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)", IsPrimary = true, IsNullable = false)]
		public string CIOMESSAGETYPEID { get; set; }

		[JsonProperty]
		public uint? CACHEEXPIRATION { get; set; }

		[JsonProperty]
		public uint? CDOTYPEID { get; set; }

		[JsonProperty]
		public uint? CHANGECOUNT { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string CHANGEHISTORYID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string CIODISPATCHRULEID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string CIOMESSAGEMAPBASEID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string CIOMESSAGEMAPID { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(40 BYTE)")]
		public string CIOMESSAGETYPENAME { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string CIOWORKFLOWBASEID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string CIOWORKFLOWID { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(255 BYTE)")]
		public string DESCRIPTION { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(100 BYTE)")]
		public string DISPATCHADDRESS { get; set; }

		[JsonProperty]
		public uint? EVENTONLY { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(255 BYTE)")]
		public string FILTERTAGS { get; set; }

		[JsonProperty]
		public uint? ICONID { get; set; }

		[JsonProperty]
		public uint? INHIBITEVENT { get; set; }

		[JsonProperty]
		public uint? ISCHILDTYPE { get; set; }

		[JsonProperty]
		public uint? ISEXPRESS { get; set; }

		[JsonProperty]
		public uint? ISFROZEN { get; set; }

		[JsonProperty]
		public uint? ISREQUEST { get; set; }

		[JsonProperty]
		public uint? MAXRETRYCOUNT { get; set; }

		[JsonProperty]
		public uint? MINQUEUETIME { get; set; }

		[JsonProperty]
		public uint? MINRETRYINTERVAL { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(2000 BYTE)")]
		public string NOTES { get; set; }

		[JsonProperty]
		public uint? OUTBOUNDONCREATE { get; set; }

		[JsonProperty]
		public uint? PRIORITY { get; set; }

		[JsonProperty]
		public uint? REQUIRESCACHE { get; set; }

		[JsonProperty]
		public uint? RESPONSETIMEOUT { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string RESPONSETOTYPEID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string SETUPACCESS { get; set; }

		[JsonProperty]
		public uint? TIMETOLIVE { get; set; }

	}

}
