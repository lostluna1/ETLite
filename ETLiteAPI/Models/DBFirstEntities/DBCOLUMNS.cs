using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class DBCOLUMNS {

		public bool? ALLOWSYSTEMTODELETE { get; set; }

		public bool? ALLOWSYSTEMTOUPDATE { get; set; }

		public uint? ASSOCIATEDCOLUMNID { get; set; }

		public bool? CASESENSITIVE { get; set; }

		public string COLUMNDESCRIPTION { get; set; }

		public string COLUMNNAME { get; set; }

		public uint? COLUMNSEQUENCE { get; set; }

		public uint? COLUMNUSAGEID { get; set; }

		public uint? DBCOLUMNID { get; set; }

		public uint? DBTABLEID { get; set; }

		public bool? FORCETOLOWER { get; set; }

		public bool? FORCETOUPPER { get; set; }

		public uint? PRECISIONVALUE { get; set; }

		public uint? PRIMARYKEYSEQUENCE { get; set; }

		public uint? SCALE { get; set; }

		public uint? SQLTYPEVALUE { get; set; }

		public string WORKSPACECODE { get; set; }

	}

}
