using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class SYS_TABLECOLUMN {

		public int COLUMNID { get; set; }

		public int? APIINPUT { get; set; }

		public int? APIISNULL { get; set; }

		public int? APIOUTPUT { get; set; }

		public int? COLSIZE { get; set; }

		public string COLUMNCNNAME { get; set; }

		public string COLUMNFORMAT { get; set; }

		public string COLUMNNAME { get; set; }

		public string COLUMNTYPE { get; set; }

		public int? COLUMNWIDTH { get; set; }

		public DateTime? CREATEDATE { get; set; }

		public int? CREATEID { get; set; }

		public string CREATOR { get; set; }

		public string DROPNO { get; set; }

		public int? EDITCOLNO { get; set; }

		public int? EDITROWNO { get; set; }

		public string EDITTYPE { get; set; }

		public int? ENABLE { get; set; }

		public int? ISCOLUMNDATA { get; set; }

		public int? ISDISPLAY { get; set; }

		public int? ISIMAGE { get; set; }

		public int? ISKEY { get; set; }

		public int? ISNULL { get; set; }

		public int? ISREADDATASET { get; set; }

		public int? MAXLENGTH { get; set; }

		public string MODIFIER { get; set; }

		public DateTime? MODIFYDATE { get; set; }

		public int? MODIFYID { get; set; }

		public int? ORDERNO { get; set; }

		public string SCRIPT { get; set; }

		public int? SEARCHCOLNO { get; set; }

		public int? SEARCHROWNO { get; set; }

		public string SEARCHTYPE { get; set; }

		public int? SORTABLE { get; set; }

		public int? TABLE_ID { get; set; }

		public string TABLENAME { get; set; }

	}

}
