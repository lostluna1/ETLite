using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class AS_ERPROUTE {

		public decimal? BIZ_ACTIVETIME { get; set; }

		public string BIZ_ATUOM { get; set; }

		public string BIZ_BASEUOM { get; set; }

		public DateTime? BIZ_EFFECTIVEFROMDATE { get; set; }

		public DateTime? BIZ_EFFECTIVETHROUGHDATE { get; set; }

		public decimal? BIZ_EQTTIME { get; set; }

		public string BIZ_ETUOM { get; set; }

		public decimal? BIZ_MANTIME { get; set; }

		public string BIZ_MTUOM { get; set; }

		public decimal? BIZ_PREPARETIME { get; set; }

		public string BIZ_PRETUOM { get; set; }

		public decimal? BIZ_PRODCOSTSTIME { get; set; }

		public string BIZ_PROTUOM { get; set; }

		public decimal? BIZ_STAQTY { get; set; }

		public string BIZ_WORKCENTER { get; set; }

		public string DESCRIPTION { get; set; }

		public string ERPOPERATION { get; set; }

		public string ERPROUTE { get; set; }

		public string PRODUCT { get; set; }

		public string REVISION { get; set; }

		public string ROUTESTEPDESCRIPTION { get; set; }

		public string ROUTESTEPNAME { get; set; }

		public string SEQUENCE { get; set; }

		public uint? STATUS { get; set; }

	}

}
