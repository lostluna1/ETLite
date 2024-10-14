﻿using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class BIZPRODUCTLIST {

		[JsonProperty, Column(Name = "BIZ_PRODUCTLISTID", DbType = "CHAR(16 BYTE)", IsPrimary = true, IsNullable = false)]
		public string BIZPRODUCTLISTID { get; set; }

		[JsonProperty, Column(Name = "BIZ_MODELMAPPRODUCTID", DbType = "CHAR(16 BYTE)")]
		public string BIZMODELMAPPRODUCTID { get; set; }

		[JsonProperty, Column(Name = "BIZ_PRODUCTLISTNAME", DbType = "VARCHAR2(36 BYTE)")]
		public string BIZPRODUCTLISTNAME { get; set; }

		[JsonProperty]
		public uint? CDOTYPEID { get; set; }

		[JsonProperty]
		public uint? CHANGECOUNT { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string CUSTOMERID { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(2000 BYTE)")]
		public string DESCRIPTION { get; set; }

		[JsonProperty]
		public uint? ENABLE { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(40 BYTE)")]
		public string EOL { get; set; }

		[JsonProperty]
		public uint? ISFROZEN { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string PRODUCTID { get; set; }

	}

}
