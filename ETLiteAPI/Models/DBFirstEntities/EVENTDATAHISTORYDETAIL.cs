using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class EVENTDATAHISTORYDETAIL {

		public string EVENTDATAHISTORYDETAILSID { get; set; }

		public string ADVERSEEVENTHISTORYDETAILID { get; set; }

		public string CAUSECODENAME { get; set; }

		public uint? CDOTYPEID { get; set; }

		public uint? CHANGECOUNT { get; set; }

		public string COMPENSATECUSTOMERACTIONID { get; set; }

		public string CONTACTCUSTOMERHISTORYDETAILID { get; set; }

		public string CORRECTIVEACTIONHISTORYID { get; set; }

		public string CUSTOMHISTORYDETAILID { get; set; }

		public DateTime? DATERECEIVED { get; set; }

		public DateTime? DATERECEIVEDGMT { get; set; }

		public string DEVICEAVAILABLEHISTORYDETAILID { get; set; }

		public string DEVICEEVALUATEDHISTDETAILID { get; set; }

		public string DEVICELOCATION { get; set; }

		public string DEVICEOPERATORHISTORYDETAILID { get; set; }

		public string DEVICERETURNEDHISTORYDETAILID { get; set; }

		public DateTime? ESCALATECOMPLAINTDATE { get; set; }

		public DateTime? ESCALATECOMPLAINTDATEGMT { get; set; }

		public string EVENTDATE { get; set; }

		public string EVENTHISTORYDETAILID { get; set; }

		public string EVENTTYPEHISTORYDETAILID { get; set; }

		public string EXPORTIMPORTKEY { get; set; }

		public string FAILUREINVESTIGATIONHISTORYID { get; set; }

		public string HEALTHPROFESSIONALHISTDETAILID { get; set; }

		public string HISTORYID { get; set; }

		public string INTEGRATIONTXNID { get; set; }

		public string MAINTENANCEREQNAME { get; set; }

		public string MAINTENANCEREQREV { get; set; }

		public string NONCONFORMANCENUMBER { get; set; }

		public string OCCUPATIONID { get; set; }

		public string OPERATIONNAME { get; set; }

		public string PREVENTIVEACTIONHISTORYID { get; set; }

		public string PROBLEMDESCRIPTION { get; set; }

		public string PRODUCTNAME { get; set; }

		public string PRODUCTPROBLEMHISTORYDETAILID { get; set; }

		public string PRODUCTREV { get; set; }

		public string RECALLNUMBER { get; set; }

		public DateTime? REPORTDATE { get; set; }

		public DateTime? REPORTDATEGMT { get; set; }

		public string REPORTFILEDWITHFDAHISTDETAILID { get; set; }

		public string REPORTINGCUSTOMERHISTDETAILID { get; set; }

		public string REPORTSOURCEHISTORYDETAILID { get; set; }

		public string RESOURCENAME { get; set; }

		public string RETURNEDCONTACTNAME { get; set; }

		public string RETURNEDPHONENUMBER { get; set; }

		public string RMANUMBER { get; set; }

		public string SAMPLEQUANTITY { get; set; }

		public string SPECNAME { get; set; }

		public string SPECREV { get; set; }

		public string TXNID { get; set; }

		public string WORKCENTERNAME { get; set; }

		public string WORKFLOWNAME { get; set; }

		public string WORKFLOWREV { get; set; }

	}

}
