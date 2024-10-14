using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class SYS_WORKFLOWSTEP {

		public int? AUDITBACK { get; set; }

		public int? AUDITMETHOD { get; set; }

		public int? AUDITREFUSE { get; set; }

		public DateTime? CREATEDATE { get; set; }

		public int? CREATEID { get; set; }

		public string CREATOR { get; set; }

		public sbyte? ENABLE { get; set; }

		public string FILTERS { get; set; }

		public string MODIFIER { get; set; }

		public DateTime? MODIFYDATE { get; set; }

		public int? MODIFYID { get; set; }

		public string NEXTSTEPIDS { get; set; }

		public int? ORDERID { get; set; }

		public string PARENTID { get; set; }

		/// <summary>
		/// ����
		/// </summary>
		public string REMARK { get; set; }

		public int? SENDMAIL { get; set; }

		public string STEPATTRTYPE { get; set; }

		/// <summary>
		/// ��������Id
		/// </summary>
		public string STEPID { get; set; }

		/// <summary>
		/// ��������
		/// </summary>
		public string STEPNAME { get; set; }

		/// <summary>
		/// ��������(1=����������,2=����������)
		/// </summary>
		public int? STEPTYPE { get; set; }

		/// <summary>
		/// ��������id������id
		/// </summary>
		public string STEPVALUE { get; set; }

		public int? WEIGHT { get; set; }

		/// <summary>
		/// ��������id
		/// </summary>
		public string WORKFLOW_ID { get; set; }

		public string WORKSTEPFLOW_ID { get; set; }

	}

}
