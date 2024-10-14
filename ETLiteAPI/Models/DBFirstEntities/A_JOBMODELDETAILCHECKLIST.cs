using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class A_JOBMODELDETAILCHECKLIST {

		public string JOBMODELDETAILCHECKLISTID { get; set; }

		public uint? CDOTYPEID { get; set; }

		public uint? CHANGECOUNT { get; set; }

		public string CHECKLISTID { get; set; }

		public uint? CHECKLISTSEQUENCE { get; set; }

		public string DATACOLLECTIONDEFBASEID { get; set; }

		public string DATACOLLECTIONDEFID { get; set; }

		public string DOCUMENTSETID { get; set; }

		public string EXPORTIMPORTKEY { get; set; }

		public string INSTRUCTION { get; set; }

		public uint? ISFROZEN { get; set; }

		public string JOBMODELDETAILID { get; set; }

	}

}
