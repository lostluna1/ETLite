using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class SYS_WORKFLOWTABLESTEP {

		public DateTime? AUDITDATE { get; set; }

		/// <summary>
		/// ������id
		/// </summary>
		public int? AUDITID { get; set; }

		/// <summary>
		/// ������
		/// </summary>
		public string AUDITOR { get; set; }

		/// <summary>
		/// ��������
		/// </summary>
		public int? AUDITSTATUS { get; set; }

		public DateTime? CREATEDATE { get; set; }

		public int? CREATEID { get; set; }

		public string CREATOR { get; set; }

		public sbyte? ENABLE { get; set; }

		public string MODIFIER { get; set; }

		public DateTime? MODIFYDATE { get; set; }

		public int? MODIFYID { get; set; }

		public string NEXTSTEPID { get; set; }

		public int? ORDERID { get; set; }

		public string PARENTID { get; set; }

		public string REMARK { get; set; }

		public string STEPATTRTYPE { get; set; }

		public string STEPID { get; set; }

		public string STEPNAME { get; set; }

		public int? STEPTYPE { get; set; }

		public string STEPVALUE { get; set; }

		public string SYS_WORKFLOWTABLESTEP_ID { get; set; }

		public int? WEIGHT { get; set; }

		public string WORKFLOW_ID { get; set; }

		public string WORKFLOWTABLE_ID { get; set; }

	}

}
