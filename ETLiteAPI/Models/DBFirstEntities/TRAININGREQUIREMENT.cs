using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class TRAININGREQUIREMENT {

		public string TRAININGREQUIREMENTID { get; set; }

		public uint? CDOTYPEID { get; set; }

		public uint? CHANGECOUNT { get; set; }

		public string CHANGEHISTORYID { get; set; }

		public string DESCRIPTION { get; set; }

		public string ECO { get; set; }

		public DateTime? EFFECTIVEFROMDATE { get; set; }

		public DateTime? EFFECTIVETHRUDATE { get; set; }

		public DateTime? EXPIRATIONDATE { get; set; }

		public uint? EXPIRATIONPERIOD { get; set; }

		public string FILTERTAGS { get; set; }

		public uint? ICONID { get; set; }

		public uint? ISFROZEN { get; set; }

		public string NOTES { get; set; }

		public string SETUPACCESSID { get; set; }

		public string SOPDOCBASEID { get; set; }

		public string SOPDOCID { get; set; }

		public uint? STATUS { get; set; }

		public string TRAININGREQUIREMENTBASEID { get; set; }

		public string TRAININGREQUIREMENTREVISION { get; set; }

		public string WARNINGEMAILGROUPID { get; set; }

		public decimal? WARNINGPERIOD { get; set; }

		public string WIPMSGDEFMGRID { get; set; }

	}

}
