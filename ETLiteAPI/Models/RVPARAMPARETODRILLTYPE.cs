using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models {

	[JsonObject(MemberSerialization.OptIn), Table(Name = "RV_PARAM_PARETODRILLTYPE", DisableSyncStructure = true)]
	public partial class RVPARAMPARETODRILLTYPE {

		[JsonProperty, Column(DbType = "VARCHAR2(4000 BYTE)")]
		public string VIEWNAME { get; set; }

	}

}
