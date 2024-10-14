using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class CIODATAHUBSUBSCRIPTIONS {

		public string CIODATAHUBSUBSCRIPTIONID { get; set; }

		public uint? CDOTYPEID { get; set; }

		public uint? CHANGECOUNT { get; set; }

		public string CIODATAHUBADAPTERID { get; set; }

		public string CIODATAHUBSUBSCRIPTIONNAME { get; set; }

		public string EXPORTIMPORTKEY { get; set; }

		public uint? ISACTIVE { get; set; }

		public uint? ISFROZEN { get; set; }

		public string TRIGGERCOMPARISON { get; set; }

		public string TRIGGERFULLNAME { get; set; }

		public uint? TRIGGERINTERVAL { get; set; }

		public string TRIGGERPROPERTY { get; set; }

		public string TRIGGERTARGET { get; set; }

		public string TRIGGERTYPE { get; set; }

	}

}
