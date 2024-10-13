using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models {

	[JsonObject(MemberSerialization.OptIn), Table(Name = "DEMO_PRODUCT", DisableSyncStructure = true)]
	public partial class DEMOPRODUCT {

		[JsonProperty, Column(StringLength = 50, IsPrimary = true, IsNullable = false)]
		public string PRODUCTID { get; set; }

		[JsonProperty]
		public int? AUDITSTATUS { get; set; }

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
		/// ����
		/// </summary>
		[JsonProperty, Column(DbType = "NUMBER(22)")]
		public decimal PRICE { get; set; }

		/// <summary>
		/// ��������
		/// </summary>
		[JsonProperty, Column(StringLength = 100, IsNullable = false)]
		public string PRODUCTCODE { get; set; }

		/// <summary>
		/// ��������
		/// </summary>
		[JsonProperty, Column(StringLength = 100, IsNullable = false)]
		public string PRODUCTNAME { get; set; }

		/// <summary>
		/// ����
		/// </summary>
		[JsonProperty, Column(StringLength = -2)]
		public string REMARK { get; set; }

	}

}
