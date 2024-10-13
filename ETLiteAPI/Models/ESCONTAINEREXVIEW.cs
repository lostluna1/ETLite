using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models {

	[JsonObject(MemberSerialization.OptIn), Table(Name = "ES_CONTAINEREXVIEW", DisableSyncStructure = true)]
	public partial class ESCONTAINEREXVIEW {

		[JsonProperty]
		public uint? AUTOCOMPONENTISSUE { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string BOMID { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(100 BYTE)")]
		public string CONTAINERNAME { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(100 BYTE)")]
		public string DOCUMENTNAME { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(15 BYTE)")]
		public string DOCUMENTREVISION { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string ERPBOMID { get; set; }

		[JsonProperty, Column(Name = "ES_AUTOOPENINSTRUCTIONS")]
		public uint? ESAUTOOPENINSTRUCTIONS { get; set; }

		[JsonProperty, Column(Name = "ES_CADDOCUMENTID", DbType = "CHAR(16 BYTE)")]
		public string ESCADDOCUMENTID { get; set; }

		[JsonProperty, Column(Name = "ES_CADINSTRUCTIONSID", DbType = "CHAR(16 BYTE)")]
		public string ESCADINSTRUCTIONSID { get; set; }

		[JsonProperty, Column(Name = "ES_CADLAYERSID", DbType = "CHAR(16 BYTE)")]
		public string ESCADLAYERSID { get; set; }

		[JsonProperty, Column(Name = "ES_CADPRIMARYID", DbType = "CHAR(16 BYTE)")]
		public string ESCADPRIMARYID { get; set; }

		[JsonProperty, Column(Name = "ES_FIRSTARTICLEMODE")]
		public uint? ESFIRSTARTICLEMODE { get; set; }

		[JsonProperty, Column(Name = "ES_FIRSTARTICLETRACKINGMODE")]
		public uint? ESFIRSTARTICLETRACKINGMODE { get; set; }

		[JsonProperty, Column(Name = "ES_GUIDEDMANUALASSEMBLY")]
		public uint? ESGUIDEDMANUALASSEMBLY { get; set; }

		[JsonProperty, Column(Name = "ES_ISEDIF")]
		public uint? ESISEDIF { get; set; }

		[JsonProperty, Column(Name = "ES_NPIDOCUMENTVIEW", DbType = "VARCHAR2(30 BYTE)")]
		public string ESNPIDOCUMENTVIEW { get; set; }

		[JsonProperty, Column(Name = "ES_SCHEMATICID", DbType = "CHAR(16 BYTE)")]
		public string ESSCHEMATICID { get; set; }

		[JsonProperty, Column(Name = "ES_USEPRODUCTIONCLIENTBOXMODE")]
		public uint? ESUSEPRODUCTIONCLIENTBOXMODE { get; set; }

		[JsonProperty, Column(DbType = "DATE(7)")]
		public DateTime? EXPIRATIONDATE { get; set; }

		[JsonProperty, Column(DbType = "DATE(7)")]
		public DateTime? EXPIRATIONDATEGMT { get; set; }

		[JsonProperty]
		public uint? INPROCESS { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string LOSSREASONSID { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(255 BYTE)")]
		public string MFGORDERDESC { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(2000 BYTE)")]
		public string MFGORDERNOTES { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)", IsNullable = false)]
		public string OPERATIONID { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(40 BYTE)")]
		public string OPERATIONNAME { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string PRODUCTID { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(100 BYTE)")]
		public string PRODUCTNAME { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(2000 BYTE)")]
		public string PRODUCTNOTES { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(25 BYTE)")]
		public string PRODUCTREVISION { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string RESOURCEGROUPID { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(40 BYTE)")]
		public string RESOURCEGROUPNAME { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string RESOURCEID { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(100 BYTE)")]
		public string RESOURCENAME { get; set; }

		[JsonProperty, Column(DbType = "NUMBER(22)")]
		public decimal? ROUTESTEPDURATIONPERUNIT { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string ROUTESTEPID { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(40 BYTE)")]
		public string RouteStepName { get; set; }

		[JsonProperty]
		public uint? ROUTESTEPRUNRATEOPTION { get; set; }

		[JsonProperty, Column(DbType = "NUMBER(22)")]
		public decimal? ROUTESTEPSETUPTIME { get; set; }

		[JsonProperty, Column(DbType = "NUMBER(22)")]
		public decimal? ROUTESTEPUNITSPERHOUR { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string SPECID { get; set; }

		[JsonProperty]
		public uint? USEQUEUE { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)", IsNullable = false)]
		public string WORKFLOWID { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(40 BYTE)")]
		public string WORKFLOWNAME { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(15 BYTE)")]
		public string WORKFLOWREVISION { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)", IsNullable = false)]
		public string WORKFLOWSTEPID { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(46 BYTE)")]
		public string WORKFLOWSTEPNAME { get; set; }

	}

}
