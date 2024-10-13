using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models {

	[JsonObject(MemberSerialization.OptIn), Table(Name = "BIZ_WIREPOSTION", DisableSyncStructure = true)]
	public partial class BIZWIREPOSTION {

		[JsonProperty, Column(Name = "BIZ_WIREPOSTIONID", DbType = "CHAR(16 BYTE)", IsPrimary = true, IsNullable = false)]
		public string BIZWIREPOSTIONID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string BASEOBJECTID { get; set; }

		[JsonProperty, Column(Name = "BIZ_WIREPOSTIONNAME", DbType = "VARCHAR2(36 BYTE)")]
		public string BIZWIREPOSTIONNAME { get; set; }

		[JsonProperty]
		public uint? CDOTYPEID { get; set; }

		[JsonProperty]
		public uint? CHANGECOUNT { get; set; }

		[JsonProperty, Column(DbType = "NUMBER(22)")]
		public decimal? CONDUCTOROD { get; set; }

		[JsonProperty, Column(DbType = "NUMBER(22)")]
		public decimal? CONDUCTORSA { get; set; }

		[JsonProperty, Column(DbType = "NUMBER(22)")]
		public decimal? CUTTINGLENGTH { get; set; }

		[JsonProperty]
		public uint? ISFROZEN { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(40 BYTE)")]
		public string LAYLENGTH { get; set; }

		[JsonProperty, Column(DbType = "NUMBER(22)")]
		public decimal? NEGATIVETOLERANCE { get; set; }

		[JsonProperty, Column(DbType = "NUMBER(22)")]
		public decimal? POSITIVETOLERANCE { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(255 BYTE)")]
		public string PRINTINGCONTENT { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(2000 BYTE)")]
		public string REMARK { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(100 BYTE)")]
		public string SPECIFICATIONCODE { get; set; }

		[JsonProperty, Column(DbType = "NUMBER(22)")]
		public decimal? TWISTEDLENGTH { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(30 BYTE)")]
		public string WIRECOLOR { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(40 BYTE)")]
		public string WIREGROUPID { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(40 BYTE)")]
		public string WIRENO { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string WIREPRODUCTID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string WIRERODPRODUCTID { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(40 BYTE)")]
		public string WIRESPECIFICATIONS { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string WORKFLOWID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string XENGTOOLFAMILYID { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(255 BYTE)")]
		public string XFIRSTCROSSMATERIAL { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(255 BYTE)")]
		public string XMERGECRIMPING { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(40 BYTE)")]
		public string XMERGINGID { get; set; }

		[JsonProperty]
		public uint? XMERGINGNO { get; set; }

		[JsonProperty, Column(DbType = "NUMBER(22)")]
		public decimal? XPCBELECPOTPEELINGLENGTH { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(255 BYTE)")]
		public string XPOSTPROCESSING { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(100 BYTE)")]
		public string XQUOTATIONWPFPLUG { get; set; }

		[JsonProperty, Column(DbType = "NUMBER(22)")]
		public decimal? XROUNDWIREPEELINGLENGTH { get; set; }

		[JsonProperty, Column(DbType = "NUMBER(22)")]
		public decimal? XRWPEELINGLENGTHNTOLERENCE { get; set; }

		[JsonProperty, Column(DbType = "NUMBER(22)")]
		public decimal? XRWPEELINGLENGTHPTOLERENCE { get; set; }

		[JsonProperty, Column(DbType = "NUMBER(22)")]
		public decimal? XSPLICEPEELINGLENGTH { get; set; }

		[JsonProperty, Column(DbType = "NUMBER(22)")]
		public decimal? XSPOTPLATINGTINPEELINGLENGTH { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(40 BYTE)")]
		public string XTERMINALPOSITON { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string XTERMINALPRODUCTID { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(40 BYTE)")]
		public string XTERMINALSPECIFICATIONS { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(255 BYTE)")]
		public string XTERMINALSPLICE { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(30 BYTE)")]
		public string XUSAGEMERGINGID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string XWPFPLUGPRODUCTID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string YENGTOOLFAMILYID { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(255 BYTE)")]
		public string YFIRSTCROSSMATERIAL { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(255 BYTE)")]
		public string YMERGECRIMPING { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(40 BYTE)")]
		public string YMERGINGID { get; set; }

		[JsonProperty]
		public uint? YMERGINGNO { get; set; }

		[JsonProperty, Column(DbType = "NUMBER(22)")]
		public decimal? YPCBELECPOTPEELINGLENGTH { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(255 BYTE)")]
		public string YPOSTPROCESSING { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(100 BYTE)")]
		public string YQUOTATIONWPFPLUG { get; set; }

		[JsonProperty, Column(DbType = "NUMBER(22)")]
		public decimal? YROUNDWIREPEELINGLENGTH { get; set; }

		[JsonProperty, Column(DbType = "NUMBER(22)")]
		public decimal? YRWPEELINGLENGTHNTOLERENCE { get; set; }

		[JsonProperty, Column(DbType = "NUMBER(22)")]
		public decimal? YRWPEELINGLENGTHPTOLERENCE { get; set; }

		[JsonProperty, Column(DbType = "NUMBER(22)")]
		public decimal? YSPLICEPEELINGLENGTH { get; set; }

		[JsonProperty, Column(DbType = "NUMBER(22)")]
		public decimal? YSPOTPLATINGTINPEELINGLENGTH { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(30 BYTE)")]
		public string YTERMINALPOSITON { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string YTERMINALPRODUCTID { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(40 BYTE)")]
		public string YTERMINALSPECIFICATIONS { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(255 BYTE)")]
		public string YTERMINALSPLICE { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(40 BYTE)")]
		public string YUSAGEMERGINGID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string YWPFPLUGPRODUCTID { get; set; }

	}

}
