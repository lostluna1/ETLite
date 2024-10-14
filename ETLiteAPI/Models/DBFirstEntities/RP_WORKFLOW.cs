using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class RP_WORKFLOW {

		public string DESCRIPTION { get; set; }

		public decimal? FASTCYCLETIME { get; set; }

		public string FORMSTEPID { get; set; }

		public decimal? FORWARDCYCLETIME { get; set; }

		public decimal? FORWARDYIELD { get; set; }

		public decimal? ISDEFAULT { get; set; }

		public uint? ISLASTSTEP { get; set; }

		public decimal? NORMALCYCLETIME { get; set; }

		public uint? RUNRATEOPTION { get; set; }

		public uint? SEQUENCE { get; set; }

		public decimal? SETUPTIME { get; set; }

		public string SPECBASEID { get; set; }

		public string SPECID { get; set; }

		public decimal? STDBATCHSIZE { get; set; }

		public decimal? TIMEPERBATCH { get; set; }

		public string TOSTEPID { get; set; }

		public decimal? UNITSPERHOUR { get; set; }

		public decimal? UNSCHEDULEDTIME { get; set; }

		public string WORKFLOWID { get; set; }

		public string WORKFLOWNAME { get; set; }

		public string WORKFLOWSTEPNAME { get; set; }

		public decimal? YIELD { get; set; }

	}

}
