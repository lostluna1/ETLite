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
	public partial class ISCURRENTDEFECTS {

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)", IsPrimary = true, IsNullable = false)]
		public string ISCURRENTDEFECTSID { get; set; }

		[JsonProperty]
		public uint? CDOTYPEID { get; set; }

		[JsonProperty]
		public uint? CHANGECOUNT { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string CONTAINERID { get; set; }

		[JsonProperty, Column(Name = "ES_ASSEMBLYSHAPE", DbType = "VARCHAR2(100 BYTE)")]
		public string ESASSEMBLYSHAPE { get; set; }

		[JsonProperty, Column(Name = "ES_AUTOINSPECTTIMESTAMP", DbType = "DATE(7)")]
		public DateTime? ESAUTOINSPECTTIMESTAMP { get; set; }

		[JsonProperty, Column(Name = "ES_BOARDSIDE")]
		public uint? ESBOARDSIDE { get; set; }

		[JsonProperty, Column(Name = "ES_HVISSUEKEY", DbType = "VARCHAR2(100 BYTE)")]
		public string ESHVISSUEKEY { get; set; }

		[JsonProperty, Column(Name = "ES_ISSUEACTUALSHISTORYID", DbType = "CHAR(16 BYTE)")]
		public string ESISSUEACTUALSHISTORYID { get; set; }

		[JsonProperty, Column(Name = "ES_NET1", DbType = "VARCHAR2(64 BYTE)")]
		public string ESNET1 { get; set; }

		[JsonProperty, Column(Name = "ES_NET2", DbType = "VARCHAR2(64 BYTE)")]
		public string ESNET2 { get; set; }

		[JsonProperty, Column(Name = "ES_PCBNUMBER")]
		public uint? ESPCBNUMBER { get; set; }

		[JsonProperty, Column(Name = "ES_PIN", DbType = "VARCHAR2(64 BYTE)")]
		public string ESPIN { get; set; }

		[JsonProperty, Column(Name = "ES_PIN2", DbType = "VARCHAR2(64 BYTE)")]
		public string ESPIN2 { get; set; }

		[JsonProperty, Column(Name = "ES_PRIMARYSERIALNUMBER", DbType = "VARCHAR2(100 BYTE)")]
		public string ESPRIMARYSERIALNUMBER { get; set; }

		[JsonProperty, Column(Name = "ES_SEGMENT1X1")]
		public uint? ESSEGMENT1X1 { get; set; }

		[JsonProperty, Column(Name = "ES_SEGMENT1X2")]
		public uint? ESSEGMENT1X2 { get; set; }

		[JsonProperty, Column(Name = "ES_SEGMENT1Y1")]
		public uint? ESSEGMENT1Y1 { get; set; }

		[JsonProperty, Column(Name = "ES_SEGMENT1Y2")]
		public uint? ESSEGMENT1Y2 { get; set; }

		[JsonProperty, Column(Name = "ES_SEGMENT2X1")]
		public uint? ESSEGMENT2X1 { get; set; }

		[JsonProperty, Column(Name = "ES_SEGMENT2X2")]
		public uint? ESSEGMENT2X2 { get; set; }

		[JsonProperty, Column(Name = "ES_SEGMENT2Y1")]
		public uint? ESSEGMENT2Y1 { get; set; }

		[JsonProperty, Column(Name = "ES_SEGMENT2Y2")]
		public uint? ESSEGMENT2Y2 { get; set; }

		[JsonProperty, Column(Name = "ES_SYMPTOM", DbType = "VARCHAR2(255 BYTE)")]
		public string ESSYMPTOM { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(255 BYTE)")]
		public string EXPORTIMPORTKEY { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string ISCONTAINERID { get; set; }

		[JsonProperty, Column(DbType = "DATE(7)")]
		public DateTime? ISCREATEDATE { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(30 BYTE)")]
		public string ISCURRENTDEFECTSIDSTRING { get; set; }

		[JsonProperty]
		public uint? ISDEFECTHASHISTORY { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string ISDEFECTHISTORYDETAILID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string ISDEFECTREASONID { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(36 BYTE)")]
		public string ISGUID { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(2000 BYTE)")]
		public string ISINSPECTNOTE { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string ISINSPECTUSERID { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(255 BYTE)")]
		public string ISLOTNUMBER { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string ISMFGORDERID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string ISOPERATIONID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string ISPRODUCTID { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(30 BYTE)")]
		public string ISREFDES { get; set; }

		[JsonProperty, Column(DbType = "DATE(7)")]
		public DateTime? ISREPAIRDATE { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(2000 BYTE)")]
		public string ISREPAIRNOTES { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string ISREPAIROPERATIONID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string ISREPAIRRESOURCEID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string ISREPAIRSPECID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string ISREPAIRUSERID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string ISRESOURCEID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string ISSEVERITYID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string ISSPECID { get; set; }

		[JsonProperty]
		public uint? ISSTATUS { get; set; }

		[JsonProperty]
		public uint? ISSTEPPASS { get; set; }

		[JsonProperty, Column(DbType = "DATE(7)")]
		public DateTime? ISUPDATEDATE { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string ISWORKFLOWID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string ISWORKFLOWSTEPID { get; set; }

		[JsonProperty]
		public uint? ISX { get; set; }

		[JsonProperty]
		public uint? ISY { get; set; }

	}

}
