using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class SECURITYCACHEREFRESHREQUEST {

		public uint SECURITYCACHEREFRESHREQUESTID { get; set; }

		public DateTime? CREATEDDATE { get; set; }

		public DateTime? CREATEDDATEGMT { get; set; }

		public string ENTITYNAME { get; set; }

		public uint? ENTITYTYPE { get; set; }

	}

}
