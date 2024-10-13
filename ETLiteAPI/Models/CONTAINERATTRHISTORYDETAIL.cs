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
	public partial class CONTAINERATTRHISTORYDETAIL {

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)", IsPrimary = true, IsNullable = false)]
		public string CONTAINERATTRHISTORYDETAILID { get; set; }

		[JsonProperty, Column(Name = "ATTRIBUTENAME_AFTER", DbType = "VARCHAR2(255 BYTE)")]
		public string ATTRIBUTENAMEAFTER { get; set; }

		[JsonProperty, Column(Name = "ATTRIBUTENAME_BEFORE", DbType = "VARCHAR2(255 BYTE)")]
		public string ATTRIBUTENAMEBEFORE { get; set; }

		[JsonProperty, Column(Name = "ATTRIBUTEVALUE_AFTER", DbType = "VARCHAR2(2000 BYTE)")]
		public string ATTRIBUTEVALUEAFTER { get; set; }

		[JsonProperty, Column(Name = "ATTRIBUTEVALUE_BEFORE", DbType = "VARCHAR2(2000 BYTE)")]
		public string ATTRIBUTEVALUEBEFORE { get; set; }

		[JsonProperty]
		public uint? CDOTYPEID { get; set; }

		[JsonProperty]
		public uint? CHANGECOUNT { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string CONTAINERATTRMAINTHISTORYID { get; set; }

		[JsonProperty, Column(Name = "DATATYPE_AFTER")]
		public uint? DATATYPEAFTER { get; set; }

		[JsonProperty, Column(Name = "DATATYPE_BEFORE")]
		public uint? DATATYPEBEFORE { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(36 BYTE)")]
		public string EXPORTIMPORTKEY { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string HISTORYID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string INTEGRATIONTXNID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string TXNID { get; set; }

	}

}
