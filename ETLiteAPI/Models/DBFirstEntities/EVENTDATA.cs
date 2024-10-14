using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class EVENTDATA {

		public string EVENTDATAID { get; set; }

		public string ADVERSEEVENTID { get; set; }

		public string CAUSECODENAME { get; set; }

		public uint? CDOTYPEID { get; set; }

		public uint? CHANGECOUNT { get; set; }

		public string COMPENSATECUSTOMERACTIONID { get; set; }

		public string CONTACTCUSTOMERID { get; set; }

		public string CORRECTIVEACTIONCOMMENTSID { get; set; }

		public DateTime? DATERECEIVED { get; set; }

		public DateTime? DATERECEIVEDGMT { get; set; }

		public string DEVICEAVAILABLEID { get; set; }

		public string DEVICEEVALUATEDID { get; set; }

		public string DEVICELOCATION { get; set; }

		public string DEVICEOPERATORID { get; set; }

		public string DEVICERETURNEDID { get; set; }

		public DateTime? ESCALATECOMPLAINTDATE { get; set; }

		public DateTime? ESCALATECOMPLAINTDATEGMT { get; set; }

		public string EVENTCUSTOMDATAID { get; set; }

		public string EVENTDATE { get; set; }

		public string EVENTID { get; set; }

		public string EVENTTYPEID { get; set; }

		public string EXPORTIMPORTKEY { get; set; }

		public string FAILUREINVESTIGATIONCOMMENTSID { get; set; }

		public string HEALTHPROFESSIONALID { get; set; }

		public string MAINTENANCEREQNAME { get; set; }

		public string MAINTENANCEREQREV { get; set; }

		public string NONCONFORMANCENUMBER { get; set; }

		public string OCCUPATIONID { get; set; }

		public string OPERATIONNAME { get; set; }

		public string PREVENTIVEACTIONCOMMENTSID { get; set; }

		public string PROBLEMDESCRIPTION { get; set; }

		public string PRODUCTNAME { get; set; }

		public string PRODUCTPROBLEMID { get; set; }

		public string PRODUCTREV { get; set; }

		public string RECALLNUMBER { get; set; }

		public DateTime? REPORTDATE { get; set; }

		public DateTime? REPORTDATEGMT { get; set; }

		public string REPORTFILEDWITHFDAID { get; set; }

		public string REPORTINGCUSTOMERID { get; set; }

		public string REPORTSOURCEID { get; set; }

		public string RESOURCENAME { get; set; }

		public string RETURNEDCONTACTNAME { get; set; }

		public string RETURNEDPHONENUMBER { get; set; }

		public string RMANUMBER { get; set; }

		public string SAMPLEQUANTITY { get; set; }

		public string SPECNAME { get; set; }

		public string SPECREV { get; set; }

		public string WORKCENTERNAME { get; set; }

		public string WORKFLOWNAME { get; set; }

		public string WORKFLOWREV { get; set; }

		public string WORKFLOWSTEPNAME { get; set; }

	}

}
