using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class DEMO_PRODUCT {

		public string PRODUCTID { get; set; }

		public int? AUDITSTATUS { get; set; }

		/// <summary>
		/// ��������
		/// </summary>
		public DateTime? CREATEDATE { get; set; }

		public int? CREATEID { get; set; }

		/// <summary>
		/// ������
		/// </summary>
		public string CREATOR { get; set; }

		/// <summary>
		/// ������
		/// </summary>
		public string MODIFIER { get; set; }

		/// <summary>
		/// ��������
		/// </summary>
		public DateTime? MODIFYDATE { get; set; }

		public int? MODIFYID { get; set; }

		/// <summary>
		/// ����
		/// </summary>
		public decimal PRICE { get; set; }

		/// <summary>
		/// ��������
		/// </summary>
		public string PRODUCTCODE { get; set; }

		/// <summary>
		/// ��������
		/// </summary>
		public string PRODUCTNAME { get; set; }

		/// <summary>
		/// ����
		/// </summary>
		public string REMARK { get; set; }

	}

}
