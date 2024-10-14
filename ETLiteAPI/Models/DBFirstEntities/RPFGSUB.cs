using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class RPFGSUB {

		[JsonProperty, Column(Name = "CREATION_DATE", DbType = "DATE(7)")]
		public DateTime? CREATIONDATE { get; set; }

		[JsonProperty, Column(Name = "FG_RFID", DbType = "VARCHAR2(64 BYTE)")]
		public string FGRFID { get; set; }

		[JsonProperty, Column(Name = "MFGORDER_NAME", DbType = "VARCHAR2(30 BYTE)")]
		public string MFGORDERNAME { get; set; }

		[JsonProperty, Column(Name = "SUB_MFGORDER_NAME", DbType = "VARCHAR2(30 BYTE)")]
		public string SUBMFGORDERNAME { get; set; }

		[JsonProperty, Column(Name = "SUB_RFID", DbType = "VARCHAR2(64 BYTE)")]
		public string SUBRFID { get; set; }

	}

}
