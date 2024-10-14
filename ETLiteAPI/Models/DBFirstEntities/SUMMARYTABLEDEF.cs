using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class SUMMARYTABLEDEF {

		public string SUMMARYTABLEDEFID { get; set; }

		public uint? APPENDTOTABLE { get; set; }

		public uint? CDOTYPEID { get; set; }

		public uint? CHANGECOUNT { get; set; }

		public string CHANGEHISTORYID { get; set; }

		public string DESCRIPTION { get; set; }

		public DateTime? ENDDATE { get; set; }

		public string FILTERTAGS { get; set; }

		public uint? FORCEEXECUTE { get; set; }

		public uint? FORCEREFRESH { get; set; }

		public uint? ICONID { get; set; }

		public uint? ISENABLED { get; set; }

		public uint? ISFROZEN { get; set; }

		public uint? ISMANUALLYEXECUTED { get; set; }

		public uint? ISVIEW { get; set; }

		public DateTime? LASTRUNDATE { get; set; }

		public uint? LASTRUNELAPSEDSECONDS { get; set; }

		public string LASTRUNMESSAGE { get; set; }

		public uint? LASTRUNSUCCESS { get; set; }

		public DateTime? NEXTRUNDATE { get; set; }

		public string NOTES { get; set; }

		public string SCHEDULEDAYSOFMONTH { get; set; }

		public string SCHEDULEDAYSOFWEEK { get; set; }

		public string SCHEDULEHOURS { get; set; }

		public string SCHEDULEMONTHS { get; set; }

		public string SETUPACCESSID { get; set; }

		public DateTime? STARTDATE { get; set; }

		public string SUMMARYSQL { get; set; }

		public string SUMMARYTABLEDEFNAME { get; set; }

		public string TARGETSCHEMA { get; set; }

		public string TARGETTABLENAME { get; set; }

	}

}
