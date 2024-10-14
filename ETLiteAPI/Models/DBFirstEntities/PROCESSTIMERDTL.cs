using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class PROCESSTIMERDTL {

		public string PROCESSTIMERDTLID { get; set; }

		public string BUSINESSRULEID { get; set; }

		public uint? CDOTYPEID { get; set; }

		public uint? CHANGECOUNT { get; set; }

		public string CLASSIFICATIONID { get; set; }

		public string DEFAULTFAILUREMODEID { get; set; }

		public string DEFAULTPEDESCRIPTION { get; set; }

		public string ESIGREQUIREMENTID { get; set; }

		public string HOLDREASONID { get; set; }

		public uint? ISBUSINESSRULE { get; set; }

		public uint? ISCONFIRMATION { get; set; }

		public uint? ISFROZEN { get; set; }

		public uint? ISHOLD { get; set; }

		public uint? ISMOVENONSTD { get; set; }

		public uint? ISPRODUCTIONEVENT { get; set; }

		public uint? ISREWORK { get; set; }

		public string PARENTID { get; set; }

		public string PROCESSTIMERDTLNAME { get; set; }

		public string RESOURCEGROUPID { get; set; }

		public string RESOURCEID { get; set; }

		public string REWORKREASONID { get; set; }

		public string SUBCLASSIFICATIONID { get; set; }

		public uint? TIMERACTION { get; set; }

		public string TOSTEPID { get; set; }

		public string TOSTEPNAME { get; set; }

		public string TOWORKFLOWID { get; set; }

	}

}
