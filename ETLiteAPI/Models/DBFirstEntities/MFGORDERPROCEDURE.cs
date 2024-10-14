using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class MFGORDERPROCEDURE {

		public string MFGORDERPROCEDUREID { get; set; }

		public uint? CDOTYPEID { get; set; }

		public uint? CHANGECOUNT { get; set; }

		public string CHANGEHISTORYID { get; set; }

		public string COMPLETEDORDERSTATUSID { get; set; }

		public string DESCRIPTION { get; set; }

		public uint? DISPLAYMODE { get; set; }

		public string ECO { get; set; }

		public uint? EXECUTIONMODE { get; set; }

		public string FILTERTAGS { get; set; }

		public uint? ICONID { get; set; }

		public uint? ISFROZEN { get; set; }

		public string MFGORDERPROCEDUREBASEID { get; set; }

		public string NOTES { get; set; }

		public string REVISION { get; set; }

		public uint? STATUS { get; set; }

		public decimal? TARGETTIME { get; set; }

		public string WIPMSGDEFMGRID { get; set; }

	}

}
