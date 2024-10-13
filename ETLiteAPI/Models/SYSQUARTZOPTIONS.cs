using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models {

	[JsonObject(MemberSerialization.OptIn), Table(Name = "SYS_QUARTZOPTIONS", DisableSyncStructure = true)]
	public partial class SYSQUARTZOPTIONS {

		/// <summary>
		/// Url����
		/// </summary>
		[JsonProperty, Column(StringLength = 2000)]
		public string APIURL { get; set; }

		[JsonProperty, Column(StringLength = 200)]
		public string AUTHKEY { get; set; }

		[JsonProperty, Column(StringLength = 200)]
		public string AUTHVALUE { get; set; }

		/// <summary>
		/// ��������
		/// </summary>
		[JsonProperty, Column(DbType = "DATE(7)")]
		public DateTime? CREATEDATE { get; set; }

		[JsonProperty]
		public int? CREATEID { get; set; }

		[JsonProperty, Column(StringLength = 30)]
		public string CREATOR { get; set; }

		/// <summary>
		/// Corn������
		/// </summary>
		[JsonProperty, Column(StringLength = 100, IsNullable = false)]
		public string CRONEXPRESSION { get; set; }

		/// <summary>
		/// ����
		/// </summary>
		[JsonProperty, Column(StringLength = 2000)]
		public string DESCRIBE { get; set; }

		/// <summary>
		/// ��������
		/// </summary>
		[JsonProperty, Column(StringLength = 200)]
		public string GROUPNAME { get; set; }

		[JsonProperty, Column(StringLength = 50, IsNullable = false)]
		public string ID { get; set; }

		/// <summary>
		/// ������������
		/// </summary>
		[JsonProperty, Column(DbType = "DATE(7)")]
		public DateTime? LASTRUNTIME { get; set; }

		/// <summary>
		/// ��������
		/// </summary>
		[JsonProperty, Column(StringLength = 50)]
		public string METHOD { get; set; }

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
		/// post����
		/// </summary>
		[JsonProperty, Column(StringLength = -2)]
		public string POSTDATA { get; set; }

		/// <summary>
		/// ��������
		/// </summary>
		[JsonProperty]
		public int? STATUS { get; set; }

		/// <summary>
		/// ��������
		/// </summary>
		[JsonProperty, Column(StringLength = 200)]
		public string TASKNAME { get; set; }

		/// <summary>
		/// ��������(��)
		/// </summary>
		[JsonProperty]
		public int? TIMEOUT { get; set; }

	}

}
