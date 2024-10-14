using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class BIZ_LABLECHECKLIST {

		public string BIZ_LABLECHECKLISTID { get; set; }

		public string BIZ_LABLECHECKGROUPID { get; set; }

		public string BIZ_LABLECHECKLISTNAME { get; set; }

		public string BIZ_LABLECHECKPLANID { get; set; }

		public uint? CDOTYPEID { get; set; }

		public uint? CHANGECOUNT { get; set; }

		public string CUSTOMERID { get; set; }

		public uint? ISFROZEN { get; set; }

		public string LABLEITEMNAME { get; set; }

		public uint? SEQUENCE { get; set; }

		public string SPECID { get; set; }

	}

}
