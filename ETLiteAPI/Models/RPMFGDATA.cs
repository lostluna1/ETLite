using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models {

	[JsonObject(MemberSerialization.OptIn), Table(Name = "RP_MFGDATA", DisableSyncStructure = true)]
	public partial class RPMFGDATA {

		[JsonProperty, Column(DbType = "NUMBER(22)")]
		public decimal? ACHIEVEMENT { get; set; }

		[JsonProperty, Column(DbType = "NUMBER(22)")]
		public decimal? ACTUALQTY { get; set; }

		[JsonProperty, Column(Name = "ACUTUAL_MANPOWER", DbType = "NUMBER(22)")]
		public decimal? ACUTUALMANPOWER { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(30 BYTE)")]
		public string BASEUOM { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(2000 BYTE)")]
		public string BDDESC { get; set; }

		[JsonProperty, Column(Name = "BIZ_ACTIVETIME", DbType = "NUMBER(22)")]
		public decimal? BIZACTIVETIME { get; set; }

		[JsonProperty, Column(Name = "BIZ_ATUOMID", DbType = "CHAR(16 BYTE)")]
		public string BIZATUOMID { get; set; }

		[JsonProperty, Column(Name = "BIZ_BUNAME", DbType = "VARCHAR2(40 BYTE)")]
		public string BIZBUNAME { get; set; }

		[JsonProperty, Column(Name = "BIZ_DEPTNAME", DbType = "VARCHAR2(256 BYTE)")]
		public string BIZDEPTNAME { get; set; }

		[JsonProperty, Column(Name = "BIZ_EQTTIME", DbType = "NUMBER(22)")]
		public decimal? BIZEQTTIME { get; set; }

		[JsonProperty, Column(Name = "BIZ_MANTIME", DbType = "NUMBER(22)")]
		public decimal? BIZMANTIME { get; set; }

		[JsonProperty, Column(Name = "BIZ_PREPARETIME", DbType = "NUMBER(22)")]
		public decimal? BIZPREPARETIME { get; set; }

		[JsonProperty, Column(Name = "BIZ_PRODCOSTSTIME", DbType = "NUMBER(22)")]
		public decimal? BIZPRODCOSTSTIME { get; set; }

		[JsonProperty, Column(Name = "BIZ_STAQTY", DbType = "NUMBER(22)")]
		public decimal? BIZSTAQTY { get; set; }

		[JsonProperty, Column(Name = "BIZ_WORKCENTER", DbType = "VARCHAR2(40 BYTE)")]
		public string BIZWORKCENTER { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(255 BYTE)")]
		public string BUDESC { get; set; }

		[JsonProperty, Column(DbType = "DATE(7)")]
		public DateTime? CALENDARDAY { get; set; }

		[JsonProperty, Column(DbType = "DATE(7)")]
		public DateTime? CREATETIME { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(255 BYTE)")]
		public string CTODESC { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(40 BYTE)")]
		public string CUSTOMERNAME { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(255 BYTE)")]
		public string DESCRIPTION { get; set; }

		[JsonProperty, Column(DbType = "NUMBER(22)")]
		public decimal? EFFCIENCY { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(30 BYTE)")]
		public string EMPLOYEENAME { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(30 BYTE)")]
		public string ERPOPERATION { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(30 BYTE)")]
		public string ERPROUTENAME { get; set; }

		[JsonProperty, Column(Name = "ES_STARTVIRTUALSN")]
		public uint? ESSTARTVIRTUALSN { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(30 BYTE)")]
		public string ETUOM { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(30 BYTE)")]
		public string FACTORY { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(255 BYTE)")]
		public string FULLNAME { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(255 BYTE)")]
		public string LINEDESC { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(40 BYTE)")]
		public string MFGLINENAME { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(30 BYTE)")]
		public string MFGORDERNAME { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(30 BYTE)")]
		public string MTUOM { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(40 BYTE)")]
		public string NAME { get; set; }

		[JsonProperty, Column(DbType = "NUMBER(22)")]
		public decimal? NGQTY { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(30 BYTE)")]
		public string ORDERSTATUSNAME { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(30 BYTE)")]
		public string ORDERTYPENAME { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(255 BYTE)")]
		public string OSDESC { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(255 BYTE)")]
		public string PBDESC { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(255 BYTE)")]
		public string PFDESC { get; set; }

		[JsonProperty, Column(DbType = "DATE(7)")]
		public DateTime? PLANNEDCOMPLETIONDATE { get; set; }

		[JsonProperty, Column(DbType = "DATE(7)")]
		public DateTime? PLANNEDSTARTDATE { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(30 BYTE)")]
		public string PREUOM { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(40 BYTE)")]
		public string PRODUCTFAMILYNAME { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(100 BYTE)")]
		public string PRODUCTNAME { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(40 BYTE)")]
		public string PRODUCTTYPENAME { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(30 BYTE)")]
		public string PROUOM { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(255 BYTE)")]
		public string PTDESC { get; set; }

		[JsonProperty, Column(DbType = "NUMBER(22)")]
		public decimal? QTY { get; set; }

		[JsonProperty, Column(DbType = "DATE(7)")]
		public DateTime? RELEASEDATE { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(30 BYTE)")]
		public string SEQUENCE { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(255 BYTE)")]
		public string SFTDESC { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(30 BYTE)")]
		public string SHIFTNAME { get; set; }

		[JsonProperty, Column(DbType = "NUMBER(22)")]
		public decimal? TARGETQTY { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(30 BYTE)")]
		public string UOMNAME { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(255 BYTE)")]
		public string WODESC { get; set; }

		[JsonProperty, Column(DbType = "NUMBER(22)")]
		public decimal? YIELD { get; set; }

	}

}
