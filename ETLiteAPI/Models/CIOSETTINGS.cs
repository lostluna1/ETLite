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
	public partial class CIOSETTINGS {

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)", IsPrimary = true, IsNullable = false)]
		public string CIOSETTINGSID { get; set; }

		[JsonProperty, Column(DbType = "CLOB")]
		public string BROKERSERVICEENDPOINTS { get; set; }

		[JsonProperty]
		public uint? CDOTYPEID { get; set; }

		[JsonProperty]
		public uint? CHANGECOUNT { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string CHANGEHISTORYID { get; set; }

		[JsonProperty]
		public uint? CHECKCONFIGINTERVAL { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string CIOCAMSTARCONNECTIONID { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(40 BYTE)")]
		public string CIOSETTINGSNAME { get; set; }

		[JsonProperty]
		public uint? CLIENBTGATEWAYPOSTTIMEOUT { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(512 BYTE)")]
		public string CLIENTGATEWAYURL { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(512 BYTE)")]
		public string CONFIGSERVICEURL { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(128 BYTE)")]
		public string CONFIGSVCPASSWORD { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(255 BYTE)")]
		public string CONFIGSVCUSERNAME { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(255 BYTE)")]
		public string DESCRIPTION { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(255 BYTE)")]
		public string FILTERTAGS { get; set; }

		[JsonProperty, Column(DbType = "CLOB")]
		public string HELPERSERVICEENDPOINTS { get; set; }

		[JsonProperty]
		public uint? ICONID { get; set; }

		[JsonProperty]
		public uint? ISFROZEN { get; set; }

		[JsonProperty]
		public uint? LOGPURGECRITICALINTERVAL { get; set; }

		[JsonProperty]
		public uint? LOGPURGEDEBUGINTERVAL { get; set; }

		[JsonProperty]
		public uint? LOGPURGEFREQUENCY { get; set; }

		[JsonProperty]
		public uint? LOGPURGEINTERVAL { get; set; }

		[JsonProperty]
		public uint? LOGPURGEMAXCYCLES { get; set; }

		[JsonProperty]
		public uint? LOGPURGEROWSPERCYCLE { get; set; }

		[JsonProperty, Column(DbType = "CLOB")]
		public string LOGSERVICEENDPOINTS { get; set; }

		[JsonProperty, Column(DbType = "CLOB")]
		public string MAPSERVICEENDPOINTS { get; set; }

		[JsonProperty]
		public uint? MAXIMUMLOGLEVEL { get; set; }

		[JsonProperty]
		public uint? MAXIMUMMETRICLEVEL { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(2000 BYTE)")]
		public string NOTES { get; set; }

		[JsonProperty]
		public uint? PERSISTEXPIREDINTEVAL { get; set; }

		[JsonProperty]
		public uint? PERSISTLOADINTERVAL { get; set; }

		[JsonProperty, Column(DbType = "CLOB")]
		public string ROUTERSERVICEENDPOINTS { get; set; }

		[JsonProperty, Column(DbType = "CLOB")]
		public string SERVICEBEHAVIORS { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string SETTINGSPERSISTID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string SETUPACCESS { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string SMTPTRANSPORTID { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(100 BYTE)")]
		public string WORKFLOWSTORECONNECTIONNAME { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(2000 BYTE)")]
		public string WORKFLOWSTORECONNECTIONSTRING { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(100 BYTE)")]
		public string WORKFLOWSTOREPLUGIN { get; set; }

		[JsonProperty]
		public uint? WORKFLOWUNAVAILABLEMAXTIME { get; set; }

	}

}
