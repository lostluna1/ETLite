using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class RPEQPTACCOUNTREPORT {

		[JsonProperty, Column(Name = "BIZ_ASSETDEPT", DbType = "VARCHAR2(30 BYTE)")]
		public string BIZASSETDEPT { get; set; }

		[JsonProperty, Column(Name = "BIZ_ASSETDES", DbType = "VARCHAR2(255 BYTE)")]
		public string BIZASSETDES { get; set; }

		[JsonProperty, Column(Name = "BIZ_ASSETOWNER1", DbType = "VARCHAR2(30 BYTE)")]
		public string BIZASSETOWNER1 { get; set; }

		[JsonProperty, Column(Name = "BIZ_ASSETOWNER2", DbType = "VARCHAR2(30 BYTE)")]
		public string BIZASSETOWNER2 { get; set; }

		[JsonProperty, Column(Name = "BIZ_ASSETOWNER3", DbType = "VARCHAR2(30 BYTE)")]
		public string BIZASSETOWNER3 { get; set; }

		[JsonProperty, Column(Name = "BIZ_EQUIPSTATUSNAME", DbType = "VARCHAR2(64 BYTE)")]
		public string BIZEQUIPSTATUSNAME { get; set; }

		[JsonProperty, Column(Name = "BIZ_SAPASSETCODE", DbType = "VARCHAR2(30 BYTE)")]
		public string BIZSAPASSETCODE { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(30 BYTE)")]
		public string FACTORYNAME { get; set; }

		[JsonProperty, Column(Name = "FAMILY_DESCRIPTION", DbType = "VARCHAR2(255 BYTE)")]
		public string FAMILYDESCRIPTION { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(40 BYTE)")]
		public string PHYSICALLOCATIONNAME { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(40 BYTE)")]
		public string PHYSICALPOSITIONNAME { get; set; }

		[JsonProperty, Column(Name = "RESC_DESCRIPTION", DbType = "VARCHAR2(255 BYTE)")]
		public string RESCDESCRIPTION { get; set; }

		[JsonProperty, Column(Name = "RESC_FAMILY", DbType = "VARCHAR2(40 BYTE)")]
		public string RESCFAMILY { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(40 BYTE)")]
		public string RESOURCEGROUPNAME { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(100 BYTE)")]
		public string RESOURCENAME { get; set; }

		[JsonProperty, Column(Name = "SAP_EFFECTIVE_DATE", DbType = "DATE(7)")]
		public DateTime? SAPEFFECTIVEDATE { get; set; }

	}

}
