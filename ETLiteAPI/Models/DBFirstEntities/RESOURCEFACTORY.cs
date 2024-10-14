using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class RESOURCEFACTORY {

		public string AREANAME { get; set; }

		public string CELLNAME { get; set; }

		public string EQUIPMENTNAME { get; set; }

		public string FACTORYID { get; set; }

		public string FACTORYNAME { get; set; }

		public string RESOURCEID { get; set; }

		public string RESOURCENAME { get; set; }

	}

}
