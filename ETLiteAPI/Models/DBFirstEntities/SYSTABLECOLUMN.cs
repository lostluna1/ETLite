using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class SYSTABLECOLUMN {

		[JsonProperty, Column(IsPrimary = true)]
		public int COLUMNID { get; set; }

		[JsonProperty]
		public int? APIINPUT { get; set; }

		[JsonProperty]
		public int? APIISNULL { get; set; }

		[JsonProperty]
		public int? APIOUTPUT { get; set; }

		[JsonProperty]
		public int? COLSIZE { get; set; }

		[JsonProperty, Column(StringLength = 100)]
		public string COLUMNCNNAME { get; set; }

		[JsonProperty, Column(StringLength = -2)]
		public string COLUMNFORMAT { get; set; }

		[JsonProperty, Column(StringLength = 100)]
		public string COLUMNNAME { get; set; }

		[JsonProperty, Column(StringLength = -2)]
		public string COLUMNTYPE { get; set; }

		[JsonProperty]
		public int? COLUMNWIDTH { get; set; }

		[JsonProperty, Column(DbType = "DATE(7)")]
		public DateTime? CREATEDATE { get; set; }

		[JsonProperty]
		public int? CREATEID { get; set; }

		[JsonProperty, Column(StringLength = 200)]
		public string CREATOR { get; set; }

		[JsonProperty, Column(StringLength = 50)]
		public string DROPNO { get; set; }

		[JsonProperty]
		public int? EDITCOLNO { get; set; }

		[JsonProperty]
		public int? EDITROWNO { get; set; }

		[JsonProperty, Column(StringLength = 200)]
		public string EDITTYPE { get; set; }

		[JsonProperty]
		public int? ENABLE { get; set; }

		[JsonProperty]
		public int? ISCOLUMNDATA { get; set; }

		[JsonProperty]
		public int? ISDISPLAY { get; set; }

		[JsonProperty]
		public int? ISIMAGE { get; set; }

		[JsonProperty]
		public int? ISKEY { get; set; }

		[JsonProperty]
		public int? ISNULL { get; set; }

		[JsonProperty]
		public int? ISREADDATASET { get; set; }

		[JsonProperty]
		public int? MAXLENGTH { get; set; }

		[JsonProperty, Column(StringLength = -2)]
		public string MODIFIER { get; set; }

		[JsonProperty, Column(DbType = "DATE(7)")]
		public DateTime? MODIFYDATE { get; set; }

		[JsonProperty]
		public int? MODIFYID { get; set; }

		[JsonProperty]
		public int? ORDERNO { get; set; }

		[JsonProperty, Column(StringLength = -2)]
		public string SCRIPT { get; set; }

		[JsonProperty]
		public int? SEARCHCOLNO { get; set; }

		[JsonProperty]
		public int? SEARCHROWNO { get; set; }

		[JsonProperty, Column(StringLength = 200)]
		public string SEARCHTYPE { get; set; }

		[JsonProperty]
		public int? SORTABLE { get; set; }

		[JsonProperty, Column(Name = "TABLE_ID")]
		public int? TABLEID { get; set; }

		[JsonProperty, Column(StringLength = 200)]
		public string TABLENAME { get; set; }

	}

}
