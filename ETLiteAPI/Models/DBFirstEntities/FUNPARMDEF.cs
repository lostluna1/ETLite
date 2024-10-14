using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class FUNPARMDEF {

		public uint? CDODEFID { get; set; }

		public uint? DATATYPEID { get; set; }

		public string DEFAULTVALUE { get; set; }

		public string DIRECTION { get; set; }

		public uint? FUNCTIONID { get; set; }

		public uint? FUNCTIONPARMID { get; set; }

		public uint? FUNCTIONPARMUSAGEID { get; set; }

		public bool? ISLIST { get; set; }

		public string NAME { get; set; }

		public string NOTES { get; set; }

		public uint? PARAMMULTIPLICITY { get; set; }

		public string PARMDESCRIPTION { get; set; }

		public uint? PARMNUMBER { get; set; }

		public uint? TYPEMULTIPLICITY { get; set; }

		public string WORKSPACECODE { get; set; }

	}

}
