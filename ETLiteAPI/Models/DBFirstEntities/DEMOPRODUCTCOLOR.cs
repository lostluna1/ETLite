using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models {

	[JsonObject(MemberSerialization.OptIn), Table(Name = "DEMO_PRODUCTCOLOR", DisableSyncStructure = true)]
	public partial class DEMOPRODUCTCOLOR {

		[JsonProperty, Column(StringLength = 50, IsPrimary = true, IsNullable = false)]
		public string PRODUCTCOLORID { get; set; }

		/// <summary>
		/// ����
		/// </summary>
		[JsonProperty, Column(StringLength = 50, IsNullable = false)]
		public string COLOR { get; set; }

		[JsonProperty, Column(DbType = "DATE(7)")]
		public DateTime? CREATEDATE { get; set; }

		[JsonProperty]
		public int? CREATEID { get; set; }

		[JsonProperty, Column(StringLength = 30)]
		public string CREATOR { get; set; }

		/// <summary>
		/// ����
		/// </summary>
		[JsonProperty, Column(StringLength = -2, IsNullable = false)]
		public string IMG { get; set; }

		[JsonProperty, Column(StringLength = 30)]
		public string MODIFIER { get; set; }

		[JsonProperty, Column(DbType = "DATE(7)")]
		public DateTime? MODIFYDATE { get; set; }

		[JsonProperty]
		public int? MODIFYID { get; set; }

		/// <summary>
		/// ����id
		/// </summary>
		[JsonProperty, Column(StringLength = 50)]
		public string PRODUCTID { get; set; }

		/// <summary>
		/// ����
		/// </summary>
		[JsonProperty, Column(StringLength = 50, IsNullable = false)]
		public string QTY { get; set; }

		/// <summary>
		/// ����
		/// </summary>
		[JsonProperty, Column(StringLength = -2)]
		public string REMARK { get; set; }

		/// <summary>
		/// ����
		/// </summary>
		[JsonProperty, Column(StringLength = 50, IsNullable = false)]
		public string UNIT { get; set; }

	}

}
