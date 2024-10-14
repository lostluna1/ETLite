using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class EMAILQUEUE {

		public DateTime? CREATEDDATE { get; set; }

		public uint? EMAILQUEUEID { get; set; }

		public string LASTERRORMESSAGE { get; set; }

		public DateTime? LASTSENDATTEMPTDATE { get; set; }

		public string MESSAGEBODY { get; set; }

		public uint? MESSAGEFORMAT { get; set; }

		public string PROCESSINGSERVER { get; set; }

		public uint? PROCESSINGSTATUS { get; set; }

		public string RECIPIENTS { get; set; }

		public uint? SENDATTEMPTS { get; set; }

		public string SENDER { get; set; }

		public DateTime? SENTDATE { get; set; }

		public string SMTPTRANSPORTID { get; set; }

		public string SUBJECT { get; set; }

	}

}
