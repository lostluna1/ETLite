using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class CDODEFINITION {

		public uint? CDODEFID { get; set; }

		public string CDODESCRIPTION { get; set; }

		public string CDONAME { get; set; }

		public uint? CDOUSAGEMASK { get; set; }

		public uint? DEFAULTTABLEID { get; set; }

		public uint? DISPLAYNAMELABELID { get; set; }

		public bool? ENFORCEINTEGRITY { get; set; }

		public uint? FEATUREID { get; set; }

		public uint? INHERITMASK { get; set; }

		public bool? ISABSTRACT { get; set; }

		public bool? ISEXPOSEDTOCLIENTUI { get; set; }

		public bool? ISWSEXPOSEDSTD { get; set; }

		public uint? MAINTENANCETYPEID { get; set; }

		public uint? OBJECTSTOCACHE { get; set; }

		public uint? PARENTCDOID { get; set; }

		public string READOVERRIDE { get; set; }

		public uint? REVISIONTYPEID { get; set; }

		public uint? SECURITYTYPEID { get; set; }

		public uint? SELVALQUERYDEFID { get; set; }

		public uint? STORAGECATEGORYID { get; set; }

		public uint? UIDETAILSID { get; set; }

		public bool? USEINSTANCESECURITY { get; set; }

		public uint? VISIBILITY { get; set; }

		public string WORKSPACECODE { get; set; }

		public string WRITEOVERRIDE { get; set; }

	}

}
