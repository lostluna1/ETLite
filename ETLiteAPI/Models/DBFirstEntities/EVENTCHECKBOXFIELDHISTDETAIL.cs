using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class EVENTCHECKBOXFIELDHISTDETAIL {

		public string EVENTCHECKBOXFIELDHISTDETAILID { get; set; }

		public uint? CDOTYPEID { get; set; }

		public uint? CHANGECOUNT { get; set; }

		public uint? COMPANYREPRESENTATIVE { get; set; }

		public uint? CONSUMER { get; set; }

		public uint? DEATH { get; set; }

		public uint? DISTRIBUTOR { get; set; }

		public string EVALUATIONCODE { get; set; }

		public string EVENTDATAHISTORYDETAILID { get; set; }

		public string EXPORTIMPORTKEY { get; set; }

		public uint? FOREIGNSOURCE { get; set; }

		public uint? HEALTHPROFESSIONAL { get; set; }

		public string HISTORYID { get; set; }

		public string INTEGRATIONTXNID { get; set; }

		public uint? LAYUSERPATIENT { get; set; }

		public uint? LITERATURE { get; set; }

		public uint? MALFUNCTION { get; set; }

		public uint? NOFIELD { get; set; }

		public uint? NOTRETURNED { get; set; }

		public string OCCUPATIONID { get; set; }

		public uint? OTHER { get; set; }

		public string OTHERTEXT { get; set; }

		public DateTime? RETURNEDDATE { get; set; }

		public DateTime? RETURNEDDATEGMT { get; set; }

		public uint? SERIOUSINJURY { get; set; }

		public uint? STUDY { get; set; }

		public uint? SUMMARYATTACHED { get; set; }

		public string TXNID { get; set; }

		public uint? UNK { get; set; }

		public uint? USERFACILITY { get; set; }

		public uint? YES { get; set; }

	}

}
