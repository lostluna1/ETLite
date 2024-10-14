using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class ESPHYSICALADDRESS {

		[JsonProperty, Column(Name = "ES_PHYSICALADDRESSID", DbType = "CHAR(16 BYTE)", IsPrimary = true, IsNullable = false)]
		public string ESPHYSICALADDRESSID { get; set; }

		[JsonProperty]
		public uint? ASSIGNED { get; set; }

		[JsonProperty, Column(DbType = "DATE(7)")]
		public DateTime? ASSIGNEDDATE { get; set; }

		[JsonProperty, Column(DbType = "DATE(7)")]
		public DateTime? ASSIGNEDDATEGMT { get; set; }

		[JsonProperty]
		public uint? CDOTYPEID { get; set; }

		[JsonProperty]
		public uint? CHANGECOUNT { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string CONTAINERID { get; set; }

		[JsonProperty, Column(Name = "ES_ADDRESSPOOLID", DbType = "CHAR(16 BYTE)")]
		public string ESADDRESSPOOLID { get; set; }

		[JsonProperty, Column(Name = "ES_PHYSICALADDRESSNAME", DbType = "VARCHAR2(40 BYTE)")]
		public string ESPHYSICALADDRESSNAME { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(36 BYTE)")]
		public string EXPORTIMPORTKEY { get; set; }

		[JsonProperty]
		public uint? ISFROZEN { get; set; }

	}

}
