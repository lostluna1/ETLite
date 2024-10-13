﻿using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models {

	[JsonObject(MemberSerialization.OptIn), Table(Name = "RESOLVEDPERMISSIONS_TEMP", DisableSyncStructure = true)]
	public partial class RESOLVEDPERMISSIONSTEMP {

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string OBJECTINSTANCEID { get; set; }

		[JsonProperty, Column(DbType = "NUMBER(22)")]
		public decimal? OBJECTMETAID { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(255 BYTE)")]
		public string ORGANIZATIONNAME { get; set; }

		[JsonProperty, Column(DbType = "NUMBER(22)")]
		public decimal? PERMISSIONMODE { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(255 BYTE)")]
		public string PERMISSIONNAME { get; set; }

		[JsonProperty, Column(DbType = "NUMBER(22)")]
		public decimal? PERMISSIONTYPE { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(255 BYTE)")]
		public string ROLENAME { get; set; }

	}

}
