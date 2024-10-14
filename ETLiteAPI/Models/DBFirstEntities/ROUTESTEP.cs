using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class ROUTESTEP {

		public string ROUTESTEPID { get; set; }

		public decimal? BIZ_ACTIVETIME { get; set; }

		public string BIZ_ATUOMID { get; set; }

		public string BIZ_BASEUOMID { get; set; }

		public decimal? BIZ_EQTTIME { get; set; }

		public string BIZ_ETUOMID { get; set; }

		public decimal? BIZ_MANTIME { get; set; }

		public string BIZ_MTUOMID { get; set; }

		public decimal? BIZ_PREPARETIME { get; set; }

		public string BIZ_PRETUOMID { get; set; }

		public decimal? BIZ_PRODCOSTSTIME { get; set; }

		public string BIZ_PROTUOMID { get; set; }

		public decimal? BIZ_STAQTY { get; set; }

		public string BIZ_WORKCENTER { get; set; }

		public uint? CDOTYPEID { get; set; }

		public uint? CHANGECOUNT { get; set; }

		public string DESCRIPTION { get; set; }

		public string ERPOPERATION { get; set; }

		public string ERPROUTEID { get; set; }

		public uint? ES_STARTVIRTUALSN { get; set; }

		public string EXPORTIMPORTKEY { get; set; }

		public decimal? ISDURATIONPERUNIT { get; set; }

		public uint? ISFROZEN { get; set; }

		public uint? ISRUNRATEOPTION { get; set; }

		public decimal? ISSETUPTIME { get; set; }

		public DateTime? ISSMTDATE { get; set; }

		public uint? ISSMTSIDE { get; set; }

		public decimal? ISTIMEPERBATCH { get; set; }

		public decimal? ISTRANSFERQTY { get; set; }

		public uint? ISTRANSFERTYPE { get; set; }

		public decimal? ISUNITSPERHOUR { get; set; }

		public decimal? ISUNSCHEDULEDTIME { get; set; }

		public string NAME { get; set; }

		public string SCHEDULINGOPERATION { get; set; }

		public string SEQUENCE { get; set; }

	}

}
