using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class CIOTESTOBJECT {

		public string CIOTESTOBJECTID { get; set; }

		public string BRIEFDESCRIPTION { get; set; }

		public uint? CDOTYPEID { get; set; }

		public uint? CHANGECOUNT { get; set; }

		public string CHANGEHISTORYID { get; set; }

		public string CIOTESTOBJECTNAME { get; set; }

		public uint? CURRENTVALUE { get; set; }

		public string DESCRIPTION { get; set; }

		public string FILTERTAGS { get; set; }

		public uint? ICONID { get; set; }

		public uint? ISFROZEN { get; set; }

		public uint? NEXTVALUE { get; set; }

		public string NOTES { get; set; }

		public string SETUPACCESS { get; set; }

		public DateTime? TXNDATEGMT { get; set; }

	}

}
