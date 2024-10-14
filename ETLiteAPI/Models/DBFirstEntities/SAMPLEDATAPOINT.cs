using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class SAMPLEDATAPOINT {

		public string SAMPLEDATAPOINTID { get; set; }

		public string BIZ_FSS_CODEID { get; set; }

		public uint? BIZ_ISMETGNO { get; set; }

		public string BIZ_MOLD_TYPEID { get; set; }

		public uint? BIZ_POINTTYPE { get; set; }

		public string BIZ_SAMPLEDATAPOINTTYPEID { get; set; }

		public decimal? BIZ_SAMPLEQTY { get; set; }

		public uint? BIZ_SEQUENCE { get; set; }

		public uint? BIZ_SPC { get; set; }

		public string BIZ_SPCMODULE { get; set; }

		public string BIZ_TER_ITEM_CODEID { get; set; }

		public string BIZ_ZFORMAT { get; set; }

		public uint? CDOTYPEID { get; set; }

		public uint? CHANGECOUNT { get; set; }

		public string CHANGEHISTORYID { get; set; }

		public uint? DATATYPE { get; set; }

		public string DEFAULTVALUE { get; set; }

		public string DESCRIPTION { get; set; }

		public string ECO { get; set; }

		public string FILTERTAGS { get; set; }

		public uint? ICONID { get; set; }

		public uint? ISFROZEN { get; set; }

		public string LOWERLIMIT { get; set; }

		public string NOTES { get; set; }

		public string REVISION { get; set; }

		public string SAMPLEDATAPOINTBASEID { get; set; }

		public uint? SHOWLIMITS { get; set; }

		public uint? STATUS { get; set; }

		public string UOMID { get; set; }

		public string UPPERLIMIT { get; set; }

		public string WIPMSGDEFMGRID { get; set; }

	}

}
