using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class SYSWORKFLOWTABLESTEP {

		[JsonProperty, Column(DbType = "DATE(7)")]
		public DateTime? AUDITDATE { get; set; }

		/// <summary>
		/// ������id
		/// </summary>
		[JsonProperty]
		public int? AUDITID { get; set; }

		/// <summary>
		/// ������
		/// </summary>
		[JsonProperty, Column(StringLength = 50)]
		public string AUDITOR { get; set; }

		/// <summary>
		/// ��������
		/// </summary>
		[JsonProperty]
		public int? AUDITSTATUS { get; set; }

		[JsonProperty, Column(DbType = "DATE(7)")]
		public DateTime? CREATEDATE { get; set; }

		[JsonProperty]
		public int? CREATEID { get; set; }

		[JsonProperty, Column(StringLength = 30)]
		public string CREATOR { get; set; }

		[JsonProperty]
		public sbyte? ENABLE { get; set; }

		[JsonProperty, Column(StringLength = 30)]
		public string MODIFIER { get; set; }

		[JsonProperty, Column(DbType = "DATE(7)")]
		public DateTime? MODIFYDATE { get; set; }

		[JsonProperty]
		public int? MODIFYID { get; set; }

		[JsonProperty, Column(StringLength = 100)]
		public string NEXTSTEPID { get; set; }

		[JsonProperty]
		public int? ORDERID { get; set; }

		[JsonProperty, Column(StringLength = 200)]
		public string PARENTID { get; set; }

		[JsonProperty, Column(StringLength = 200)]
		public string REMARK { get; set; }

		[JsonProperty, Column(StringLength = 50)]
		public string STEPATTRTYPE { get; set; }

		[JsonProperty, Column(StringLength = 100)]
		public string STEPID { get; set; }

		[JsonProperty, Column(StringLength = 200)]
		public string STEPNAME { get; set; }

		[JsonProperty]
		public int? STEPTYPE { get; set; }

		[JsonProperty, Column(StringLength = 200)]
		public string STEPVALUE { get; set; }

		[JsonProperty, Column(Name = "SYS_WORKFLOWTABLESTEP_ID", StringLength = 50, IsNullable = false)]
		public string SYSWORKFLOWTABLESTEPID { get; set; }

		[JsonProperty]
		public int? WEIGHT { get; set; }

		[JsonProperty, Column(Name = "WORKFLOW_ID", StringLength = 50)]
		public string WORKFLOWID { get; set; }

		[JsonProperty, Column(Name = "WORKFLOWTABLE_ID", StringLength = 50, IsNullable = false)]
		public string WORKFLOWTABLEID { get; set; }

	}

}
