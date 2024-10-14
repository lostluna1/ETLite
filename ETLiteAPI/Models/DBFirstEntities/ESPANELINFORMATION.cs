using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class ESPANELINFORMATION {

		[JsonProperty, Column(Name = "ES_PANELINFORMATIONID", DbType = "CHAR(16 BYTE)", IsPrimary = true, IsNullable = false)]
		public string ESPANELINFORMATIONID { get; set; }

		[JsonProperty]
		public uint? CDOTYPEID { get; set; }

		[JsonProperty]
		public uint? CHANGECOUNT { get; set; }

		[JsonProperty, Column(Name = "ES_CADDESIGNID", DbType = "VARCHAR2(30 BYTE)")]
		public string ESCADDESIGNID { get; set; }

		[JsonProperty, Column(Name = "ES_NPIJOBID", DbType = "CHAR(16 BYTE)")]
		public string ESNPIJOBID { get; set; }

		[JsonProperty, Column(Name = "ES_PANELINFORMATIONNAME", DbType = "VARCHAR2(36 BYTE)")]
		public string ESPANELINFORMATIONNAME { get; set; }

		[JsonProperty, Column(Name = "ES_PCBNUMBER")]
		public uint? ESPCBNUMBER { get; set; }

		[JsonProperty, Column(Name = "ES_PCBSIDE")]
		public uint? ESPCBSIDE { get; set; }

		[JsonProperty, Column(Name = "ES_ROTATION")]
		public uint? ESROTATION { get; set; }

		[JsonProperty, Column(Name = "ES_XLOCATION")]
		public uint? ESXLOCATION { get; set; }

		[JsonProperty, Column(Name = "ES_YLOCATION")]
		public uint? ESYLOCATION { get; set; }

		[JsonProperty]
		public uint? ISFROZEN { get; set; }

	}

}
