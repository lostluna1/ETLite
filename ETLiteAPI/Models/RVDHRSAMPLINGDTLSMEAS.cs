using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models {

	[JsonObject(MemberSerialization.OptIn), Table(Name = "RV_DHRSAMPLINGDTLSMEAS", DisableSyncStructure = true)]
	public partial class RVDHRSAMPLINGDTLSMEAS {

		[JsonProperty, Column(DbType = "VARCHAR2(30 BYTE)")]
		public string AQLLEVELNAME { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(100 BYTE)")]
		public string CONTAINERNAME { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(30 BYTE)")]
		public string DATAVALUE { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(30 BYTE)")]
		public string EMPLOYEENAME { get; set; }

		[JsonProperty, Column(Name = "ES_PRIMARYSERIALNUMBER", DbType = "VARCHAR2(100 BYTE)")]
		public string ESPRIMARYSERIALNUMBER { get; set; }

		[JsonProperty, Column(Name = "ES_SERIALNUMBER2", DbType = "VARCHAR2(100 BYTE)")]
		public string ESSERIALNUMBER2 { get; set; }

		[JsonProperty, Column(Name = "ES_SERIALNUMBER3", DbType = "VARCHAR2(100 BYTE)")]
		public string ESSERIALNUMBER3 { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(30 BYTE)")]
		public string INSPECTIONLEVELNAME { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(30 BYTE)")]
		public string LOWERLIMIT { get; set; }

		[JsonProperty, Column(DbType = "CHAR(6 BYTE)")]
		public string PASSFAIL { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(256 BYTE)")]
		public string SAMPLEDATAPOINTNAME { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(256 BYTE)")]
		public string SAMPLETESTNAME { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(8 BYTE)")]
		public string SAMPLETYPE { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(256 BYTE)")]
		public string SAMPLINGPLANNAME { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(30 BYTE)")]
		public string SAMPLINGSTATUS { get; set; }

		[JsonProperty, Column(DbType = "DATE(7)")]
		public DateTime? TXNDATEGMT { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(30 BYTE)")]
		public string UPPERLIMIT { get; set; }

	}

}
