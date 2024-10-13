﻿using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models {

	[JsonObject(MemberSerialization.OptIn), Table(DisableSyncStructure = true)]
	public partial class RECIPELIST {

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)", IsPrimary = true, IsNullable = false)]
		public string RECIPELISTID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string CARRIERSID { get; set; }

		[JsonProperty]
		public uint? CDOTYPEID { get; set; }

		[JsonProperty]
		public uint? CHANGECOUNT { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string CHANGEHISTORYID { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(255 BYTE)")]
		public string DESCRIPTION { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(30 BYTE)")]
		public string ECO { get; set; }

		[JsonProperty]
		public uint? EXECUTIONMODE { get; set; }

		[JsonProperty, Column(DbType = "CLOB")]
		public string FILTERTAGS { get; set; }

		[JsonProperty]
		public uint? ICONID { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(4000 BYTE)")]
		public string INSTRUCTION { get; set; }

		[JsonProperty]
		public uint? ISFROZEN { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string ISIMAGEID { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(2000 BYTE)")]
		public string NOTES { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string PREREQUISITETASKLISTID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string RECIPELISTBASEID { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(4000 BYTE)")]
		public string REPORTINSTRUCTION { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(15 BYTE)")]
		public string REVISION { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string SCALESID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string SETUPACCESSID { get; set; }

		[JsonProperty]
		public uint? STATUS { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string TARGETCONTAINERLEVELID { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(255 BYTE)")]
		public string TARGETCONTAINERPLANNEDQTY { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string TARGETCONTAINERPRODUCTBASEID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string TARGETCONTAINERPRODUCTID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string TARGETCONTAINERUOMID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string WIPMSGDEFMGRID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string WORKSTATIONGROUPID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string WORKSTATIONID { get; set; }

	}

}
