using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class BIZ_ICFIRSTQCLABEL {

		public string BIZ_ICFIRSTQCLABELID { get; set; }

		/// <summary>
		/// 拼接：工单-人-提交时间
		/// </summary>
		public string BIZ_ICFIRSTQCLABELNAME { get; set; }

		public uint? CDOTYPEID { get; set; }

		public uint? CHANGECOUNT { get; set; }

		public string CHANGEHISTORYID { get; set; }

		/// <summary>
		/// 9.CheckSum
		/// </summary>
		public string CHECKSUM { get; set; }

		/// <summary>
		/// 10.打点颜色
		/// </summary>
		public string COLOR { get; set; }

		/// <summary>
		/// 1.创建时间
		/// </summary>
		public DateTime? CREATETIME { get; set; }

		public string DESCRIPTION { get; set; }

		public string FILTERTAGS { get; set; }

		/// <summary>
		/// 11.首件数量
		/// </summary>
		public decimal? FIRST_QTY { get; set; }

		/// <summary>
		/// 8.IC料号  实际放对应的FidderPlan的id
		/// </summary>
		public string IC_PRODUCT { get; set; }

		public uint? ICONID { get; set; }

		/// <summary>
		/// 13.是否有效 
		/// </summary>
		public uint? ISENABLED { get; set; }

		public uint? ISFROZEN { get; set; }

		/// <summary>
		/// 2.最后更新时间
		/// </summary>
		public DateTime? LASTUPDATETIME { get; set; }

		/// <summary>
		/// 3，最后更新人
		/// </summary>
		public string LASTUPDATEUSER { get; set; }

		/// <summary>
		/// 6.机器组
		/// </summary>
		public string MACHINEGROUP { get; set; }

		/// <summary>
		/// 7.工单
		/// </summary>
		public string MFGORDERID { get; set; }

		public string NOTES { get; set; }

		/// <summary>
		/// 4.工单料的id，暂空
		/// </summary>
		public string PCBAPRODUCT { get; set; }

		public string PCBAPRODUCTID { get; set; }

		/// <summary>
		/// 14.QC确认人id
		/// </summary>
		public string QC_CONFIRMERID { get; set; }

		/// <summary>
		/// 15.确认时间
		/// </summary>
		public DateTime? QC_TIME { get; set; }

		public string SETUPACCESSID { get; set; }

		/// <summary>
		/// 12.烧录人
		/// </summary>
		public string SL_OPERATOR { get; set; }

		/// <summary>
		/// 5.日期
		/// </summary>
		public DateTime? SUBMITDATE { get; set; }

	}

}
