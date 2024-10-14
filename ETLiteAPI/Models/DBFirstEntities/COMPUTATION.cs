using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class COMPUTATION {

		public string COMPUTATIONID { get; set; }

		public string ATTRIBUTENAME { get; set; }

		public uint? CDOTYPEID { get; set; }

		public uint? CHANGECOUNT { get; set; }

		public string CHANGEHISTORYID { get; set; }

		public string COMPUTATIONEXPRESSION { get; set; }

		public string COMPUTATIONNAME { get; set; }

		public uint? DECIMALSCALE { get; set; }

		public string DESCRIPTION { get; set; }

		public uint? DISPLAYLIMITS { get; set; }

		public string FILTERTAGS { get; set; }

		public uint? ICONID { get; set; }

		public uint? ISFROZEN { get; set; }

		public uint? ISLIMITOVERRIDEALLOWED { get; set; }

		public string LOWERLIMIT { get; set; }

		public uint? MAPTOCONTAINERATTRIBUTE { get; set; }

		public string NOTES { get; set; }

		public uint? RESULTDATATYPE { get; set; }

		public string RESULTNAME { get; set; }

		public uint? ROUNDINGRULE { get; set; }

		public string SETUPACCESSID { get; set; }

		public string UPPERLIMIT { get; set; }

	}

}
