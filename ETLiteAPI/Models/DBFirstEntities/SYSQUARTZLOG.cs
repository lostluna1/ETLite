using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models {

	[JsonObject(MemberSerialization.OptIn), Table(Name = "SYS_QUARTZLOG", DisableSyncStructure = true)]
	public partial class SYSQUARTZLOG {

		[JsonProperty, Column(StringLength = 50, IsPrimary = true, IsNullable = false)]
		public string LOGID { get; set; }

		[JsonProperty, Column(DbType = "DATE(7)")]
		public DateTime? CREATEDATE { get; set; }

		[JsonProperty]
		public int? CREATEID { get; set; }

		[JsonProperty, Column(StringLength = 30)]
		public string CREATOR { get; set; }

		/// <summary>
		/// ����(��)
		/// </summary>
		[JsonProperty]
		public int? ELAPSEDTIME { get; set; }

		/// <summary>
		/// ��������
		/// </summary>
		[JsonProperty, Column(DbType = "DATE(7)")]
		public DateTime? ENDDATE { get; set; }

		[JsonProperty, Column(StringLength = -2)]
		public string ERRORMSG { get; set; }

		[JsonProperty, Column(StringLength = 50)]
		public string ID { get; set; }

		[JsonProperty, Column(StringLength = 30)]
		public string MODIFIER { get; set; }

		[JsonProperty, Column(DbType = "DATE(7)")]
		public DateTime? MODIFYDATE { get; set; }

		[JsonProperty]
		public int? MODIFYID { get; set; }

		/// <summary>
		/// ��������
		/// </summary>
		[JsonProperty, Column(StringLength = -2)]
		public string RESPONSECONTENT { get; set; }

		/// <summary>
		/// ��������
		/// </summary>
		[JsonProperty]
		public int? RESULT { get; set; }

		/// <summary>
		/// ��������
		/// </summary>
		[JsonProperty, Column(DbType = "DATE(7)")]
		public DateTime? STRATDATE { get; set; }

		/// <summary>
		/// ��������
		/// </summary>
		[JsonProperty, Column(StringLength = -2)]
		public string TASKNAME { get; set; }

	}

}
