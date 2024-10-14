using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class DATACOLLECTIONDEF {

		public string DATACOLLECTIONDEFID { get; set; }

		public uint? CDOTYPEID { get; set; }

		public uint? CHANGECOUNT { get; set; }

		public string CHANGEHISTORYID { get; set; }

		public string DATACOLLECTIONDEFBASEID { get; set; }

		public string DATACOLLECTIONDEFREVISION { get; set; }

		public uint? DATAPOINTLAYOUT { get; set; }

		public string DESCRIPTION { get; set; }

		public uint? DISPLAYLIMITS { get; set; }

		public string ECO { get; set; }

		public string FILTERTAGS { get; set; }

		public uint? ICONID { get; set; }

		public string INSTRUCTIONS { get; set; }

		public string ISDEFECTREASONGROUPID { get; set; }

		public uint? ISFROZEN { get; set; }

		public uint? ISSCALEENABLED { get; set; }

		public string NOTES { get; set; }

		public string PARAMETRICDATACONTROL { get; set; }

		public uint? PARAMETRICDATADEFTYPE { get; set; }

		public string SETUPACCESSID { get; set; }

		public string SPCCHARTDEFGROUPID { get; set; }

		public uint? STATUS { get; set; }

		public uint? USESPCMATRIX { get; set; }

		public string WEBPARTID { get; set; }

		public string WIPMSGDEFMGRID { get; set; }

	}

}
