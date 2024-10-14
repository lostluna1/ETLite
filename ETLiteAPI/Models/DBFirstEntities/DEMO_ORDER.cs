using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class DEMO_ORDER {

		public string ORDER_ID { get; set; }

		public DateTime? AUDITDATE { get; set; }

		public int? AUDITID { get; set; }

		public string AUDITOR { get; set; }

		public string AUDITREASON { get; set; }

		public int? AUDITSTATUS { get; set; }

		public DateTime? CREATEDATE { get; set; }

		public int? CREATEID { get; set; }

		public string CREATOR { get; set; }

		/// <summary>
		/// ����
		/// </summary>
		public string CUSTOMER { get; set; }

		/// <summary>
		/// ����
		/// </summary>
		public int? CUSTOMERID { get; set; }

		public string MODIFIER { get; set; }

		public DateTime? MODIFYDATE { get; set; }

		public int? MODIFYID { get; set; }

		/// <summary>
		/// ��������
		/// </summary>
		public DateTime ORDERDATE { get; set; }

		/// <summary>
		/// ��������
		/// </summary>
		public string ORDERNO { get; set; }

		/// <summary>
		/// ��������
		/// </summary>
		public int ORDERSTATUS { get; set; }

		/// <summary>
		/// ��������
		/// </summary>
		public int ORDERTYPE { get; set; }

		/// <summary>
		/// ����
		/// </summary>
		public string PHONENO { get; set; }

		/// <summary>
		/// ����
		/// </summary>
		public string REMARK { get; set; }

		/// <summary>
		/// ����
		/// </summary>
		public decimal? TOTALPRICE { get; set; }

		/// <summary>
		/// ������
		/// </summary>
		public int? TOTALQTY { get; set; }

	}

}
