using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class CIOPLUGINPARAMETERS {

		public string CIOPLUGINPARAMETERSID { get; set; }

		public uint? CDOTYPEID { get; set; }

		public uint? CHANGECOUNT { get; set; }

		public string CIOPLUGINADAPTERID { get; set; }

		public uint? CIOPLUGINMETHOD { get; set; }

		public string CIOPLUGINPARAMETERSNAME { get; set; }

		public string EXPORTIMPORTKEY { get; set; }

		public uint? ISFROZEN { get; set; }

		public string PARAMETERVALUE { get; set; }

	}

}
