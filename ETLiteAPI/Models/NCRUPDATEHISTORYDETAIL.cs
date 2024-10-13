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
	public partial class NCRUPDATEHISTORYDETAIL {

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)", IsPrimary = true, IsNullable = false)]
		public string NCRUPDATEHISTORYDETAILID { get; set; }

		[JsonProperty]
		public uint? CDOTYPEID { get; set; }

		[JsonProperty]
		public uint? CHANGECOUNT { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string CHARGETOSTEPID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string CORRECTIVEACTIONHISTORYID { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(36 BYTE)")]
		public string EXPORTIMPORTKEY { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string FAILUREINVESTIGATIONHISTORYID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string HISTORYID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string INTEGRATIONTXNID { get; set; }

		[JsonProperty]
		public uint? ISPREHISTORY { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string NCRCAUSECODEID { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(2000 BYTE)")]
		public string NCRCOMMENT { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string NCRFAILURETYPEID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string NCRRESOLUTIONID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string NCRUPDATEHISTORYID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string PREVENTIVEACTIONHISTORYID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string RELATEDNONCONFORMANCEID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string TXNID { get; set; }

	}

}
