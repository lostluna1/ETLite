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
	public partial class EVENTCHECKBOXFIELDHISTDETAIL {

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)", IsPrimary = true, IsNullable = false)]
		public string EVENTCHECKBOXFIELDHISTDETAILID { get; set; }

		[JsonProperty]
		public uint? CDOTYPEID { get; set; }

		[JsonProperty]
		public uint? CHANGECOUNT { get; set; }

		[JsonProperty]
		public uint? COMPANYREPRESENTATIVE { get; set; }

		[JsonProperty]
		public uint? CONSUMER { get; set; }

		[JsonProperty]
		public uint? DEATH { get; set; }

		[JsonProperty]
		public uint? DISTRIBUTOR { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(30 BYTE)")]
		public string EVALUATIONCODE { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string EVENTDATAHISTORYDETAILID { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(36 BYTE)")]
		public string EXPORTIMPORTKEY { get; set; }

		[JsonProperty]
		public uint? FOREIGNSOURCE { get; set; }

		[JsonProperty]
		public uint? HEALTHPROFESSIONAL { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string HISTORYID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string INTEGRATIONTXNID { get; set; }

		[JsonProperty]
		public uint? LAYUSERPATIENT { get; set; }

		[JsonProperty]
		public uint? LITERATURE { get; set; }

		[JsonProperty]
		public uint? MALFUNCTION { get; set; }

		[JsonProperty]
		public uint? NOFIELD { get; set; }

		[JsonProperty]
		public uint? NOTRETURNED { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string OCCUPATIONID { get; set; }

		[JsonProperty]
		public uint? OTHER { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(30 BYTE)")]
		public string OTHERTEXT { get; set; }

		[JsonProperty, Column(DbType = "DATE(7)")]
		public DateTime? RETURNEDDATE { get; set; }

		[JsonProperty, Column(DbType = "DATE(7)")]
		public DateTime? RETURNEDDATEGMT { get; set; }

		[JsonProperty]
		public uint? SERIOUSINJURY { get; set; }

		[JsonProperty]
		public uint? STUDY { get; set; }

		[JsonProperty]
		public uint? SUMMARYATTACHED { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string TXNID { get; set; }

		[JsonProperty]
		public uint? UNK { get; set; }

		[JsonProperty]
		public uint? USERFACILITY { get; set; }

		[JsonProperty]
		public uint? YES { get; set; }

	}

}
