using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class SYS_TABLEINFO {

		public int TABLE_ID { get; set; }

		public string CNNAME { get; set; }

		public string COLUMNCNNAME { get; set; }

		public string DATATABLETYPE { get; set; }

		public string DBSERVER { get; set; }

		public string DETAILCNNAME { get; set; }

		public string DETAILNAME { get; set; }

		public string EDITORTYPE { get; set; }

		public int? EDITTYPE { get; set; }

		public int? ENABLE { get; set; }

		public string EXPRESSFIELD { get; set; }

		public string FOLDERNAME { get; set; }

		public string NAMESPACE { get; set; }

		public int? ORDERNO { get; set; }

		public int? PARENTID { get; set; }

		public string RICHTEXT { get; set; }

		public int? SEARCHTYPE { get; set; }

		public string SORTNAME { get; set; }

		public string TABLENAME { get; set; }

		public string TABLETRUENAME { get; set; }

		public string UPLOADFIELD { get; set; }

		public int? UPLOADMAXCOUNT { get; set; }

	}

}
