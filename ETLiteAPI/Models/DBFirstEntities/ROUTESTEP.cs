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
	public partial class ROUTESTEP {

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)", IsPrimary = true, IsNullable = false)]
		public string ROUTESTEPID { get; set; }

		[JsonProperty, Column(Name = "BIZ_ACTIVETIME", DbType = "NUMBER(22)")]
		public decimal? BIZACTIVETIME { get; set; }

		[JsonProperty, Column(Name = "BIZ_ATUOMID", DbType = "CHAR(16 BYTE)")]
		public string BIZATUOMID { get; set; }

		[JsonProperty, Column(Name = "BIZ_BASEUOMID", DbType = "CHAR(16 BYTE)")]
		public string BIZBASEUOMID { get; set; }

		[JsonProperty, Column(Name = "BIZ_EQTTIME", DbType = "NUMBER(22)")]
		public decimal? BIZEQTTIME { get; set; }

		[JsonProperty, Column(Name = "BIZ_ETUOMID", DbType = "CHAR(16 BYTE)")]
		public string BIZETUOMID { get; set; }

		[JsonProperty, Column(Name = "BIZ_MANTIME", DbType = "NUMBER(22)")]
		public decimal? BIZMANTIME { get; set; }

		[JsonProperty, Column(Name = "BIZ_MTUOMID", DbType = "CHAR(16 BYTE)")]
		public string BIZMTUOMID { get; set; }

		[JsonProperty, Column(Name = "BIZ_PREPARETIME", DbType = "NUMBER(22)")]
		public decimal? BIZPREPARETIME { get; set; }

		[JsonProperty, Column(Name = "BIZ_PRETUOMID", DbType = "CHAR(16 BYTE)")]
		public string BIZPRETUOMID { get; set; }

		[JsonProperty, Column(Name = "BIZ_PRODCOSTSTIME", DbType = "NUMBER(22)")]
		public decimal? BIZPRODCOSTSTIME { get; set; }

		[JsonProperty, Column(Name = "BIZ_PROTUOMID", DbType = "CHAR(16 BYTE)")]
		public string BIZPROTUOMID { get; set; }

		[JsonProperty, Column(Name = "BIZ_STAQTY", DbType = "NUMBER(22)")]
		public decimal? BIZSTAQTY { get; set; }

		[JsonProperty, Column(Name = "BIZ_WORKCENTER", DbType = "VARCHAR2(40 BYTE)")]
		public string BIZWORKCENTER { get; set; }

		[JsonProperty]
		public uint? CDOTYPEID { get; set; }

		[JsonProperty]
		public uint? CHANGECOUNT { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(255 BYTE)")]
		public string DESCRIPTION { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(30 BYTE)")]
		public string ERPOPERATION { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string ERPROUTEID { get; set; }

		[JsonProperty, Column(Name = "ES_STARTVIRTUALSN")]
		public uint? ESSTARTVIRTUALSN { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(36 BYTE)")]
		public string EXPORTIMPORTKEY { get; set; }

		[JsonProperty, Column(DbType = "NUMBER(22)")]
		public decimal? ISDURATIONPERUNIT { get; set; }

		[JsonProperty]
		public uint? ISFROZEN { get; set; }

		[JsonProperty]
		public uint? ISRUNRATEOPTION { get; set; }

		[JsonProperty, Column(DbType = "NUMBER(22)")]
		public decimal? ISSETUPTIME { get; set; }

		[JsonProperty, Column(DbType = "DATE(7)")]
		public DateTime? ISSMTDATE { get; set; }

		[JsonProperty]
		public uint? ISSMTSIDE { get; set; }

		[JsonProperty, Column(DbType = "NUMBER(22)")]
		public decimal? ISTIMEPERBATCH { get; set; }

		[JsonProperty, Column(DbType = "NUMBER(22)")]
		public decimal? ISTRANSFERQTY { get; set; }

		[JsonProperty]
		public uint? ISTRANSFERTYPE { get; set; }

		[JsonProperty, Column(DbType = "NUMBER(22)")]
		public decimal? ISUNITSPERHOUR { get; set; }

		[JsonProperty, Column(DbType = "NUMBER(22)")]
		public decimal? ISUNSCHEDULEDTIME { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(40 BYTE)")]
		public string NAME { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(30 BYTE)")]
		public string SCHEDULINGOPERATION { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(30 BYTE)")]
		public string SEQUENCE { get; set; }

	}

}
