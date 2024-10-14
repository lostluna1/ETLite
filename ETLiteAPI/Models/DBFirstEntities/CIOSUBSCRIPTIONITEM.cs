using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class CIOSUBSCRIPTIONITEM {

		public string CIOSUBSCRIPTIONITEMID { get; set; }

		public uint? CACHEDURATION { get; set; }

		public uint? CDOTYPEID { get; set; }

		public uint? CHANGECOUNT { get; set; }

		public string CIOSHOPFLOORADAPTERID { get; set; }

		public string CIOSUBSCRIPTIONITEMNAME { get; set; }

		public string EXPORTIMPORTKEY { get; set; }

		public uint? ISACTIVE { get; set; }

		public uint? ISFROZEN { get; set; }

		public uint? SENDFIRSTVALUE { get; set; }

		public string TRIGGERCOMPARISON { get; set; }

		public string TRIGGERDEADBANDTYPE { get; set; }

		public string TRIGGERDEADBANDVALUE { get; set; }

		public string TRIGGERFULLNAME { get; set; }

		public uint? TRIGGERINTERVAL { get; set; }

		public string TRIGGERTARGET { get; set; }

		public uint? TRIGGERTHROTTLEINTERVAL { get; set; }

		public string TRIGGERTYPE { get; set; }

	}

}
