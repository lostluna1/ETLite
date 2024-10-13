using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models {

	[JsonObject(MemberSerialization.OptIn), Table(Name = "DEMO_CATALOG", DisableSyncStructure = true)]
	public partial class DEMOCATALOG {

		/// <summary>
		/// ��������
		/// </summary>
		[JsonProperty, Column(StringLength = 50, IsPrimary = true, IsNullable = false)]
		public string CATALOGID { get; set; }

		/// <summary>
		/// ��������
		/// </summary>
		[JsonProperty, Column(StringLength = 100, IsNullable = false)]
		public string CATALOGCODE { get; set; }

		/// <summary>
		/// ��������
		/// </summary>
		[JsonProperty, Column(StringLength = 100, IsNullable = false)]
		public string CATALOGNAME { get; set; }

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
		/// ��������
		/// </summary>
		[JsonProperty]
		public int? ENABLE { get; set; }

		/// <summary>
		/// ��������
		/// </summary>
		[JsonProperty, Column(StringLength = -2)]
		public string IMG { get; set; }

		/// <summary>
		/// ������
		/// </summary>
		[JsonProperty, Column(StringLength = 30)]
		public string MODIFIER { get; set; }

		[JsonProperty, Column(DbType = "DATE(7)")]
		public DateTime? MODIFYDATE { get; set; }

		[JsonProperty]
		public int? MODIFYID { get; set; }

		/// <summary>
		/// ��������
		/// </summary>
		[JsonProperty, Column(StringLength = 50)]
		public string PARENTID { get; set; }

		/// <summary>
		/// ����
		/// </summary>
		[JsonProperty, Column(StringLength = -2)]
		public string REMARK { get; set; }

	}

}
