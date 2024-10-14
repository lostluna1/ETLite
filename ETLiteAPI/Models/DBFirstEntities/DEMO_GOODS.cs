using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class DEMO_GOODS {

		/// <summary>
		/// ����ID
		/// </summary>
		public string GOODSID { get; set; }

		/// <summary>
		/// ��������
		/// </summary>
		public string CATALOGID { get; set; }

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
		/// ��������
		/// </summary>
		public int? ENABLE { get; set; }

		/// <summary>
		/// ��������
		/// </summary>
		public string GOODSCODE { get; set; }

		/// <summary>
		/// ��������
		/// </summary>
		public string GOODSNAME { get; set; }

		/// <summary>
		/// ��������
		/// </summary>
		public string IMG { get; set; }

		/// <summary>
		/// ������
		/// </summary>
		public string MODIFIER { get; set; }

		public DateTime? MODIFYDATE { get; set; }

		public int? MODIFYID { get; set; }

		/// <summary>
		/// ����
		/// </summary>
		public decimal PRICE { get; set; }

		/// <summary>
		/// ����
		/// </summary>
		public string REMARK { get; set; }

		/// <summary>
		/// ��������
		/// </summary>
		public string SPECS { get; set; }

	}

}
