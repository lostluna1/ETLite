using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class TASKITEM {

		public string TASKITEMID { get; set; }

		public uint? ADVANCETONEXTTASK { get; set; }

		public uint? CDOTYPEID { get; set; }

		public uint? CHANGECOUNT { get; set; }

		public string COMPUTATIONID { get; set; }

		public string DATACOLLECTIONDEFBASEID { get; set; }

		public string DATACOLLECTIONDEFID { get; set; }

		public string DOCUMENTSETID { get; set; }

		public string ESIGREQUIREMENTID { get; set; }

		public string EXPORTIMPORTKEY { get; set; }

		public string INSTRUCTION { get; set; }

		public uint? INSTRUCTIONTYPE { get; set; }

		public uint? ISFROZEN { get; set; }

		public uint? MAXITERATIONS { get; set; }

		public uint? MINITERATIONS { get; set; }

		public string REPORTINSTRUCTION { get; set; }

		public uint? SEQUENCE { get; set; }

		public string TASKITEMNAME { get; set; }

		public string TASKLISTID { get; set; }

		public uint? TASKTYPE { get; set; }

		public uint? TASKUSAGE { get; set; }

		public string TRAININGREQGROUPID { get; set; }

		public string TRANSACTIONPAGEID { get; set; }

	}

}
