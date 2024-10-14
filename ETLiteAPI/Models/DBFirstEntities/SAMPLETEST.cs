using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class SAMPLETEST {

		public string SAMPLETESTID { get; set; }

		public uint? ALLOWMOVEONFAILURE { get; set; }

		public string AQLREJECTREASONSID { get; set; }

		public uint? BIZ_INSPECTMAPPINGTYPE { get; set; }

		public uint? CDOTYPEID { get; set; }

		public uint? CHANGECOUNT { get; set; }

		public string CHANGEHISTORYID { get; set; }

		public string CLASSIFICATIONID { get; set; }

		public string DECREASEBYREJECTCOUNTREASONID { get; set; }

		public string DECREASEBYSAMPLESIZEREASONID { get; set; }

		public string DEFAULTFAILUREMODEID { get; set; }

		public string DEFAULTPEDESCRIPTION { get; set; }

		public string DESCRIPTION { get; set; }

		public string ECO { get; set; }

		public string FILTERTAGS { get; set; }

		public uint? ICONID { get; set; }

		public string INSTRUCTIONS { get; set; }

		public uint? ISFROZEN { get; set; }

		public string NOTES { get; set; }

		public string REVISION { get; set; }

		public string SAMPLETESTBASEID { get; set; }

		public uint? SAMPLETYPE { get; set; }

		public uint? SCRAPCOUNTEDREJECTSBYREASON { get; set; }

		public uint? STATUS { get; set; }

		public string SUBCLASSIFICATIONID { get; set; }

		public string WIPMSGDEFMGRID { get; set; }

	}

}
