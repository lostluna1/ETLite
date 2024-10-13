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
	public partial class RESOURCESTATUSHISTORY {

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)", IsPrimary = true, IsNullable = false)]
		public string RESOURCESTATUSHISTORYID { get; set; }

		[JsonProperty]
		public uint? AVAILABILITY { get; set; }

		[JsonProperty]
		public uint? CDOTYPEID { get; set; }

		[JsonProperty]
		public uint? CHANGECOUNT { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(2000 BYTE)")]
		public string COMMENTS { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(36 BYTE)")]
		public string EXPORTIMPORTKEY { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string HISTORYID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string HISTORYMAINLINEID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string INTEGRATIONTXNID { get; set; }

		[JsonProperty]
		public uint? ISOEELOSSCATEGORY { get; set; }

		[JsonProperty]
		public uint? ISOLDOEELOSSCATEGORY { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string ISRECIPEID { get; set; }

		[JsonProperty, Column(DbType = "DATE(7)")]
		public DateTime? LASTSTATUSCHANGEDATE { get; set; }

		[JsonProperty, Column(DbType = "DATE(7)")]
		public DateTime? LASTSTATUSCHANGEDATEGMT { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string MFGLINEID { get; set; }

		[JsonProperty]
		public uint? OLDAVAILABILITY { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(2000 BYTE)")]
		public string OLDCOMMENTS { get; set; }

		[JsonProperty, Column(DbType = "DATE(7)")]
		public DateTime? OLDLASTACTIVITYDATE { get; set; }

		[JsonProperty, Column(DbType = "DATE(7)")]
		public DateTime? OLDLASTACTIVITYDATEGMT { get; set; }

		[JsonProperty, Column(DbType = "DATE(7)")]
		public DateTime? OLDLASTSTATUSCHANGEDATE { get; set; }

		[JsonProperty, Column(DbType = "DATE(7)")]
		public DateTime? OLDLASTSTATUSCHANGEDATEGMT { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string OLDMFGLINEID { get; set; }

		[JsonProperty, Column(DbType = "DATE(7)")]
		public DateTime? OLDPARTEXPIRYDATE { get; set; }

		[JsonProperty]
		public uint? OLDPARTQTY { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string OLDPHYSICALLOCATIONID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string OLDPHYSICALPOSITIONID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string OLDPRODUCTID { get; set; }

		[JsonProperty]
		public uint? OLDRESOURCESTATE { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string OLDRESOURCESTATUSCODEID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string OLDRESOURCESTATUSREASONCODEID { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(30 BYTE)")]
		public string OLDRUN { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string OLDSETUPID { get; set; }

		[JsonProperty]
		public uint? OLDUPDATELASTSTATUSCHANGEDATE { get; set; }

		[JsonProperty, Column(DbType = "DATE(7)")]
		public DateTime? PARTEXPIRYDATE { get; set; }

		[JsonProperty]
		public uint? PARTQTY { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string PHYSICALLOCATIONID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string PHYSICALPOSITIONID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string PRODUCTID { get; set; }

		[JsonProperty]
		public uint? RESOURCESTATE { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string RESOURCESTATUSCODEID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string RESOURCESTATUSREASONCODEID { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(30 BYTE)")]
		public string RUN { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string SETUPID { get; set; }

		[JsonProperty, Column(Name = "SS_NEWLOCATIONID", DbType = "CHAR(16 BYTE)")]
		public string SSNEWLOCATIONID { get; set; }

		[JsonProperty, Column(Name = "SS_OLDLOCATIONID", DbType = "CHAR(16 BYTE)")]
		public string SSOLDLOCATIONID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string TXNID { get; set; }

		[JsonProperty]
		public uint? UPDATELASTSTATUSCHANGEDATE { get; set; }

		[JsonProperty]
		public uint? UPDATEPARAMS { get; set; }

	}

}
