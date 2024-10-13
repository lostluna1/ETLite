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
	public partial class HISTORYMAINLINE {

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)", IsPrimary = true, IsNullable = false)]
		public string HISTORYMAINLINEID { get; set; }

		[JsonProperty]
		public uint? APPLICATION { get; set; }

		[JsonProperty]
		public uint? BASETXNTYPE { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string BATCHID { get; set; }

		[JsonProperty]
		public uint? BINNINGINCLUDED { get; set; }

		[JsonProperty, Column(Name = "BIZ_CUSTOMERCONTAINER", DbType = "VARCHAR2(100 BYTE)")]
		public string BIZCUSTOMERCONTAINER { get; set; }

		[JsonProperty, Column(Name = "BIZ_CUSTOMERPARENTLOT", DbType = "VARCHAR2(100 BYTE)")]
		public string BIZCUSTOMERPARENTLOT { get; set; }

		[JsonProperty, Column(Name = "BIZ_DEFECTREASONID", DbType = "CHAR(16 BYTE)")]
		public string BIZDEFECTREASONID { get; set; }

		[JsonProperty, Column(Name = "BIZ_ISPASS")]
		public uint? BIZISPASS { get; set; }

		[JsonProperty, Column(Name = "BIZ_NGCONTAINER", DbType = "VARCHAR2(255 BYTE)")]
		public string BIZNGCONTAINER { get; set; }

		[JsonProperty]
		public uint? BONUSINCLUDED { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string CALENDARSHIFTID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string CARRIERID { get; set; }

		[JsonProperty]
		public uint? CDOTYPEID { get; set; }

		[JsonProperty]
		public uint? CHANGECOUNT { get; set; }

		[JsonProperty]
		public uint? CHILDCOUNT { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(36 BYTE)")]
		public string CIOMESSAGEID { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(36 BYTE)")]
		public string CIOMESSAGEIDOUTBOUND { get; set; }

		[JsonProperty]
		public uint? CLIENT { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(255 BYTE)")]
		public string COMMENTS { get; set; }

		[JsonProperty]
		public uint? COMPOUNDTXNTYPE { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string COMPUTATIONHISTORYID { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(255 BYTE)")]
		public string COMPUTERNAME { get; set; }

		[JsonProperty]
		public uint? CONTAINERCHANGECOUNT { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string CONTAINERID { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(100 BYTE)")]
		public string CONTAINERNAME { get; set; }

		[JsonProperty]
		public uint? DEFECTINCLUDED { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string EMPLOYEEID { get; set; }

		[JsonProperty, Column(Name = "ES_RECIPEID", DbType = "VARCHAR2(255 BYTE)")]
		public string ESRECIPEID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string ESIGREQUIREMENTID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string FACTORYID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string HISTORYID { get; set; }

		[JsonProperty]
		public uint? ICONID { get; set; }

		[JsonProperty]
		public uint? IMPLICIT { get; set; }

		[JsonProperty]
		public uint? INREWORK { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string INTEGRATIONTXNID { get; set; }

		[JsonProperty]
		public uint? ISFAILED { get; set; }

		[JsonProperty, Column(DbType = "DATE(7)")]
		public DateTime? LASTMOVEDATE { get; set; }

		[JsonProperty, Column(DbType = "DATE(7)")]
		public DateTime? LASTMOVEDATEGMT { get; set; }

		[JsonProperty, Column(DbType = "DATE(7)")]
		public DateTime? LASTMOVEOUTDATE { get; set; }

		[JsonProperty, Column(DbType = "DATE(7)")]
		public DateTime? LASTMOVEOUTDATEGMT { get; set; }

		[JsonProperty]
		public uint? LOCALREWORKINCLUDED { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string LOGINID { get; set; }

		[JsonProperty]
		public uint? LOSSINCLUDED { get; set; }

		[JsonProperty, Column(DbType = "DATE(7)")]
		public DateTime? MFGDATE { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string MFGPROCESSOVERRIDESID { get; set; }

		[JsonProperty, Column(DbType = "DATE(7)")]
		public DateTime? MOVEINDATE { get; set; }

		[JsonProperty, Column(DbType = "DATE(7)")]
		public DateTime? MOVEINDATEGMT { get; set; }

		[JsonProperty, Column(DbType = "NUMBER(22)")]
		public decimal? MOVEINQTY { get; set; }

		[JsonProperty, Column(DbType = "NUMBER(22)")]
		public decimal? MOVEINQTY2 { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string OPERATIONID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string OWNERID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string PARAMETRICDETAILID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string PARENTCONTAINERID { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(100 BYTE)")]
		public string PARENTCONTAINERNAME { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string PRODUCTID { get; set; }

		[JsonProperty, Column(DbType = "NUMBER(22)")]
		public decimal? QTY { get; set; }

		[JsonProperty, Column(DbType = "NUMBER(22)")]
		public decimal? QTY2 { get; set; }

		[JsonProperty]
		public uint? QUALITYESIGCONFIRMED { get; set; }

		[JsonProperty]
		public uint? RESOURCEAVAILABILITY { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string RESOURCEID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string RESOURCESTATUSCODEID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string RESOURCESTATUSREASONID { get; set; }

		[JsonProperty]
		public uint? REVERSALSTATUS { get; set; }

		[JsonProperty]
		public uint? SERVER { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(255 BYTE)")]
		public string SERVERNAME { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(30 BYTE)")]
		public string SHIFTNAME { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string SPECID { get; set; }

		[JsonProperty]
		public uint? STATUS { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string STEPENTRYTXNID { get; set; }

		[JsonProperty]
		public uint? STEPPASS { get; set; }

		[JsonProperty, Column(DbType = "DATE(7)")]
		public DateTime? SYSTEMDATE { get; set; }

		[JsonProperty, Column(DbType = "DATE(7)")]
		public DateTime? SYSTEMDATEGMT { get; set; }

		[JsonProperty, Column(DbType = "NUMBER(22)")]
		public decimal? TOQTY { get; set; }

		[JsonProperty, Column(DbType = "NUMBER(22)")]
		public decimal? TOQTY2 { get; set; }

		[JsonProperty, Column(DbType = "DATE(7)")]
		public DateTime? TXNDATE { get; set; }

		[JsonProperty, Column(DbType = "DATE(7)")]
		public DateTime? TXNDATEGMT { get; set; }

		[JsonProperty]
		public uint? TXNHISTORYSEQUENCE { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string TXNID { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(32 BYTE)")]
		public string TXNPARENTTYPENAME { get; set; }

		[JsonProperty]
		public uint? TXNSEQUENCE { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(32 BYTE)")]
		public string TXNSERVICENAME { get; set; }

		[JsonProperty]
		public uint? TXNSERVICESEQUENCE { get; set; }

		[JsonProperty]
		public uint? TXNTYPE { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(32 BYTE)")]
		public string TXNTYPENAME { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string USERID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string WORKFLOWSTEPID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string WORKSTATIONID { get; set; }

	}

}
