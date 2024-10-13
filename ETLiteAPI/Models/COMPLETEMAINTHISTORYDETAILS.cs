using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models {

	[JsonObject(MemberSerialization.OptIn), Table(DisableSyncStructure = true)]
	public partial class COMPLETEMAINTHISTORYDETAILS {

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)", IsPrimary = true, IsNullable = false)]
		public string COMPLETEMAINTHISTORYDETAILSID { get; set; }

		[JsonProperty]
		public uint? CDOTYPEID { get; set; }

		[JsonProperty]
		public uint? CHANGECOUNT { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(255 BYTE)")]
		public string COMMENTS { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string COMPLETEMAINTENANCEHISTORYID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string DATACOLLECTIONDEFID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string DOCUMENTSETID { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(36 BYTE)")]
		public string EXPORTIMPORTKEY { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string HISTORYID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string INTEGRATIONTXNID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string JOBID { get; set; }

		[JsonProperty, Column(DbType = "DATE(7)")]
		public DateTime? LASTDATEDUE { get; set; }

		[JsonProperty, Column(DbType = "DATE(7)")]
		public DateTime? LASTDATEDUEGMT { get; set; }

		[JsonProperty, Column(DbType = "DATE(7)")]
		public DateTime? LASTDATELIMIT { get; set; }

		[JsonProperty, Column(DbType = "DATE(7)")]
		public DateTime? LASTDATELIMITGMT { get; set; }

		[JsonProperty, Column(DbType = "DATE(7)")]
		public DateTime? LASTDATEWARNING { get; set; }

		[JsonProperty, Column(DbType = "DATE(7)")]
		public DateTime? LASTDATEWARNINGGMT { get; set; }

		[JsonProperty, Column(DbType = "NUMBER(22)")]
		public decimal? LASTTHRUPUTQTY2DUE { get; set; }

		[JsonProperty, Column(DbType = "NUMBER(22)")]
		public decimal? LASTTHRUPUTQTY2LIMIT { get; set; }

		[JsonProperty, Column(DbType = "NUMBER(22)")]
		public decimal? LASTTHRUPUTQTY2WARNING { get; set; }

		[JsonProperty, Column(DbType = "NUMBER(22)")]
		public decimal? LASTTHRUPUTQTYDUE { get; set; }

		[JsonProperty, Column(DbType = "NUMBER(22)")]
		public decimal? LASTTHRUPUTQTYLIMIT { get; set; }

		[JsonProperty, Column(DbType = "NUMBER(22)")]
		public decimal? LASTTHRUPUTQTYWARNING { get; set; }

		[JsonProperty]
		public uint? MAINTENANCECOMPLETED { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string MAINTENANCEREQID { get; set; }

		[JsonProperty, Column(DbType = "DATE(7)")]
		public DateTime? SCHEDULEDATE { get; set; }

		[JsonProperty, Column(DbType = "DATE(7)")]
		public DateTime? SCHEDULEDATEGMT { get; set; }

		[JsonProperty, Column(DbType = "DATE(7)")]
		public DateTime? SCHEDULEDATELIMIT { get; set; }

		[JsonProperty, Column(DbType = "DATE(7)")]
		public DateTime? SCHEDULEDATELIMITGMT { get; set; }

		[JsonProperty, Column(DbType = "DATE(7)")]
		public DateTime? SCHEDULEDATEWARNING { get; set; }

		[JsonProperty, Column(DbType = "DATE(7)")]
		public DateTime? SCHEDULEDATEWARNINGGMT { get; set; }

		[JsonProperty, Column(DbType = "NUMBER(22)")]
		public decimal? THRUPUTQTY { get; set; }

		[JsonProperty, Column(DbType = "NUMBER(22)")]
		public decimal? THRUPUTQTY2 { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string TXNID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string UOM2ID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string UOMID { get; set; }

	}

}
