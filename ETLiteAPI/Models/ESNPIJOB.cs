using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models {

	[JsonObject(MemberSerialization.OptIn), Table(Name = "ES_NPIJOB", DisableSyncStructure = true)]
	public partial class ESNPIJOB {

		[JsonProperty, Column(Name = "ES_NPIJOBID", DbType = "CHAR(16 BYTE)", IsPrimary = true, IsNullable = false)]
		public string ESNPIJOBID { get; set; }

		[JsonProperty]
		public uint? CDOTYPEID { get; set; }

		[JsonProperty]
		public uint? CHANGECOUNT { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string CHANGEHISTORYID { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(255 BYTE)")]
		public string DESCRIPTION { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(30 BYTE)")]
		public string ECO { get; set; }

		[JsonProperty, Column(Name = "ES_CADDOCUMENTID", DbType = "CHAR(16 BYTE)")]
		public string ESCADDOCUMENTID { get; set; }

		[JsonProperty, Column(Name = "ES_CADINSTRUCTIONSID", DbType = "CHAR(16 BYTE)")]
		public string ESCADINSTRUCTIONSID { get; set; }

		[JsonProperty, Column(Name = "ES_CADLAYERSID", DbType = "CHAR(16 BYTE)")]
		public string ESCADLAYERSID { get; set; }

		[JsonProperty, Column(Name = "ES_CADPRIMARYID", DbType = "CHAR(16 BYTE)")]
		public string ESCADPRIMARYID { get; set; }

		[JsonProperty, Column(Name = "ES_COLUMNS")]
		public uint? ESCOLUMNS { get; set; }

		[JsonProperty, Column(Name = "ES_CREATEDBY", DbType = "VARCHAR2(255 BYTE)")]
		public string ESCREATEDBY { get; set; }

		[JsonProperty, Column(Name = "ES_DATEOFCREATION", DbType = "DATE(7)")]
		public DateTime? ESDATEOFCREATION { get; set; }

		[JsonProperty, Column(Name = "ES_JOBFILE", DbType = "VARCHAR2(255 BYTE)")]
		public string ESJOBFILE { get; set; }

		[JsonProperty, Column(Name = "ES_LASTMODIFIED", DbType = "DATE(7)")]
		public DateTime? ESLASTMODIFIED { get; set; }

		[JsonProperty, Column(Name = "ES_NOTES", DbType = "VARCHAR2(255 BYTE)")]
		public string ESNOTES { get; set; }

		[JsonProperty, Column(Name = "ES_NPIJOBBASEID", DbType = "CHAR(16 BYTE)")]
		public string ESNPIJOBBASEID { get; set; }

		[JsonProperty, Column(Name = "ES_PANELCONFIGURATION")]
		public uint? ESPANELCONFIGURATION { get; set; }

		[JsonProperty, Column(Name = "ES_ROWS")]
		public uint? ESROWS { get; set; }

		[JsonProperty, Column(Name = "ES_VERSION", DbType = "VARCHAR2(25 BYTE)")]
		public string ESVERSION { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(255 BYTE)")]
		public string FILTERTAGS { get; set; }

		[JsonProperty]
		public uint? ICONID { get; set; }

		[JsonProperty]
		public uint? ISFROZEN { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(2000 BYTE)")]
		public string NOTES { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(15 BYTE)")]
		public string REVISION { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string SETUPACCESSID { get; set; }

		[JsonProperty]
		public uint? STATUS { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string WIPMSGDEFMGRID { get; set; }

	}

}
