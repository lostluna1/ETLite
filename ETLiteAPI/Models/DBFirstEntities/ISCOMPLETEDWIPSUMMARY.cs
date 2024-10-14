using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class ISCOMPLETEDWIPSUMMARY {

		public string ISCOMPLETEDWIPSUMMARYID { get; set; }

		public DateTime? CALENDARDATE { get; set; }

		public string CALENDARSHIFTID { get; set; }

		public uint? CHILDCOUNT { get; set; }

		public DateTime? COMPLETEDDATE { get; set; }

		public DateTime? COMPLETEDDATEGMT { get; set; }

		public string CONTAINERID { get; set; }

		public string CONTAINERNAME { get; set; }

		public decimal? ELAPSEDTIME { get; set; }

		public string EMPLOYEEID { get; set; }

		public string EMPLOYEENAME { get; set; }

		public decimal? ENDQTY { get; set; }

		public decimal? ENDQTY2 { get; set; }

		public decimal? EQUIPMENTCYCLETIMEMS { get; set; }

		public string FACTORYID { get; set; }

		public string FACTORYNAME { get; set; }

		public DateTime? FACTORYSTARTDATE { get; set; }

		public DateTime? FACTORYSTARTDATEGMT { get; set; }

		public string ISCOMPLETEDWIPSUMMARYNAME { get; set; }

		public decimal? ISFAILEDQTY { get; set; }

		public uint? ISOPENDEFECTCOUNT { get; set; }

		public uint? ISTOTALDEFECTCOUNT { get; set; }

		public string MFGORDERID { get; set; }

		public string MFGORDERNAME { get; set; }

		public string OPERATIONID { get; set; }

		public string OPERATIONNAME { get; set; }

		public string OWNERID { get; set; }

		public string OWNERNAME { get; set; }

		public string PARENTID { get; set; }

		public uint? PASTDUE { get; set; }

		public DateTime? PLANNEDCOMPLETIONDATE { get; set; }

		public DateTime? PLANNEDCOMPLETIONDATEGMT { get; set; }

		public string PRODUCTID { get; set; }

		public string PRODUCTNAME { get; set; }

		public string PRODUCTREVISION { get; set; }

		public string RECIPEID { get; set; }

		public string RECIPENAME { get; set; }

		public string RESOURCEID { get; set; }

		public string RESOURCENAME { get; set; }

		public string SHIFTNAME { get; set; }

		public string SPECID { get; set; }

		public string SPECNAME { get; set; }

		public string SPECREVISION { get; set; }

		public decimal? STARTQTY { get; set; }

		public decimal? STARTQTY2 { get; set; }

		public decimal? TIMEPASSEDCOMPLETIONDATE { get; set; }

		public uint? TXNTYPE { get; set; }

		public string UOM2NAME { get; set; }

		public string UOMNAME { get; set; }

		public string WORKFLOWID { get; set; }

		public string WORKFLOWNAME { get; set; }

		public string WORKFLOWREVISION { get; set; }

		public string WORKFLOWSTEPID { get; set; }

		public string WORKFLOWSTEPNAME { get; set; }

	}

}
