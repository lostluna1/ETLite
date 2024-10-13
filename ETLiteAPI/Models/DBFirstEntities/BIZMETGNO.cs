using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models {

	[JsonObject(MemberSerialization.OptIn), Table(Name = "BIZ_METGNO", DisableSyncStructure = true)]
	public partial class BIZMETGNO {

		[JsonProperty, Column(Name = "BIZ_METGNOID", DbType = "CHAR(16 BYTE)", IsPrimary = true, IsNullable = false)]
		public string BIZMETGNOID { get; set; }

		[JsonProperty, Column(Name = "BIZ_METGNONAME", DbType = "VARCHAR2(64 BYTE)")]
		public string BIZMETGNONAME { get; set; }

		[JsonProperty, Column(Name = "BU_CODEID", DbType = "CHAR(16 BYTE)")]
		public string BUCODEID { get; set; }

		[JsonProperty]
		public uint? CDOTYPEID { get; set; }

		[JsonProperty]
		public uint? CHANGECOUNT { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string CHANGEHISTORYID { get; set; }

		[JsonProperty, Column(Name = "CREATED_BY", DbType = "VARCHAR2(40 BYTE)")]
		public string CREATEDBY { get; set; }

		[JsonProperty, Column(Name = "CREATION_DATE", DbType = "DATE(7)")]
		public DateTime? CREATIONDATE { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(2000 BYTE)")]
		public string DESCRIPTION { get; set; }

		[JsonProperty, Column(Name = "ENABLE_FLAG", DbType = "VARCHAR2(40 BYTE)")]
		public string ENABLEFLAG { get; set; }

		[JsonProperty, Column(Name = "EQUIPMENT_PARA", DbType = "VARCHAR2(255 BYTE)")]
		public string EQUIPMENTPARA { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(255 BYTE)")]
		public string FILTERTAGS { get; set; }

		[JsonProperty, Column(Name = "FSS_CODEID", DbType = "CHAR(16 BYTE)")]
		public string FSSCODEID { get; set; }

		[JsonProperty]
		public uint? ICONID { get; set; }

		[JsonProperty]
		public uint? ISFROZEN { get; set; }

		[JsonProperty, Column(Name = "LAST_UPDATE_DATE", DbType = "DATE(7)")]
		public DateTime? LASTUPDATEDATE { get; set; }

		[JsonProperty, Column(Name = "LAST_UPDATED_BY", DbType = "VARCHAR2(40 BYTE)")]
		public string LASTUPDATEDBY { get; set; }

		[JsonProperty, Column(Name = "MOLD_TYPEID", DbType = "CHAR(16 BYTE)")]
		public string MOLDTYPEID { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(2000 BYTE)")]
		public string NOTES { get; set; }

		[JsonProperty, Column(Name = "PLANT_CODEID", DbType = "CHAR(16 BYTE)")]
		public string PLANTCODEID { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(4000 BYTE)")]
		public string REMARK { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string SETUPACCESSID { get; set; }

		[JsonProperty, Column(Name = "TER_ITEM_CODEID", DbType = "CHAR(16 BYTE)")]
		public string TERITEMCODEID { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(40 BYTE)")]
		public string ZAUTH { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(64 BYTE)")]
		public string ZAWG { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(40 BYTE)")]
		public string ZDZBM { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(40 BYTE)")]
		public string ZDZCS { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(255 BYTE)")]
		public string ZFORMAT { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(40 BYTE)")]
		public string ZGFBH { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(40 BYTE)")]
		public string ZHBMK { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(40 BYTE)")]
		public string ZHBXH { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(40 BYTE)")]
		public string ZJX { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(40 BYTE)")]
		public string ZJXPD { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(40 BYTE)")]
		public string ZMM2 { get; set; }

		[JsonProperty, Column(DbType = "NUMBER(22)")]
		public decimal? ZNMGF { get; set; }

		[JsonProperty, Column(DbType = "NUMBER(22)")]
		public decimal? ZNMGT { get; set; }

		[JsonProperty, Column(DbType = "NUMBER(22)")]
		public decimal? ZNMHD { get; set; }

		[JsonProperty, Column(DbType = "NUMBER(22)")]
		public decimal? ZNMKD { get; set; }

		[JsonProperty, Column(DbType = "NUMBER(22)")]
		public decimal? ZNMKF { get; set; }

		[JsonProperty, Column(DbType = "NUMBER(22)")]
		public decimal? ZNMKT { get; set; }

		[JsonProperty, Column(DbType = "NUMBER(22)")]
		public decimal? ZNXHD { get; set; }

		[JsonProperty, Column(DbType = "NUMBER(22)")]
		public decimal? ZNXKD { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(40 BYTE)")]
		public string ZOD { get; set; }

		[JsonProperty, Column(DbType = "NUMBER(22)")]
		public decimal? ZSCLL { get; set; }

		[JsonProperty, Column(DbType = "NUMBER(22)")]
		public decimal? ZTP01 { get; set; }

		[JsonProperty, Column(DbType = "NUMBER(22)")]
		public decimal? ZTP02 { get; set; }

		[JsonProperty, Column(DbType = "NUMBER(22)")]
		public decimal? ZTP03 { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(40 BYTE)")]
		public string ZVISN { get; set; }

		[JsonProperty, Column(DbType = "NUMBER(22)")]
		public decimal? ZWMGF { get; set; }

		[JsonProperty, Column(DbType = "NUMBER(22)")]
		public decimal? ZWMGT { get; set; }

		[JsonProperty, Column(DbType = "NUMBER(22)")]
		public decimal? ZWMHD { get; set; }

		[JsonProperty, Column(DbType = "NUMBER(22)")]
		public decimal? ZWMKD { get; set; }

		[JsonProperty, Column(DbType = "NUMBER(22)")]
		public decimal? ZWMKF { get; set; }

		[JsonProperty, Column(DbType = "NUMBER(22)")]
		public decimal? ZWMKT { get; set; }

		[JsonProperty, Column(DbType = "NUMBER(22)")]
		public decimal? ZWXHD { get; set; }

		[JsonProperty, Column(DbType = "NUMBER(22)")]
		public decimal? ZWXKD { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(40 BYTE)")]
		public string ZYBWZ { get; set; }

	}

}
