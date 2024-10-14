using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class CIOMESSAGECHANNEL {

		public string CIOMESSAGECHANNELID { get; set; }

		public uint? CDOTYPEID { get; set; }

		public uint? CHANGECOUNT { get; set; }

		public string CHANGEHISTORYID { get; set; }

		public string CIODISPATCHRULEID { get; set; }

		public string CIOMESSAGECHANNELNAME { get; set; }

		public string DESCRIPTION { get; set; }

		public string EXPIREDMESSAGERULEID { get; set; }

		public string FILTERTAGS { get; set; }

		public uint? ICONID { get; set; }

		public string INVALIDMESSAGERULEID { get; set; }

		public uint? ISACTIVE { get; set; }

		public uint? ISFROZEN { get; set; }

		public uint? MAPMESSAGE { get; set; }

		public string MSGTYPEEXTRACTIONFN { get; set; }

		public string NOTES { get; set; }

		public string RESPONSETIMEOUTRULEID { get; set; }

		public string SETUPACCESS { get; set; }

	}

}
