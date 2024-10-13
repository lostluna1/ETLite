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
	public partial class ISOEERAWDETAILS {

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)", IsPrimary = true, IsNullable = false)]
		public string ISOEERAWDETAILSID { get; set; }

		[JsonProperty, Column(DbType = "DATE(7)")]
		public DateTime? CALENDARDATE { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string CALENDARSHIFTID { get; set; }

		[JsonProperty]
		public uint? CDOTYPEID { get; set; }

		[JsonProperty]
		public uint? CHANGECOUNT { get; set; }

		[JsonProperty]
		public uint? CHILDCOUNT { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string CONTAINERID { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(100 BYTE)")]
		public string CONTAINERNAME { get; set; }

		[JsonProperty, Column(DbType = "DATE(7)")]
		public DateTime? CYCLESTARTGMT { get; set; }

		[JsonProperty, Column(DbType = "NUMBER(22)")]
		public decimal? CYCLETIME { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string EMPLOYEEID { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(40 BYTE)")]
		public string EMPLOYEENAME { get; set; }

		[JsonProperty, Column(DbType = "NUMBER(22)")]
		public decimal? EQUIPMENTCYCLETIMEMS { get; set; }

		[JsonProperty, Column(Name = "ES_IDENTIFIER", DbType = "VARCHAR2(100 BYTE)")]
		public string ESIDENTIFIER { get; set; }

		[JsonProperty, Column(Name = "ES_LEVELTYPE")]
		public uint? ESLEVELTYPE { get; set; }

		[JsonProperty, Column(Name = "ES_NFFDEFECTCOUNT")]
		public uint? ESNFFDEFECTCOUNT { get; set; }

		[JsonProperty, Column(Name = "ES_PCBNUMBER")]
		public uint? ESPCBNUMBER { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string FACTORYID { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(40 BYTE)")]
		public string FACTORYNAME { get; set; }

		[JsonProperty, Column(DbType = "NUMBER(22)")]
		public decimal? GOODQTY { get; set; }

		[JsonProperty, Column(DbType = "NUMBER(22)")]
		public decimal? GOODQTY2 { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string HISTORYMAINLINEID { get; set; }

		[JsonProperty, Column(DbType = "NUMBER(22)")]
		public decimal? IDEALCYCLETIME { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(30 BYTE)")]
		public string ISERPOPERATION { get; set; }

		[JsonProperty]
		public uint? ISFAILED { get; set; }

		[JsonProperty, Column(DbType = "NUMBER(22)")]
		public decimal? ISFAILEDQTY { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(36 BYTE)")]
		public string ISOEERAWDETAILSNAME { get; set; }

		[JsonProperty]
		public uint? ISOPENDEFECTCOUNT { get; set; }

		[JsonProperty, Column(DbType = "NUMBER(22)")]
		public decimal? ISQTY { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(100 BYTE)")]
		public string ISRECIPENAME { get; set; }

		[JsonProperty]
		public uint? ISREPAIREDDEFECTCOUNT { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(30 BYTE)")]
		public string ISROUTESTEPNAME { get; set; }

		[JsonProperty]
		public uint? ISTOTALDEFECTCOUNT { get; set; }

		[JsonProperty, Column(DbType = "NUMBER(22)")]
		public decimal? LOSSQTY { get; set; }

		[JsonProperty, Column(DbType = "NUMBER(22)")]
		public decimal? LOSSQTY2 { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string MFGORDERID { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(40 BYTE)")]
		public string MFGORDERNAME { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string OPERATIONID { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(40 BYTE)")]
		public string OPERATIONNAME { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(40 BYTE)")]
		public string OWNERNAME { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string PARENTID { get; set; }

		[JsonProperty, Column(DbType = "NUMBER(22)")]
		public decimal? PROCESSTIME { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string PRODUCTFAMILYID { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(40 BYTE)")]
		public string PRODUCTFAMILYNAME { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string PRODUCTID { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(100 BYTE)")]
		public string PRODUCTNAME { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(15 BYTE)")]
		public string PRODUCTREVISION { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(30 BYTE)")]
		public string QTYADJUSTREASON { get; set; }

		[JsonProperty, Column(DbType = "NUMBER(22)")]
		public decimal? QUEUETIME { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string RECIPEID { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(100 BYTE)")]
		public string RECIPENAME { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string RESOURCEFAMILYID { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(30 BYTE)")]
		public string RESOURCEFAMILYNAME { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string RESOURCEID { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(40 BYTE)")]
		public string RESOURCENAME { get; set; }

		[JsonProperty, Column(DbType = "NUMBER(22)")]
		public decimal? REWORKEDQTY { get; set; }

		[JsonProperty, Column(DbType = "NUMBER(22)")]
		public decimal? REWORKEDQTY2 { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(40 BYTE)")]
		public string REWORKREASON { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string ROUTESTEPID { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(30 BYTE)")]
		public string SHIFT { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string SPECID { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(40 BYTE)")]
		public string SPECNAME { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(15 BYTE)")]
		public string SPECREVISION { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string STARTPARENTCONTAINERID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string STEPID { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(46 BYTE)")]
		public string STEPNAME { get; set; }

		[JsonProperty]
		public uint? STEPPASS { get; set; }

		[JsonProperty, Column(DbType = "NUMBER(22)")]
		public decimal? TOTALQTY { get; set; }

		[JsonProperty, Column(DbType = "NUMBER(22)")]
		public decimal? TOTALQTY2 { get; set; }

		[JsonProperty, Column(DbType = "DATE(7)")]
		public DateTime? TXNDATE { get; set; }

		[JsonProperty, Column(DbType = "DATE(7)")]
		public DateTime? TXNDATEGMT { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(2000 BYTE)")]
		public string TXNNAME { get; set; }

		[JsonProperty]
		public uint? TXNTYPE { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(30 BYTE)")]
		public string UOM { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(30 BYTE)")]
		public string UOM2 { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string WORKFLOWID { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(40 BYTE)")]
		public string WORKFLOWNAME { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(15 BYTE)")]
		public string WORKFLOWREVISION { get; set; }

		[JsonProperty]
		public uint? WORKFLOWSTEPSEQUENCE { get; set; }

	}

}
