using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class DEMOCUSTOMER {

		[JsonProperty, Column(Name = "CUSTOMER_ID", IsPrimary = true)]
		public int CUSTOMERID { get; set; }

		/// <summary>
		/// ��
		/// </summary>
		[JsonProperty, Column(StringLength = 100, IsNullable = false)]
		public string CITY { get; set; }

		[JsonProperty, Column(StringLength = 50)]
		public string COUNTY { get; set; }

		[JsonProperty, Column(DbType = "DATE(7)")]
		public DateTime? CREATEDATE { get; set; }

		[JsonProperty]
		public int? CREATEID { get; set; }

		[JsonProperty, Column(StringLength = 30)]
		public string CREATOR { get; set; }

		/// <summary>
		/// ����
		/// </summary>
		[JsonProperty, Column(StringLength = 200, IsNullable = false)]
		public string CUSTOMER { get; set; }

		/// <summary>
		/// ��������
		/// </summary>
		[JsonProperty, Column(StringLength = -2)]
		public string DETAILADDRESS { get; set; }

		[JsonProperty, Column(StringLength = 30)]
		public string MODIFIER { get; set; }

		[JsonProperty, Column(DbType = "DATE(7)")]
		public DateTime? MODIFYDATE { get; set; }

		[JsonProperty]
		public int? MODIFYID { get; set; }

		/// <summary>
		/// ����
		/// </summary>
		[JsonProperty, Column(StringLength = 50, IsNullable = false)]
		public string PHONENO { get; set; }

		/// <summary>
		/// ��
		/// </summary>
		[JsonProperty, Column(StringLength = 100, IsNullable = false)]
		public string PROVINCE { get; set; }

		[JsonProperty, Column(StringLength = 200)]
		public string REMARK { get; set; }

	}

}
