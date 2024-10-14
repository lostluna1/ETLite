using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class ROLEPERMISSION {

		public string ROLEPERMISSIONID { get; set; }

		public uint? CDOTYPEID { get; set; }

		public uint? CHANGECOUNT { get; set; }

		public string EXPORTIMPORTKEY { get; set; }

		public uint? ISFROZEN { get; set; }

		public string OBJECTINSTANCEID { get; set; }

		public uint? OBJECTMETAID { get; set; }

		public uint? PERMISSIONTYPE { get; set; }

		public string ROLEID { get; set; }

		public string ROLEPERMISSIONNAME { get; set; }

	}

}
