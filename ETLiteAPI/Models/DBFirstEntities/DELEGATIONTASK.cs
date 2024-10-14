using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class DELEGATIONTASK {

		public string DELEGATIONTASKID { get; set; }

		public uint? APPLICATIONTYPE { get; set; }

		public string ASSIGNEDEMPLOYEEID { get; set; }

		public uint? CDOTYPEID { get; set; }

		public uint? CHANGECOUNT { get; set; }

		public string CHANGEHISTORYID { get; set; }

		public string COMMENTS { get; set; }

		public string DELEGATEDBYID { get; set; }

		public uint? DELEGATIONFORWARDING { get; set; }

		public string DELEGATIONREASONID { get; set; }

		public string DELEGATIONTASKNAME { get; set; }

		public DateTime? ENDDATEGMT { get; set; }

		public uint? ISFROZEN { get; set; }

		public DateTime? STARTDATEGMT { get; set; }

		public string TARGETEMPLOYEEID { get; set; }

	}

}
