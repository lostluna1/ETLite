using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class SESSIONVALUES {

		public string SESSIONVALUESID { get; set; }

		public uint? APPLICATION { get; set; }

		public uint? CDOTYPEID { get; set; }

		public uint? CHANGECOUNT { get; set; }

		public uint? CLIENT { get; set; }

		public string EMPLOYEEID { get; set; }

		public uint? ENTERPRISEICONID { get; set; }

		public string EXPORTIMPORTKEY { get; set; }

		public uint? FACTORYICONID { get; set; }

		public string FACTORYID { get; set; }

		public uint? ISFROZEN { get; set; }

		public uint? LOCATIONICONID { get; set; }

		public string OPERATIONID { get; set; }

		public string RESOURCEID { get; set; }

		public uint? SERVICETYPEID { get; set; }

		public string SPECID { get; set; }

		public uint? WORKCENTERICONID { get; set; }

		public string WORKCENTERID { get; set; }

		public string WORKSTATIONID { get; set; }

	}

}
