using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class BIZ_ITEMCHECKLLIST {

		public string BIZ_ITEMCHECKLLISTID { get; set; }

		public uint? BARCODELENGTH { get; set; }

		public string BIZ_ITEMCHECKLLISTNAME { get; set; }

		public string BIZ_LABLECHECKGROUPID { get; set; }

		public string BIZ_LABLECHECKTYPEID { get; set; }

		public uint? CDOTYPEID { get; set; }

		public uint? CHANGECOUNT { get; set; }

		public uint? CHECKENDPOSITION { get; set; }

		public uint? CHECKITEMSEQUENCE { get; set; }

		public uint? CHECKSTARTPOSITION { get; set; }

		public string CHECKVALUE { get; set; }

		public uint? ISFROZEN { get; set; }

	}

}
