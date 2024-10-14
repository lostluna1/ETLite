using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class ES_CONFIRMINSTRUCTION {

		public string ES_CONFIRMINSTRUCTIONID { get; set; }

		public uint? CDOTYPEID { get; set; }

		public uint? CHANGECOUNT { get; set; }

		public DateTime? CONFIRMDATEGMT { get; set; }

		public string CONTAINERID { get; set; }

		public string EMPLOYEEID { get; set; }

		public string ES_CONFIRMINSTRUCTIONNAME { get; set; }

		public string INSTRUCTIONID { get; set; }

		public string INSTRUCTIONTEXT { get; set; }

		public uint? ISFROZEN { get; set; }

		public string MFGORDERID { get; set; }

		public string PRODUCTID { get; set; }

		public string WORKFLOWSTEPID { get; set; }

	}

}
