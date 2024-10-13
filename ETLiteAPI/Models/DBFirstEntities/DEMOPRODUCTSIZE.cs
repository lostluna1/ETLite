using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models {

	[JsonObject(MemberSerialization.OptIn), Table(Name = "DEMO_PRODUCTSIZE", DisableSyncStructure = true)]
	public partial class DEMOPRODUCTSIZE {

		[JsonProperty, Column(StringLength = 50, IsPrimary = true, IsNullable = false)]
		public string PRODUCTSIZEID { get; set; }

		/// <summary>
		/// ��������
		/// </summary>
		[JsonProperty, Column(DbType = "DATE(7)")]
		public DateTime? CREATEDATE { get; set; }

		[JsonProperty]
		public int? CREATEID { get; set; }

		/// <summary>
		/// ������
		/// </summary>
		[JsonProperty, Column(StringLength = 30)]
		public string CREATOR { get; set; }

		/// <summary>
		/// ������
		/// </summary>
		[JsonProperty, Column(StringLength = 30)]
		public string MODIFIER { get; set; }

		/// <summary>
		/// ��������
		/// </summary>
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
		[JsonProperty, Column(StringLength = -2)]
		public string REMARK { get; set; }

		/// <summary>
		/// ����
		/// </summary>
		[JsonProperty, Column(StringLength = 50, IsNullable = false)]
		public string SIZE { get; set; }

		/// <summary>
		/// ����
		/// </summary>
		[JsonProperty, Column(StringLength = 50, IsNullable = false)]
		public string UNIT { get; set; }

	}

}
