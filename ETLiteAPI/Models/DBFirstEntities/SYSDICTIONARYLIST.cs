using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class SYSDICTIONARYLIST {

		[JsonProperty, Column(Name = "DICLIST_ID", IsPrimary = true)]
		public int DICLISTID { get; set; }

		[JsonProperty, Column(DbType = "DATE(7)")]
		public DateTime? CREATEDATE { get; set; }

		[JsonProperty]
		public int? CREATEID { get; set; }

		[JsonProperty, Column(StringLength = 30)]
		public string CREATOR { get; set; }

		[JsonProperty, Column(Name = "DIC_ID")]
		public int? DICID { get; set; }

		[JsonProperty, Column(StringLength = 100)]
		public string DICNAME { get; set; }

		[JsonProperty, Column(StringLength = 100)]
		public string DICVALUE { get; set; }

		[JsonProperty]
		public sbyte? ENABLE { get; set; }

		[JsonProperty, Column(StringLength = 30)]
		public string MODIFIER { get; set; }

		[JsonProperty, Column(DbType = "DATE(7)")]
		public DateTime? MODIFYDATE { get; set; }

		[JsonProperty]
		public int? MODIFYID { get; set; }

		[JsonProperty]
		public int? ORDERNO { get; set; }

		[JsonProperty, Column(StringLength = -2)]
		public string REMARK { get; set; }

	}

}
