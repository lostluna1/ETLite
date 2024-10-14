using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class FIELDDEFINITIONS {

		public bool? CASESENSITIVE { get; set; }

		public uint? CDODEFID { get; set; }

		public uint? CPPDATATYPEID { get; set; }

		public uint? DATASUBTYPEID { get; set; }

		public string DESCRIPTION { get; set; }

		public string DISPLAYMASK { get; set; }

		public uint? FIELDDEFID { get; set; }

		public string FIELDDEFNAME { get; set; }

		public bool? FORCETOLOWER { get; set; }

		public bool? FORCETOUPPER { get; set; }

		public uint? PRECISIONVALUE { get; set; }

		public uint? SCALE { get; set; }

		public string WORKSPACECODE { get; set; }

	}

}
