﻿using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class SAMPLINGPLAN {

		public string SAMPLINGPLANID { get; set; }

		public string AQLLEVELID { get; set; }

		public uint? CDOTYPEID { get; set; }

		public uint? CHANGECOUNT { get; set; }

		public string CHANGEHISTORYID { get; set; }

		public string DESCRIPTION { get; set; }

		public string ECO { get; set; }

		public string FILTERTAGS { get; set; }

		public uint? ICONID { get; set; }

		public string INSPECTIONLEVELID { get; set; }

		public uint? ISFROZEN { get; set; }

		public uint? MOVECONTAINERONCOMPLETION { get; set; }

		public string NOTES { get; set; }

		public string RESOURCEID { get; set; }

		public string REVISION { get; set; }

		public uint? SAMPLERATE { get; set; }

		public uint? SAMPLERATEMAXDURATION { get; set; }

		public uint? SAMPLESIZEBASEDONSTARTQTY { get; set; }

		public string SAMPLINGPLANBASEID { get; set; }

		public string SPECBASEID { get; set; }

		public string SPECID { get; set; }

		public uint? STATUS { get; set; }

		public string SWITCHINGRULEBASEID { get; set; }

		public string SWITCHINGRULEID { get; set; }

		public uint? SWITCHINGRULEMAXDURATION { get; set; }

		public string VENDORID { get; set; }

		public string VENDORITEMID { get; set; }

		public string WIPMSGDEFMGRID { get; set; }

	}

}
