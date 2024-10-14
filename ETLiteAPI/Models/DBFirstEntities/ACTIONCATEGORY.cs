using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class ACTIONCATEGORY {

		public string ACTIONCATEGORYID { get; set; }

		public string ACTIONCATEGORYNAME { get; set; }

		public uint? CDOTYPEID { get; set; }

		public uint? CHANGECOUNT { get; set; }

		public string CHANGEHISTORYID { get; set; }

		public string DESCRIPTION { get; set; }

		public string FILTERTAGS { get; set; }

		public uint? ICONID { get; set; }

		public uint? ISFROZEN { get; set; }

		public string LABELNAME { get; set; }

		public string LABELTEXT { get; set; }

		public string NOTES { get; set; }

		public uint? SEQUENCE { get; set; }

		public string SETUPACCESSID { get; set; }

	}

}
