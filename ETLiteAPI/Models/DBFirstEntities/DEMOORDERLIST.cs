using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class DEMOORDERLIST {

		[JsonProperty, Column(Name = "ORDERLIST_ID", StringLength = 50, IsPrimary = true, IsNullable = false)]
		public string ORDERLISTID { get; set; }

		[JsonProperty, Column(DbType = "DATE(7)")]
		public DateTime? CREATEDATE { get; set; }

		[JsonProperty]
		public int? CREATEID { get; set; }

		[JsonProperty, Column(StringLength = 30)]
		public string CREATOR { get; set; }

		/// <summary>
		/// ��������
		/// </summary>
		[JsonProperty, Column(StringLength = 100, IsNullable = false)]
		public string GOODSCODE { get; set; }

		/// <summary>
		/// ����id
		/// </summary>
		[JsonProperty, Column(StringLength = 50)]
		public string GOODSID { get; set; }

		/// <summary>
		/// ��������
		/// </summary>
		[JsonProperty, Column(StringLength = 100, IsNullable = false)]
		public string GOODSNAME { get; set; }

		/// <summary>
		/// ��������
		/// </summary>
		[JsonProperty, Column(StringLength = -2)]
		public string IMG { get; set; }

		[JsonProperty, Column(StringLength = 30)]
		public string MODIFIER { get; set; }

		[JsonProperty, Column(DbType = "DATE(7)")]
		public DateTime? MODIFYDATE { get; set; }

		[JsonProperty]
		public int? MODIFYID { get; set; }

		[JsonProperty, Column(Name = "ORDER_ID", StringLength = 50)]
		public string ORDERID { get; set; }

		/// <summary>
		/// ����
		/// </summary>
		[JsonProperty, Column(DbType = "NUMBER(22)")]
		public decimal PRICE { get; set; }

		/// <summary>
		/// ����
		/// </summary>
		[JsonProperty]
		public int QTY { get; set; }

		/// <summary>
		/// ����
		/// </summary>
		[JsonProperty, Column(StringLength = 200)]
		public string REMARK { get; set; }

		/// <summary>
		/// ��������
		/// </summary>
		[JsonProperty, Column(StringLength = 100)]
		public string SPECS { get; set; }

	}

}
