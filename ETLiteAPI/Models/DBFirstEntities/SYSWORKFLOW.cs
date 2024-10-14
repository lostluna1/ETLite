using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class SYSWORKFLOW {

		[JsonProperty]
		public int? AUDITINGEDIT { get; set; }

		[JsonProperty, Column(DbType = "DATE(7)")]
		public DateTime? CREATEDATE { get; set; }

		[JsonProperty]
		public int? CREATEID { get; set; }

		[JsonProperty, Column(StringLength = 30)]
		public string CREATOR { get; set; }

		[JsonProperty, Column(StringLength = 36)]
		public string DBSERVICEID { get; set; }

		[JsonProperty]
		public sbyte? ENABLE { get; set; }

		/// <summary>
		/// ��������
		/// </summary>
		[JsonProperty, Column(StringLength = -2)]
		public string LINECONFIG { get; set; }

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
		public string NODECONFIG { get; set; }

		/// <summary>
		/// ����
		/// </summary>
		[JsonProperty, Column(StringLength = 200)]
		public string REMARK { get; set; }

		/// <summary>
		/// ����
		/// </summary>
		[JsonProperty]
		public int? WEIGHT { get; set; }

		[JsonProperty, Column(Name = "WORKFLOW_ID", StringLength = 50)]
		public string WORKFLOWID { get; set; }

		/// <summary>
		/// ��������
		/// </summary>
		[JsonProperty, Column(StringLength = 200)]
		public string WORKNAME { get; set; }

		/// <summary>
		/// ����
		/// </summary>
		[JsonProperty, Column(StringLength = 200)]
		public string WORKTABLE { get; set; }

		/// <summary>
		/// ��������
		/// </summary>
		[JsonProperty, Column(StringLength = 200)]
		public string WORKTABLENAME { get; set; }

	}

}
