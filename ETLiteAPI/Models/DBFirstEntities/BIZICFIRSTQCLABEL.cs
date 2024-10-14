using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class BIZICFIRSTQCLABEL {

		[JsonProperty, Column(Name = "BIZ_ICFIRSTQCLABELID", DbType = "CHAR(16 BYTE)", IsPrimary = true, IsNullable = false)]
		public string BIZICFIRSTQCLABELID { get; set; }

		/// <summary>
		/// 拼接：工单-人-提交时间
		/// </summary>
		[JsonProperty, Column(Name = "BIZ_ICFIRSTQCLABELNAME", DbType = "VARCHAR2(256 BYTE)")]
		public string BIZICFIRSTQCLABELNAME { get; set; }

		[JsonProperty]
		public uint? CDOTYPEID { get; set; }

		[JsonProperty]
		public uint? CHANGECOUNT { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string CHANGEHISTORYID { get; set; }

		/// <summary>
		/// 9.CheckSum
		/// </summary>
		[JsonProperty, Column(DbType = "VARCHAR2(255 BYTE)")]
		public string CHECKSUM { get; set; }

		/// <summary>
		/// 10.打点颜色
		/// </summary>
		[JsonProperty, Column(DbType = "VARCHAR2(100 BYTE)")]
		public string COLOR { get; set; }

		/// <summary>
		/// 1.创建时间
		/// </summary>
		[JsonProperty, Column(DbType = "DATE(7)")]
		public DateTime? CREATETIME { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(2000 BYTE)")]
		public string DESCRIPTION { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(255 BYTE)")]
		public string FILTERTAGS { get; set; }

		/// <summary>
		/// 11.首件数量
		/// </summary>
		[JsonProperty, Column(Name = "FIRST_QTY", DbType = "NUMBER(22)")]
		public decimal? FIRSTQTY { get; set; }

		/// <summary>
		/// 8.IC料号  实际放对应的FidderPlan的id
		/// </summary>
		[JsonProperty, Column(Name = "IC_PRODUCT", DbType = "VARCHAR2(100 BYTE)")]
		public string ICPRODUCT { get; set; }

		[JsonProperty]
		public uint? ICONID { get; set; }

		/// <summary>
		/// 13.是否有效 
		/// </summary>
		[JsonProperty]
		public uint? ISENABLED { get; set; }

		[JsonProperty]
		public uint? ISFROZEN { get; set; }

		/// <summary>
		/// 2.最后更新时间
		/// </summary>
		[JsonProperty, Column(DbType = "DATE(7)")]
		public DateTime? LASTUPDATETIME { get; set; }

		/// <summary>
		/// 3，最后更新人
		/// </summary>
		[JsonProperty, Column(DbType = "VARCHAR2(100 BYTE)")]
		public string LASTUPDATEUSER { get; set; }

		/// <summary>
		/// 6.机器组
		/// </summary>
		[JsonProperty, Column(DbType = "VARCHAR2(100 BYTE)")]
		public string MACHINEGROUP { get; set; }

		/// <summary>
		/// 7.工单
		/// </summary>
		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string MFGORDERID { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(2000 BYTE)")]
		public string NOTES { get; set; }

		/// <summary>
		/// 4.工单料的id，暂空
		/// </summary>
		[JsonProperty, Column(DbType = "VARCHAR2(100 BYTE)")]
		public string PCBAPRODUCT { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string PCBAPRODUCTID { get; set; }

		/// <summary>
		/// 14.QC确认人id
		/// </summary>
		[JsonProperty, Column(Name = "QC_CONFIRMERID", DbType = "CHAR(16 BYTE)")]
		public string QCCONFIRMERID { get; set; }

		/// <summary>
		/// 15.确认时间
		/// </summary>
		[JsonProperty, Column(Name = "QC_TIME", DbType = "DATE(7)")]
		public DateTime? QCTIME { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string SETUPACCESSID { get; set; }

		/// <summary>
		/// 12.烧录人
		/// </summary>
		[JsonProperty, Column(Name = "SL_OPERATOR", DbType = "VARCHAR2(100 BYTE)")]
		public string SLOPERATOR { get; set; }

		/// <summary>
		/// 5.日期
		/// </summary>
		[JsonProperty, Column(DbType = "DATE(7)")]
		public DateTime? SUBMITDATE { get; set; }

	}

}
