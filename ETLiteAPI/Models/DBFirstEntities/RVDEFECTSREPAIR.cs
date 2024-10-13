using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models {

	[JsonObject(MemberSerialization.OptIn), Table(Name = "RV_DEFECTSREPAIR", DisableSyncStructure = true)]
	public partial class RVDEFECTSREPAIR {

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)", IsNullable = false)]
		public string CONTAINERID { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(100 BYTE)")]
		public string CONTAINERNAME { get; set; }

		[JsonProperty, Column(Name = "ES_BOARDSIDE")]
		public uint? ESBOARDSIDE { get; set; }

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

		[JsonProperty, Column(Name = "ES_SERIALNUMBER2", DbType = "VARCHAR2(100 BYTE)")]
		public string ESSERIALNUMBER2 { get; set; }

		[JsonProperty, Column(Name = "ES_SERIALNUMBER3", DbType = "VARCHAR2(100 BYTE)")]
		public string ESSERIALNUMBER3 { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(30 BYTE)")]
		public string INSPECTUSER { get; set; }

		[JsonProperty, Column(DbType = "DATE(7)")]
		public DateTime? ISCREATEDATE { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(40 BYTE)")]
		public string ISDEFECTREASONNAME { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(40 BYTE)")]
		public string ISDEFECTSEVERITYNAME { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(30 BYTE)")]
		public string ISREFDES { get; set; }

		[JsonProperty, Column(DbType = "DATE(7)")]
		public DateTime? ISREPAIRDATE { get; set; }

		[JsonProperty]
		public uint? ISSTATUS { get; set; }

		[JsonProperty]
		public uint? ISX { get; set; }

		[JsonProperty]
		public uint? ISY { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string PARENTCONTAINERID { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(100 BYTE)")]
		public string PARENTCONTAINERNAME { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(100 BYTE)")]
		public string PARENTPRIMARYSERIALNUMBER { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(128 BYTE)")]
		public string PRODUCTDISPLAY { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(4000 BYTE)")]
		public string REPAIRACTIONS { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(30 BYTE)")]
		public string REPAIRUSER { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(46 BYTE)")]
		public string WORKFLOWSTEPNAME { get; set; }

	}

}
