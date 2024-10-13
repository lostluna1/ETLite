using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models {

	[JsonObject(MemberSerialization.OptIn), Table(Name = "RV_COMPONENTREMOVEDETAILS", DisableSyncStructure = true)]
	public partial class RVCOMPONENTREMOVEDETAILS {

		[JsonProperty, Column(DbType = "NUMBER(22)")]
		public decimal? ACTUALQTYISSUED { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string COMPONENTISSUEHISTORYID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string COMPONENTREMOVEHISTORYID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string COMPONENTREPLACEHISTORYID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)", IsNullable = false)]
		public string CONTAINERID { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(100 BYTE)")]
		public string CONTAINERNAME { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string EMPLOYEEID { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(30 BYTE)")]
		public string EMPLOYEENAME { get; set; }

		[JsonProperty, Column(Name = "ES_FROMLOT2", DbType = "VARCHAR2(255 BYTE)")]
		public string ESFROMLOT2 { get; set; }

		[JsonProperty, Column(Name = "ES_FROMLOT3", DbType = "VARCHAR2(255 BYTE)")]
		public string ESFROMLOT3 { get; set; }

		[JsonProperty, Column(Name = "ES_PCBNUMBER")]
		public uint? ESPCBNUMBER { get; set; }

		[JsonProperty, Column(Name = "ES_PRIMARYSERIALNUMBER", DbType = "VARCHAR2(100 BYTE)")]
		public string ESPRIMARYSERIALNUMBER { get; set; }

		[JsonProperty, Column(Name = "ES_SERIALNUMBER2", DbType = "VARCHAR2(100 BYTE)")]
		public string ESSERIALNUMBER2 { get; set; }

		[JsonProperty, Column(Name = "ES_SERIALNUMBER3", DbType = "VARCHAR2(100 BYTE)")]
		public string ESSERIALNUMBER3 { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string FROMBATCHID { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(100 BYTE)")]
		public string FROMBATCHNAME { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string FROMCONTAINERID { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(100 BYTE)")]
		public string FROMCONTAINERNAME { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(255 BYTE)")]
		public string FROMLOT { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(100 BYTE)")]
		public string FROMPRIMARYSERIALNUMBER { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(30 BYTE)")]
		public string FROMSTOCKPOINT { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(100 BYTE)")]
		public string IDENTIFIER { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)", IsNullable = false)]
		public string ISSUEACTUALSHISTORYID { get; set; }

		[JsonProperty]
		public uint? ISSUECONTROL { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string ISSUEHISTORYDETAILID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string ISSUEHISTORYMAINLINEID { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(32 BYTE)")]
		public string ISSUETXN { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string PARENTCONTAINERID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string PRODUCTID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string PRODUCTMATERIALLISTITEMID { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(100 BYTE)")]
		public string PRODUCTNAME { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(25 BYTE)")]
		public string PRODUCTREVISION { get; set; }

		[JsonProperty, Column(DbType = "NUMBER(22)")]
		public decimal? QTY { get; set; }

		[JsonProperty, Column(DbType = "NUMBER(22)")]
		public decimal? QTYREMOVED { get; set; }

		[JsonProperty, Column(DbType = "NUMBER(22)")]
		public decimal? QTYREQUIRED { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(30 BYTE)")]
		public string REFERENCEDESIGNATOR { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string REMOVALREASONID { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(40 BYTE)")]
		public string REMOVALREASONNAME { get; set; }

		[JsonProperty, Column(DbType = "DATE(7)")]
		public DateTime? REMOVEDATE { get; set; }

		[JsonProperty, Column(DbType = "DATE(7)")]
		public DateTime? REMOVEDATEGMT { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string REMOVEHISTORYMAINLINEID { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(40 BYTE)")]
		public string REMOVEREASON { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(32 BYTE)")]
		public string REMOVETXN { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string REPLACEHISTORYMAINLINEID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string REPLACEID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string REPLACEREASONID { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(40 BYTE)")]
		public string REPLACEREASONNAME { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(32 BYTE)")]
		public string REPLACETXN { get; set; }

		[JsonProperty, Column(DbType = "NUMBER(22)")]
		public decimal? RMACTUALQTYISSUED { get; set; }

		[JsonProperty, Column(Name = "RMES_FROMLOT2", DbType = "VARCHAR2(255 BYTE)")]
		public string RMESFROMLOT2 { get; set; }

		[JsonProperty, Column(Name = "RMES_FROMLOT3", DbType = "VARCHAR2(255 BYTE)")]
		public string RMESFROMLOT3 { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string RMFROMBATCHID { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(100 BYTE)")]
		public string RMFROMBATCHNAME { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string RMFROMCONTAINERID { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(100 BYTE)")]
		public string RMFROMCONTAINERNAME { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(255 BYTE)")]
		public string RMFROMLOT { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(100 BYTE)")]
		public string RMFROMPRIMARYSERIALNUMBER { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(30 BYTE)")]
		public string RMFROMSTOCKPOINT { get; set; }

		[JsonProperty]
		public uint? RMISSUECONTROL { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string RMPRODUCTID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string RMPRODUCTMATERIALLISTITEMID { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(100 BYTE)")]
		public string RMPRODUCTNAME { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(25 BYTE)")]
		public string RMPRODUCTREVISION { get; set; }

		[JsonProperty, Column(DbType = "NUMBER(22)")]
		public decimal? RMQTY { get; set; }

		[JsonProperty, Column(DbType = "NUMBER(22)")]
		public decimal? RMQTYREQUIRED { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(30 BYTE)")]
		public string RMREFERENCEDESIGNATOR { get; set; }

		[JsonProperty, Column(DbType = "DATE(7)")]
		public DateTime? SYSTEMDATE { get; set; }

		[JsonProperty, Column(DbType = "DATE(7)")]
		public DateTime? SYSTEMDATEGMT { get; set; }

		[JsonProperty, Column(DbType = "DATE(7)")]
		public DateTime? TXNDATE { get; set; }

		[JsonProperty, Column(DbType = "DATE(7)")]
		public DateTime? TXNDATEGMT { get; set; }

		[JsonProperty, Column(DbType = "DATE(7)")]
		public DateTime? TXNDATEISSUE { get; set; }

		[JsonProperty, Column(DbType = "DATE(7)")]
		public DateTime? TXNDATEREMOVE { get; set; }

		[JsonProperty, Column(DbType = "DATE(7)")]
		public DateTime? TXNDATEREPLACE { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(46 BYTE)")]
		public string WORKFLOWSTEPNAME { get; set; }

	}

}
