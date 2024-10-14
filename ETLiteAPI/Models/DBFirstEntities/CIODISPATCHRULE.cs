using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class CIODISPATCHRULE {

		public string CIODISPATCHRULEID { get; set; }

		public uint? CDOTYPEID { get; set; }

		public uint? CHANGECOUNT { get; set; }

		public string CHANGEHISTORYID { get; set; }

		public string CIODISPATCHRULENAME { get; set; }

		public string CIODISPATCHRULEPLUGIN { get; set; }

		public string DESCRIPTION { get; set; }

		public uint? DISPATCHINTERVAL { get; set; }

		public string FILTERTAGS { get; set; }

		public uint? ICONID { get; set; }

		public uint? ISFROZEN { get; set; }

		public string LOCALDISPATCHERINITSTRING { get; set; }

		public string LOCALDISPATCHERPLUGIN { get; set; }

		public uint? MAXNUMBEROFTHREADS { get; set; }

		public uint? MERGEMESSAGES { get; set; }

		public uint? MESSAGELOGGING { get; set; }

		public string NOTES { get; set; }

		public uint? OVERLAPPEDDISPATCHING { get; set; }

		public string REMOTEDISPATCHERINITSTRING { get; set; }

		public string REMOTEDISPATCHERPLUGIN { get; set; }

		public string SETUPACCESS { get; set; }

	}

}
