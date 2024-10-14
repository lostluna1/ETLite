using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class SYS_WORKFLOWTABLE {

		public int? AUDITSTATUS { get; set; }

		public DateTime? CREATEDATE { get; set; }

		public int? CREATEID { get; set; }

		public string CREATOR { get; set; }

		public int? CURRENTORDERID { get; set; }

		public string CURRENTSTEPID { get; set; }

		public string DBSERVICEID { get; set; }

		public sbyte? ENABLE { get; set; }

		public string MODIFIER { get; set; }

		public DateTime? MODIFYDATE { get; set; }

		public int? MODIFYID { get; set; }

		public string STEPNAME { get; set; }

		public string WORKFLOW_ID { get; set; }

		public string WORKFLOWTABLE_ID { get; set; }

		public string WORKNAME { get; set; }

		/// <summary>
		/// ����
		/// </summary>
		public string WORKTABLE { get; set; }

		/// <summary>
		/// ������id
		/// </summary>
		public string WORKTABLEKEY { get; set; }

		/// <summary>
		/// ��������
		/// </summary>
		public string WORKTABLENAME { get; set; }

	}

}
