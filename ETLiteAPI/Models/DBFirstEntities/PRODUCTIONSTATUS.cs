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
	public partial class PRODUCTIONSTATUS {

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)", IsPrimary = true, IsNullable = false)]
		public string PRODUCTIONSTATUSID { get; set; }

		[JsonProperty]
		public uint? AVAILABILITY { get; set; }

		[JsonProperty]
		public uint? CDOTYPEID { get; set; }

		[JsonProperty]
		public uint? CHANGECOUNT { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(2000 BYTE)")]
		public string COMMENTS { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string CONTAINERID { get; set; }

		[JsonProperty, Column(Name = "ES_TOOLPLANDETAILID", DbType = "CHAR(16 BYTE)")]
		public string ESTOOLPLANDETAILID { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(36 BYTE)")]
		public string EXPORTIMPORTKEY { get; set; }

		[JsonProperty]
		public uint? INPROCESS { get; set; }

		[JsonProperty]
		public uint? ISOEELOSSCATEGORY { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string ISTRACKINGCONTAINERID { get; set; }

		[JsonProperty]
		public uint? JOBCOUNT { get; set; }

		[JsonProperty, Column(DbType = "DATE(7)")]
		public DateTime? LASTACTIVITYDATE { get; set; }

		[JsonProperty, Column(DbType = "DATE(7)")]
		public DateTime? LASTACTIVITYDATEGMT { get; set; }

		[JsonProperty, Column(DbType = "DATE(7)")]
		public DateTime? LASTCOMPONENTSETUPDATE { get; set; }

		[JsonProperty, Column(DbType = "DATE(7)")]
		public DateTime? LASTCOMPONENTSETUPDATEGMT { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string LASTPROCESSEDCONTAINERID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string LASTREVTXNID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string LASTROUTESTEPID { get; set; }

		[JsonProperty, Column(DbType = "DATE(7)")]
		public DateTime? LASTSTATUSCHANGEDATE { get; set; }

		[JsonProperty, Column(DbType = "DATE(7)")]
		public DateTime? LASTSTATUSCHANGEDATEGMT { get; set; }

		[JsonProperty, Column(DbType = "DATE(7)")]
		public DateTime? LASTTHRUPUTDATE { get; set; }

		[JsonProperty, Column(DbType = "DATE(7)")]
		public DateTime? LASTTHRUPUTDATEGMT { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string MFGLINEID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string MFGORDERID { get; set; }

		[JsonProperty]
		public uint? PARTDECOMMISSIONED { get; set; }

		[JsonProperty, Column(DbType = "DATE(7)")]
		public DateTime? PARTEXPIRYDATE { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(40 BYTE)")]
		public string PARTEXPIRYSTATUS { get; set; }

		[JsonProperty]
		public uint? PARTLIFETIMECOUNT { get; set; }

		[JsonProperty]
		public uint? PARTLIFETIMECOUNT2 { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(40 BYTE)")]
		public string PARTLIFETIMESTATUS { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(40 BYTE)")]
		public string PARTLIFETIMESTATUS2 { get; set; }

		[JsonProperty]
		public uint? PARTQTY { get; set; }

		[JsonProperty]
		public uint? PARTRECONDITIONCOUNT { get; set; }

		[JsonProperty]
		public uint? PARTREQUESTCOUNT { get; set; }

		[JsonProperty]
		public uint? PARTUSAGECOUNT { get; set; }

		[JsonProperty]
		public uint? PARTUSAGECOUNT2 { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(40 BYTE)")]
		public string PARTUSAGESTATUS { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(40 BYTE)")]
		public string PARTUSAGESTATUS2 { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string PHYSICALLOCATIONID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string PHYSICALPOSITIONID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string PRODUCTBASEID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string PRODUCTID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string REASONID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string RESOURCEID { get; set; }

		[JsonProperty]
		public uint? RESOURCESTATE { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(30 BYTE)")]
		public string RUN { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string SETUPBASEID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string SETUPID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string STATUSID { get; set; }

		[JsonProperty, Column(DbType = "NUMBER(22)")]
		public decimal? TOTALTHRUPUTQTY { get; set; }

		[JsonProperty, Column(DbType = "NUMBER(22)")]
		public decimal? TOTALTHRUPUTQTY2 { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string UOM2ID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string UOMID { get; set; }

		[JsonProperty]
		public uint? UPDATELASTSTATUSCHANGEDATE { get; set; }

	}

}
