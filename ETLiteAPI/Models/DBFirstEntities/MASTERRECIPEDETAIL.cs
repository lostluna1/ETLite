using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class MASTERRECIPEDETAIL {

		public string MASTERRECIPEDETAILID { get; set; }

		public uint? CDOTYPEID { get; set; }

		public uint? CHANGECOUNT { get; set; }

		public string EXPORTIMPORTKEY { get; set; }

		public uint? ISFROZEN { get; set; }

		public string MASTERRECIPEID { get; set; }

		public uint? SEQUENCE { get; set; }

		public string SPECBASEID { get; set; }

		public string SPECID { get; set; }

		public uint? SUBSEQUENCE { get; set; }

		public string TASKLISTBASEID { get; set; }

		public string TASKLISTID { get; set; }

	}

}
