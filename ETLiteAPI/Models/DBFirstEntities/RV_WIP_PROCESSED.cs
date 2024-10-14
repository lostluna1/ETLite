using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class RV_WIP_PROCESSED {

		public string IDENTIFIER { get; set; }

		public string ISFAILED { get; set; }

		public string MFGORDERNAME { get; set; }

		public DateTime? MOVEINDATE { get; set; }

		public DateTime? MOVEOUTDATE { get; set; }

		public string NEXTSTEP { get; set; }

		public string PREVSTEP { get; set; }

		public decimal? SEQUENCE { get; set; }

		public string STEPDISPLAYNAME { get; set; }

	}

}
