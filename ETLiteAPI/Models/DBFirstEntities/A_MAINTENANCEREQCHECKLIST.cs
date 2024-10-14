using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class A_MAINTENANCEREQCHECKLIST {

		public string MAINTENANCEREQCHECKLISTID { get; set; }

		public uint? CDOTYPEID { get; set; }

		public uint? CHANGECOUNT { get; set; }

		public string CHECKLISTID { get; set; }

		public uint? CHECKLISTSEQUENCE { get; set; }

		public string DATACOLLECTIONDEFBASEID { get; set; }

		public string DATACOLLECTIONDEFID { get; set; }

		public string DESCRIPTION { get; set; }

		public string EMPLOYEEGROUPID { get; set; }

		public string EXPORTIMPORTKEY { get; set; }

		public string INSTRUCTION { get; set; }

		public uint? ISFROZEN { get; set; }

		public string MAINTENANCEREQID { get; set; }

		public string NOTES { get; set; }

		public uint? SINGLEONLY { get; set; }

	}

}
