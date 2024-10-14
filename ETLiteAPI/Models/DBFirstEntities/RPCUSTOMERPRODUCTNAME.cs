using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class RPCUSTOMERPRODUCTNAME {

		[JsonProperty, Column(Name = "BIZ_CUSTOMERPRODUCT", DbType = "VARCHAR2(40 BYTE)")]
		public string BIZCUSTOMERPRODUCT { get; set; }

		[JsonProperty, Column(Name = "BIZ_CUSTOMERPRODUCTNAME", DbType = "VARCHAR2(256 BYTE)")]
		public string BIZCUSTOMERPRODUCTNAME { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)", IsNullable = false)]
		public string MFGORDERID { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(30 BYTE)")]
		public string MFGORDERNAME { get; set; }

	}

}
