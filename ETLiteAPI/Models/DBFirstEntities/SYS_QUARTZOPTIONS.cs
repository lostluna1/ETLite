using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class SYS_QUARTZOPTIONS {

		/// <summary>
		/// Url����
		/// </summary>
		public string APIURL { get; set; }

		public string AUTHKEY { get; set; }

		public string AUTHVALUE { get; set; }

		/// <summary>
		/// ��������
		/// </summary>
		public DateTime? CREATEDATE { get; set; }

		public int? CREATEID { get; set; }

		public string CREATOR { get; set; }

		/// <summary>
		/// Corn������
		/// </summary>
		public string CRONEXPRESSION { get; set; }

		/// <summary>
		/// ����
		/// </summary>
		public string DESCRIBE { get; set; }

		/// <summary>
		/// ��������
		/// </summary>
		public string GROUPNAME { get; set; }

		public string ID { get; set; }

		/// <summary>
		/// ������������
		/// </summary>
		public DateTime? LASTRUNTIME { get; set; }

		/// <summary>
		/// ��������
		/// </summary>
		public string METHOD { get; set; }

		public string MODIFIER { get; set; }

		/// <summary>
		/// ��������
		/// </summary>
		public DateTime? MODIFYDATE { get; set; }

		public int? MODIFYID { get; set; }

		/// <summary>
		/// post����
		/// </summary>
		public string POSTDATA { get; set; }

		/// <summary>
		/// ��������
		/// </summary>
		public int? STATUS { get; set; }

		/// <summary>
		/// ��������
		/// </summary>
		public string TASKNAME { get; set; }

		/// <summary>
		/// ��������(��)
		/// </summary>
		public int? TIMEOUT { get; set; }

	}

}
