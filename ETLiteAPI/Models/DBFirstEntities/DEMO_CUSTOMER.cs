using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class DEMO_CUSTOMER {

		public int CUSTOMER_ID { get; set; }

		/// <summary>
		/// ��
		/// </summary>
		public string CITY { get; set; }

		public string COUNTY { get; set; }

		public DateTime? CREATEDATE { get; set; }

		public int? CREATEID { get; set; }

		public string CREATOR { get; set; }

		/// <summary>
		/// ����
		/// </summary>
		public string CUSTOMER { get; set; }

		/// <summary>
		/// ��������
		/// </summary>
		public string DETAILADDRESS { get; set; }

		public string MODIFIER { get; set; }

		public DateTime? MODIFYDATE { get; set; }

		public int? MODIFYID { get; set; }

		/// <summary>
		/// ����
		/// </summary>
		public string PHONENO { get; set; }

		/// <summary>
		/// ��
		/// </summary>
		public string PROVINCE { get; set; }

		public string REMARK { get; set; }

	}

}
