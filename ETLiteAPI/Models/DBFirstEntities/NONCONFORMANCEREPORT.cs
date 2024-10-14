using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class NONCONFORMANCEREPORT {

		public string NONCONFORMANCEREPORTID { get; set; }

		public string ATTACHMENTSID { get; set; }

		public uint? CDOTYPEID { get; set; }

		public uint? CHANGECOUNT { get; set; }

		public string CHARGETOSTEPID { get; set; }

		public DateTime? CLOSEDATE { get; set; }

		public DateTime? CLOSEDATEGMT { get; set; }

		public string CONTAINERID { get; set; }

		public string CORRECTIVEACTIONCOMMENTSID { get; set; }

		public DateTime? CREATIONDATE { get; set; }

		public DateTime? CREATIONDATEGMT { get; set; }

		public string ESCALATEDBYID { get; set; }

		public string ESCALATEDEVENTID { get; set; }

		public DateTime? ESCALATIONDATE { get; set; }

		public DateTime? ESCALATIONDATEGMT { get; set; }

		public string FAILUREINVESTIGATIONCOMMENTSID { get; set; }

		public string LASTREVTXNID { get; set; }

		public string NCRCAUSECODEGROUPID { get; set; }

		public string NCRCAUSECODEID { get; set; }

		public string NCRCOMMENT { get; set; }

		public string NCRFAILURETYPEID { get; set; }

		public string NCRRESOLUTIONCODEID { get; set; }

		public uint? NCRSTATUS { get; set; }

		public string NONCONFORMANCEREPORTNAME { get; set; }

		public string PREVENTIVEACTIONCOMMENTSID { get; set; }

		public string RELATEDNONCONFORMANCEID { get; set; }

		public string TASKID { get; set; }

	}

}
