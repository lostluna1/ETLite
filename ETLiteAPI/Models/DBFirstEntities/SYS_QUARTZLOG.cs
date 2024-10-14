using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class SYS_QUARTZLOG {

		public string LOGID { get; set; }

		public DateTime? CREATEDATE { get; set; }

		public int? CREATEID { get; set; }

		public string CREATOR { get; set; }

		/// <summary>
		/// ����(��)
		/// </summary>
		public int? ELAPSEDTIME { get; set; }

		/// <summary>
		/// ��������
		/// </summary>
		public DateTime? ENDDATE { get; set; }

		public string ERRORMSG { get; set; }

		public string ID { get; set; }

		public string MODIFIER { get; set; }

		public DateTime? MODIFYDATE { get; set; }

		public int? MODIFYID { get; set; }

		/// <summary>
		/// ��������
		/// </summary>
		public string RESPONSECONTENT { get; set; }

		/// <summary>
		/// ��������
		/// </summary>
		public int? RESULT { get; set; }

		/// <summary>
		/// ��������
		/// </summary>
		public DateTime? STRATDATE { get; set; }

		/// <summary>
		/// ��������
		/// </summary>
		public string TASKNAME { get; set; }

	}

}
