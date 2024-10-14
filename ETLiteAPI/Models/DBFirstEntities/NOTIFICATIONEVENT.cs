using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class NOTIFICATIONEVENT {

		public string NOTIFICATIONEVENTID { get; set; }

		public uint? APPENDCONCIERGEMSG { get; set; }

		public uint? ASSIGNEEONLY { get; set; }

		public uint? CDOTYPEID { get; set; }

		public uint? CHANGECOUNT { get; set; }

		public string EMAILDISTRIBUTIONID { get; set; }

		public string EMAILMESSAGEID { get; set; }

		public string EXPORTIMPORTKEY { get; set; }

		public uint? ISFROZEN { get; set; }

		public uint? NOTIFICATIONTYPE { get; set; }

		public string PARENTID { get; set; }

	}

}
