using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class DEMOORDER {

		[JsonProperty, Column(Name = "ORDER_ID", StringLength = 50, IsPrimary = true, IsNullable = false)]
		public string ORDERID { get; set; }

		[JsonProperty, Column(DbType = "DATE(7)")]
		public DateTime? AUDITDATE { get; set; }

		[JsonProperty]
		public int? AUDITID { get; set; }

		[JsonProperty, Column(StringLength = 100)]
		public string AUDITOR { get; set; }

		[JsonProperty, Column(StringLength = -2)]
		public string AUDITREASON { get; set; }

		[JsonProperty]
		public int? AUDITSTATUS { get; set; }

		[JsonProperty, Column(DbType = "DATE(7)")]
		public DateTime? CREATEDATE { get; set; }

		[JsonProperty]
		public int? CREATEID { get; set; }

		[JsonProperty, Column(StringLength = 30)]
		public string CREATOR { get; set; }

		/// <summary>
		/// ����
		/// </summary>
		[JsonProperty, Column(StringLength = 100)]
		public string CUSTOMER { get; set; }

		/// <summary>
		/// ����
		/// </summary>
		[JsonProperty]
		public int? CUSTOMERID { get; set; }

		[JsonProperty, Column(StringLength = 30)]
		public string MODIFIER { get; set; }

		[JsonProperty, Column(DbType = "DATE(7)")]
		public DateTime? MODIFYDATE { get; set; }

		[JsonProperty]
		public int? MODIFYID { get; set; }

		/// <summary>
		/// ��������
		/// </summary>
		[JsonProperty, Column(DbType = "DATE(7)")]
		public DateTime ORDERDATE { get; set; }

		/// <summary>
		/// ��������
		/// </summary>
		[JsonProperty, Column(StringLength = 100, IsNullable = false)]
		public string ORDERNO { get; set; }

		/// <summary>
		/// ��������
		/// </summary>
		[JsonProperty]
		public int ORDERSTATUS { get; set; }

		/// <summary>
		/// ��������
		/// </summary>
		[JsonProperty]
		public int ORDERTYPE { get; set; }

		/// <summary>
		/// ����
		/// </summary>
		[JsonProperty, Column(StringLength = 50)]
		public string PHONENO { get; set; }

		/// <summary>
		/// ����
		/// </summary>
		[JsonProperty, Column(StringLength = 200)]
		public string REMARK { get; set; }

		/// <summary>
		/// ����
		/// </summary>
		[JsonProperty, Column(DbType = "NUMBER(22)")]
		public decimal? TOTALPRICE { get; set; }

		/// <summary>
		/// ������
		/// </summary>
		[JsonProperty]
		public int? TOTALQTY { get; set; }

	}

}
