using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class WORKCENTER {

		public string WORKCENTERID { get; set; }

		public uint? CDOTYPEID { get; set; }

		public uint? CHANGECOUNT { get; set; }

		public string CHANGESTATUSID { get; set; }

		public string DESCRIPTION { get; set; }

		public uint? DISPATCHMETHOD { get; set; }

		public string DISPATCHRULEID { get; set; }

		public decimal? FASTQUEUETIME { get; set; }

		public string FILTERTAGS { get; set; }

		public uint? ICONID { get; set; }

		public string IMAGE { get; set; }

		public uint? ISFROZEN { get; set; }

		public string MFGCALENDARID { get; set; }

		public decimal? NORMALQUEUETIME { get; set; }

		public string NOTES { get; set; }

		public string RESOURCEGROUPID { get; set; }

		public string SETUPACCESSID { get; set; }

		public string TRAININGREQGROUPID { get; set; }

		public string WIPMSGDEFMGRID { get; set; }

		public string WORKCENTERNAME { get; set; }

		public string WORKSCHEDULEID { get; set; }

	}

}
