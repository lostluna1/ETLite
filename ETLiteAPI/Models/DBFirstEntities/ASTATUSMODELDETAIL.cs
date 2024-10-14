using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class ASTATUSMODELDETAIL {

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)", IsPrimary = true, IsNullable = false)]
		public string STATUSMODELDETAILID { get; set; }

		[JsonProperty]
		public uint? AUTOSETAVAILABILITY { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(4000 BYTE)")]
		public string AUTOSETPRECONDITION { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(4000 BYTE)")]
		public string AUTOSETPRECONDITIONFORCHILD { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(4000 BYTE)")]
		public string AUTOSETPRECONDITIONFORPARENT { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string AUTOSETREASONID { get; set; }

		[JsonProperty]
		public uint? CDOTYPEID { get; set; }

		[JsonProperty]
		public uint? CHANGECOUNT { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(36 BYTE)")]
		public string EXPORTIMPORTKEY { get; set; }

		[JsonProperty]
		public uint? ISFROZEN { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string RESOURCESTATUSMODELID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string STATUSID { get; set; }

		[JsonProperty]
		public uint? STATUSSEQUENCE { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string TOSTATUSID { get; set; }

	}

}
