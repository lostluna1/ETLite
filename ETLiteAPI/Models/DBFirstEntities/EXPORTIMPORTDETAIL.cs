using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class EXPORTIMPORTDETAIL {

		public uint EXPORTIMPORTDETAILID { get; set; }

		public uint? ENCRYPTFILE { get; set; }

		public string EXPORTDATA { get; set; }

		public uint? EXPORTIMPORTHEADERID { get; set; }

		public uint? EXPORTIMPORTSEQUENCE { get; set; }

		public string OBJECTINSTANCEID { get; set; }

		public uint? OBJECTISROR { get; set; }

		public string OBJECTNAME { get; set; }

		public string OBJECTREVISION { get; set; }

		public uint? OBJECTTYPEID { get; set; }

		public string OBJECTTYPENAME { get; set; }

		public uint? STATUS { get; set; }

	}

}
