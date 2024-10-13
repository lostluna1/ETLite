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
	public partial class PRODUCTFAMILY {

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)", IsPrimary = true, IsNullable = false)]
		public string PRODUCTFAMILYID { get; set; }

		[JsonProperty]
		public uint? CDOTYPEID { get; set; }

		[JsonProperty]
		public uint? CHANGECOUNT { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string CHANGESTATUSID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string CHILDCONTAINERNUMBERINGRULEID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string CONTAINERNUMBERINGRULEID { get; set; }

		[JsonProperty, Column(DbType = "NUMBER(22)")]
		public decimal? CURRENTCOST { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(255 BYTE)")]
		public string DESCRIPTION { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string DOCUMENTSETID { get; set; }

		[JsonProperty, Column(Name = "ES_CHILDSNRULEID", DbType = "CHAR(16 BYTE)")]
		public string ESCHILDSNRULEID { get; set; }

		[JsonProperty, Column(Name = "ES_PARENTSNRULEID", DbType = "CHAR(16 BYTE)")]
		public string ESPARENTSNRULEID { get; set; }

		[JsonProperty, Column(Name = "ES_SERIALNUMBERCONFIG")]
		public uint? ESSERIALNUMBERCONFIG { get; set; }

		[JsonProperty, Column(Name = "ES_SERIALNUMBERGENERATION")]
		public uint? ESSERIALNUMBERGENERATION { get; set; }

		[JsonProperty, Column(Name = "ES_SERIALNUMBERQTY")]
		public uint? ESSERIALNUMBERQTY { get; set; }

		[JsonProperty, Column(Name = "ES_STDSTARTCHILDLEVELID", DbType = "CHAR(16 BYTE)")]
		public string ESSTDSTARTCHILDLEVELID { get; set; }

		[JsonProperty, Column(Name = "ES_UNIQUESERIALNUMBERS")]
		public uint? ESUNIQUESERIALNUMBERS { get; set; }

		[JsonProperty, Column(Name = "ES_USECONTAINERNAMEFORSN")]
		public uint? ESUSECONTAINERNAMEFORSN { get; set; }

		[JsonProperty, Column(Name = "ES_USEPRODUCTIONCLIENTBOXMODE")]
		public uint? ESUSEPRODUCTIONCLIENTBOXMODE { get; set; }

		[JsonProperty, Column(DbType = "CLOB")]
		public string FILTERTAGS { get; set; }

		[JsonProperty]
		public uint? ICONID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string ISDEFAULTINVENTORYLOCATIONID { get; set; }

		[JsonProperty]
		public uint? ISFROZEN { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string ISRECIPEPLANID { get; set; }

		[JsonProperty]
		public uint? ISREGISTERCONTAINERS { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(2000 BYTE)")]
		public string NOTES { get; set; }

		[JsonProperty, Column(DbType = "NUMBER(22)")]
		public decimal? PLANNEDCOST { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(40 BYTE)")]
		public string PRODUCTFAMILYNAME { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string SAMPLINGPLANID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string SETUPACCESSID { get; set; }

		[JsonProperty, Column(DbType = "NUMBER(22)")]
		public decimal? STDCOST { get; set; }

		[JsonProperty, Column(DbType = "NUMBER(22)")]
		public decimal? STDSTARTCHILDQTY { get; set; }

		[JsonProperty, Column(DbType = "NUMBER(22)")]
		public decimal? STDSTARTCHILDQTY2 { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string STDSTARTCUSTOMERID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string STDSTARTFACTORYID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string STDSTARTLEVELID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string STDSTARTOWNERID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string STDSTARTPRIORITYCODEID { get; set; }

		[JsonProperty, Column(DbType = "NUMBER(22)")]
		public decimal? STDSTARTQTY { get; set; }

		[JsonProperty, Column(DbType = "NUMBER(22)")]
		public decimal? STDSTARTQTY2 { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string STDSTARTREASONID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string STDSTARTUOM2ID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string STDSTARTUOMID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string TRAININGREQGROUPID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string WIPMSGDEFMGRID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string WORKFLOWBASEID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string WORKFLOWID { get; set; }

	}

}
