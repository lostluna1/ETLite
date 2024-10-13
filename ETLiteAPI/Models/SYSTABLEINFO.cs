using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models {

	[JsonObject(MemberSerialization.OptIn), Table(Name = "SYS_TABLEINFO", DisableSyncStructure = true)]
	public partial class SYSTABLEINFO {

		[JsonProperty, Column(Name = "TABLE_ID", IsPrimary = true)]
		public int TABLEID { get; set; }

		[JsonProperty, Column(StringLength = 50)]
		public string CNNAME { get; set; }

		[JsonProperty, Column(StringLength = 100)]
		public string COLUMNCNNAME { get; set; }

		[JsonProperty, Column(StringLength = 200)]
		public string DATATABLETYPE { get; set; }

		[JsonProperty, Column(StringLength = -2)]
		public string DBSERVER { get; set; }

		[JsonProperty, Column(StringLength = 200)]
		public string DETAILCNNAME { get; set; }

		[JsonProperty, Column(StringLength = 200)]
		public string DETAILNAME { get; set; }

		[JsonProperty, Column(StringLength = 100)]
		public string EDITORTYPE { get; set; }

		[JsonProperty]
		public int? EDITTYPE { get; set; }

		[JsonProperty]
		public int? ENABLE { get; set; }

		[JsonProperty, Column(StringLength = 200)]
		public string EXPRESSFIELD { get; set; }

		[JsonProperty, Column(StringLength = 200)]
		public string FOLDERNAME { get; set; }

		[JsonProperty, Column(StringLength = 200)]
		public string NAMESPACE { get; set; }

		[JsonProperty]
		public int? ORDERNO { get; set; }

		[JsonProperty]
		public int? PARENTID { get; set; }

		[JsonProperty, Column(StringLength = 100)]
		public string RICHTEXT { get; set; }

		[JsonProperty]
		public int? SEARCHTYPE { get; set; }

		[JsonProperty, Column(StringLength = 50)]
		public string SORTNAME { get; set; }

		[JsonProperty, Column(StringLength = 50)]
		public string TABLENAME { get; set; }

		[JsonProperty, Column(StringLength = 100)]
		public string TABLETRUENAME { get; set; }

		[JsonProperty, Column(StringLength = 100)]
		public string UPLOADFIELD { get; set; }

		[JsonProperty]
		public int? UPLOADMAXCOUNT { get; set; }

	}

}
