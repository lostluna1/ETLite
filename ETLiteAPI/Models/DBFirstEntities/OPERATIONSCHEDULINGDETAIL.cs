using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class OPERATIONSCHEDULINGDETAIL {

		public string OPERATIONSCHEDULINGDETAILID { get; set; }

		public uint? CDOTYPEID { get; set; }

		public uint? CHANGECOUNT { get; set; }

		public decimal? DURATIONPERUNIT { get; set; }

		public string EXPORTIMPORTKEY { get; set; }

		public decimal? FASTCYCLETIME { get; set; }

		public uint? ISFROZEN { get; set; }

		public decimal? NORMALCYCLETIME { get; set; }

		public string OPERATIONID { get; set; }

		public uint? RUNRATEOPTION { get; set; }

		public decimal? SETUPTIME { get; set; }

		public decimal? STDBATCHSIZE { get; set; }

		public decimal? TIMEPERBATCH { get; set; }

		public decimal? UNITSPERHOUR { get; set; }

		public decimal? UNSCHEDULEDTIME { get; set; }

		public decimal? YIELD { get; set; }

	}

}
