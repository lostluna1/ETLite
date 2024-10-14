using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class SYS_WORKFLOW {

		public int? AUDITINGEDIT { get; set; }

		public DateTime? CREATEDATE { get; set; }

		public int? CREATEID { get; set; }

		public string CREATOR { get; set; }

		public string DBSERVICEID { get; set; }

		public sbyte? ENABLE { get; set; }

		/// <summary>
		/// ��������
		/// </summary>
		public string LINECONFIG { get; set; }

		public string MODIFIER { get; set; }

		public DateTime? MODIFYDATE { get; set; }

		public int? MODIFYID { get; set; }

		/// <summary>
		/// ��������
		/// </summary>
		public string NODECONFIG { get; set; }

		/// <summary>
		/// ����
		/// </summary>
		public string REMARK { get; set; }

		/// <summary>
		/// ����
		/// </summary>
		public int? WEIGHT { get; set; }

		public string WORKFLOW_ID { get; set; }

		/// <summary>
		/// ��������
		/// </summary>
		public string WORKNAME { get; set; }

		/// <summary>
		/// ����
		/// </summary>
		public string WORKTABLE { get; set; }

		/// <summary>
		/// ��������
		/// </summary>
		public string WORKTABLENAME { get; set; }

	}

}
