using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class BIZTASKREPORT {

		[JsonProperty, Column(Name = "BIZ_TASKREPORTID", DbType = "CHAR(16 BYTE)", IsPrimary = true, IsNullable = false)]
		public string BIZTASKREPORTID { get; set; }

		[JsonProperty, Column(Name = "BIZ_EQUIPDAILYINSPECTTASKID", DbType = "CHAR(16 BYTE)")]
		public string BIZEQUIPDAILYINSPECTTASKID { get; set; }

		[JsonProperty, Column(Name = "BIZ_TASKREPORTNAME", DbType = "VARCHAR2(36 BYTE)")]
		public string BIZTASKREPORTNAME { get; set; }

		[JsonProperty]
		public uint? CDOTYPEID { get; set; }

		[JsonProperty]
		public uint? CHANGECOUNT { get; set; }

		[JsonProperty]
		public uint? COLUMNPOSITION { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(255 BYTE)")]
		public string DATANAME { get; set; }

		[JsonProperty]
		public uint? DATATYPE { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(1000 BYTE)")]
		public string DATAVALUE { get; set; }

		[JsonProperty]
		public uint? ISFROZEN { get; set; }

		[JsonProperty]
		public uint? ISLIMITOVERRIDEALLOWED { get; set; }

		[JsonProperty]
		public uint? ISREQUIRED { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(30 BYTE)")]
		public string LOWERLIMIT { get; set; }

		[JsonProperty]
		public uint? ROWPOSITION { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(30 BYTE)")]
		public string UPPERLIMIT { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string USERDATACOLLECTIONDEFID { get; set; }

	}

}
