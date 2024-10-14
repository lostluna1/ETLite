using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class SYSWORKFLOWTABLE {

		[JsonProperty]
		public int? AUDITSTATUS { get; set; }

		[JsonProperty, Column(DbType = "DATE(7)")]
		public DateTime? CREATEDATE { get; set; }

		[JsonProperty]
		public int? CREATEID { get; set; }

		[JsonProperty, Column(StringLength = 30)]
		public string CREATOR { get; set; }

		[JsonProperty]
		public int? CURRENTORDERID { get; set; }

		[JsonProperty, Column(StringLength = 100)]
		public string CURRENTSTEPID { get; set; }

		[JsonProperty, Column(StringLength = 50)]
		public string DBSERVICEID { get; set; }

		[JsonProperty]
		public sbyte? ENABLE { get; set; }

		[JsonProperty, Column(StringLength = 30)]
		public string MODIFIER { get; set; }

		[JsonProperty, Column(DbType = "DATE(7)")]
		public DateTime? MODIFYDATE { get; set; }

		[JsonProperty]
		public int? MODIFYID { get; set; }

		[JsonProperty, Column(StringLength = 500)]
		public string STEPNAME { get; set; }

		[JsonProperty, Column(Name = "WORKFLOW_ID", StringLength = 50)]
		public string WORKFLOWID { get; set; }

		[JsonProperty, Column(Name = "WORKFLOWTABLE_ID", StringLength = 50, IsNullable = false)]
		public string WORKFLOWTABLEID { get; set; }

		[JsonProperty, Column(StringLength = 200)]
		public string WORKNAME { get; set; }

		/// <summary>
		/// ����
		/// </summary>
		[JsonProperty, Column(StringLength = 200)]
		public string WORKTABLE { get; set; }

		/// <summary>
		/// ������id
		/// </summary>
		[JsonProperty, Column(StringLength = 200)]
		public string WORKTABLEKEY { get; set; }

		/// <summary>
		/// ��������
		/// </summary>
		[JsonProperty, Column(StringLength = 200)]
		public string WORKTABLENAME { get; set; }

	}

}
