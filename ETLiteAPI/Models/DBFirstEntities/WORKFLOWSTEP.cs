using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class WORKFLOWSTEP {

		public string WORKFLOWSTEPID { get; set; }

		public uint? CDOTYPEID { get; set; }

		public uint? CHANGECOUNT { get; set; }

		public string DEFAULTPATHID { get; set; }

		public string DESCRIPTION { get; set; }

		public string EXPORTIMPORTKEY { get; set; }

		public uint? ICONID { get; set; }

		public uint? ISFROZEN { get; set; }

		public uint? ISLASTSTEP { get; set; }

		public string ISROUTESTEPNAME { get; set; }

		public string ISSCHDROUTESTEPNAME { get; set; }

		public string NOTES { get; set; }

		public uint? ONDEFAULTROUTE { get; set; }

		public string ROUTESTEPID { get; set; }

		public string SCHEDULINGDETAILID { get; set; }

		public string SCHEDULINGROUTESTEPID { get; set; }

		public uint? SEQUENCE { get; set; }

		public string SPECBASEID { get; set; }

		public string SPECID { get; set; }

		public uint? STEPTYPE { get; set; }

		public string SUBWORKFLOWBASEID { get; set; }

		public string SUBWORKFLOWID { get; set; }

		public string WIPMSGLABEL { get; set; }

		public string WORKFLOWID { get; set; }

		public string WORKFLOWSTEPNAME { get; set; }

		public uint? XLOCATION { get; set; }

		public uint? YLOCATION { get; set; }

	}

}
