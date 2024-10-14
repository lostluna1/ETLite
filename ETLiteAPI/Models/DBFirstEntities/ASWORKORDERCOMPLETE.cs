using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class ASWORKORDERCOMPLETE {

		[JsonProperty, Column(DbType = "CHAR(0 BYTE)")]
		public string FACTORY { get; set; }

		[JsonProperty, Column(DbType = "CHAR(0 BYTE)")]
		public string LOCATION { get; set; }

		[JsonProperty, Column(DbType = "CHAR(0 BYTE)")]
		public string MFGORDER { get; set; }

		[JsonProperty, Column(DbType = "CHAR(0 BYTE)")]
		public string PKN { get; set; }

		[JsonProperty, Column(DbType = "CHAR(0 BYTE)")]
		public string PRODUCT { get; set; }

		[JsonProperty, Column(DbType = "CHAR(0 BYTE)")]
		public string QCSTATUS { get; set; }

		[JsonProperty, Column(DbType = "CHAR(0 BYTE)")]
		public string QTY { get; set; }

		[JsonProperty, Column(DbType = "CHAR(0 BYTE)")]
		public string REQUESTTYPE { get; set; }

		[JsonProperty, Column(DbType = "CHAR(0 BYTE)")]
		public string UOM { get; set; }

	}

}
