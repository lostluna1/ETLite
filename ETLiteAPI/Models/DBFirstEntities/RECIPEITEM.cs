using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class RECIPEITEM {

		public string RECIPEITEMID { get; set; }

		public uint? ADVANCETONEXTTASK { get; set; }

		public uint? ALLOWMANUALWEIGHOVERRIDE { get; set; }

		public uint? CDOTYPEID { get; set; }

		public uint? CHANGECOUNT { get; set; }

		public string DOCUMENTSETID { get; set; }

		public string ESIGREQUIREMENTID { get; set; }

		public string EXPORTIMPORTKEY { get; set; }

		public string INSTRUCTION { get; set; }

		public uint? ISFROZEN { get; set; }

		public uint? ISMANUALREADINGONLY { get; set; }

		public string MANUALWEIGHESIGREQUIREMENTID { get; set; }

		public uint? MAXITERATIONS { get; set; }

		public uint? MINITERATIONS { get; set; }

		public string RECIPEITEMNAME { get; set; }

		public string RECIPELISTID { get; set; }

		public string RECIPEMATERIALLISTITEMID { get; set; }

		public string REPORTINSTRUCTION { get; set; }

		public string SCALESID { get; set; }

		public uint? SEQUENCE { get; set; }

		public uint? TASKTYPE { get; set; }

		public uint? TASKUSAGE { get; set; }

		public string TRAININGREQGROUPID { get; set; }

		public uint? USEMATERIALFROMBATCH { get; set; }

	}

}
