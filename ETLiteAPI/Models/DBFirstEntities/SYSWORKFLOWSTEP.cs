using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class SYSWORKFLOWSTEP {

		[JsonProperty]
		public int? AUDITBACK { get; set; }

		[JsonProperty]
		public int? AUDITMETHOD { get; set; }

		[JsonProperty]
		public int? AUDITREFUSE { get; set; }

		[JsonProperty, Column(DbType = "DATE(7)")]
		public DateTime? CREATEDATE { get; set; }

		[JsonProperty]
		public int? CREATEID { get; set; }

		[JsonProperty, Column(StringLength = 30)]
		public string CREATOR { get; set; }

		[JsonProperty]
		public sbyte? ENABLE { get; set; }

		[JsonProperty, Column(StringLength = -2)]
		public string FILTERS { get; set; }

		[JsonProperty, Column(StringLength = 30)]
		public string MODIFIER { get; set; }

		[JsonProperty, Column(DbType = "DATE(7)")]
		public DateTime? MODIFYDATE { get; set; }

		[JsonProperty]
		public int? MODIFYID { get; set; }

		[JsonProperty, Column(StringLength = -2)]
		public string NEXTSTEPIDS { get; set; }

		[JsonProperty]
		public int? ORDERID { get; set; }

		[JsonProperty, Column(StringLength = -2)]
		public string PARENTID { get; set; }

		/// <summary>
		/// ����
		/// </summary>
		[JsonProperty, Column(StringLength = -2)]
		public string REMARK { get; set; }

		[JsonProperty]
		public int? SENDMAIL { get; set; }

		[JsonProperty, Column(StringLength = 50)]
		public string STEPATTRTYPE { get; set; }

		/// <summary>
		/// ��������Id
		/// </summary>
		[JsonProperty, Column(StringLength = 100)]
		public string STEPID { get; set; }

		/// <summary>
		/// ��������
		/// </summary>
		[JsonProperty, Column(StringLength = 200)]
		public string STEPNAME { get; set; }

		/// <summary>
		/// ��������(1=����������,2=����������)
		/// </summary>
		[JsonProperty]
		public int? STEPTYPE { get; set; }

		/// <summary>
		/// ��������id������id
		/// </summary>
		[JsonProperty, Column(StringLength = -2)]
		public string STEPVALUE { get; set; }

		[JsonProperty]
		public int? WEIGHT { get; set; }

		/// <summary>
		/// ��������id
		/// </summary>
		[JsonProperty, Column(Name = "WORKFLOW_ID", StringLength = 50)]
		public string WORKFLOWID { get; set; }

		[JsonProperty, Column(Name = "WORKSTEPFLOW_ID", StringLength = 50, IsNullable = false)]
		public string WORKSTEPFLOWID { get; set; }

	}

}
