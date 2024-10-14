using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class CIOMESSAGETYPE {

		public string CIOMESSAGETYPEID { get; set; }

		public uint? CACHEEXPIRATION { get; set; }

		public uint? CDOTYPEID { get; set; }

		public uint? CHANGECOUNT { get; set; }

		public string CHANGEHISTORYID { get; set; }

		public string CIODISPATCHRULEID { get; set; }

		public string CIOMESSAGEMAPBASEID { get; set; }

		public string CIOMESSAGEMAPID { get; set; }

		public string CIOMESSAGETYPENAME { get; set; }

		public string CIOWORKFLOWBASEID { get; set; }

		public string CIOWORKFLOWID { get; set; }

		public string DESCRIPTION { get; set; }

		public string DISPATCHADDRESS { get; set; }

		public uint? EVENTONLY { get; set; }

		public string FILTERTAGS { get; set; }

		public uint? ICONID { get; set; }

		public uint? INHIBITEVENT { get; set; }

		public uint? ISCHILDTYPE { get; set; }

		public uint? ISEXPRESS { get; set; }

		public uint? ISFROZEN { get; set; }

		public uint? ISREQUEST { get; set; }

		public uint? MAXRETRYCOUNT { get; set; }

		public uint? MINQUEUETIME { get; set; }

		public uint? MINRETRYINTERVAL { get; set; }

		public string NOTES { get; set; }

		public uint? OUTBOUNDONCREATE { get; set; }

		public uint? PRIORITY { get; set; }

		public uint? REQUIRESCACHE { get; set; }

		public uint? RESPONSETIMEOUT { get; set; }

		public string RESPONSETOTYPEID { get; set; }

		public string SETUPACCESS { get; set; }

		public uint? TIMETOLIVE { get; set; }

	}

}
