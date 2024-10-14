using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class BIZMFGCHECKLIST {

		[JsonProperty, Column(Name = "BIZ_MFGCHECKLISTID", DbType = "CHAR(16 BYTE)", IsPrimary = true, IsNullable = false)]
		public string BIZMFGCHECKLISTID { get; set; }

		[JsonProperty, Column(Name = "BIZ_COMPLETEDATE", DbType = "DATE(7)")]
		public DateTime? BIZCOMPLETEDATE { get; set; }

		[JsonProperty, Column(Name = "BIZ_CONFIRMDATE", DbType = "DATE(7)")]
		public DateTime? BIZCONFIRMDATE { get; set; }

		[JsonProperty, Column(Name = "BIZ_CREATEDATE", DbType = "DATE(7)")]
		public DateTime? BIZCREATEDATE { get; set; }

		[JsonProperty, Column(Name = "BIZ_CREATEEMPLOYEEID", DbType = "CHAR(16 BYTE)")]
		public string BIZCREATEEMPLOYEEID { get; set; }

		[JsonProperty, Column(Name = "BIZ_ISCONFIRM")]
		public uint? BIZISCONFIRM { get; set; }

		[JsonProperty, Column(Name = "BIZ_MFGCHECKLISTNAME", DbType = "VARCHAR2(256 BYTE)")]
		public string BIZMFGCHECKLISTNAME { get; set; }

		[JsonProperty, Column(Name = "BIZ_PRINCIPALID", DbType = "CHAR(16 BYTE)")]
		public string BIZPRINCIPALID { get; set; }

		[JsonProperty]
		public uint? CDOTYPEID { get; set; }

		[JsonProperty]
		public uint? CHANGECOUNT { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string CHANGEHISTORYID { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(1000 BYTE)")]
		public string DATANAME { get; set; }

		[JsonProperty]
		public uint? DATATYPE { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(1000 BYTE)")]
		public string DATAVALUE { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(2000 BYTE)")]
		public string DESCRIPTION { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(255 BYTE)")]
		public string FILTERTAGS { get; set; }

		[JsonProperty]
		public uint? ICONID { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(1000 BYTE)")]
		public string IMPROVETTHESITUATION { get; set; }

		[JsonProperty]
		public uint? ISFROZEN { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string MFGLINEID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string MFGORDERID { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(2000 BYTE)")]
		public string NOTES { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string PRODUCTID { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(30 BYTE)")]
		public string PRODUCTIONTYPE { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(1000 BYTE)")]
		public string REMARK { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string SETUPACCESSID { get; set; }

		[JsonProperty]
		public uint? STATUSDETERMINATION { get; set; }

	}

}
