using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class HISTORYMAINLINE {

		public string HISTORYMAINLINEID { get; set; }

		public uint? APPLICATION { get; set; }

		public uint? BASETXNTYPE { get; set; }

		public string BATCHID { get; set; }

		public uint? BINNINGINCLUDED { get; set; }

		public string BIZ_CUSTOMERCONTAINER { get; set; }

		public string BIZ_CUSTOMERPARENTLOT { get; set; }

		public string BIZ_DEFECTREASONID { get; set; }

		public uint? BIZ_ISPASS { get; set; }

		public string BIZ_NGCONTAINER { get; set; }

		public uint? BONUSINCLUDED { get; set; }

		public string CALENDARSHIFTID { get; set; }

		public string CARRIERID { get; set; }

		public uint? CDOTYPEID { get; set; }

		public uint? CHANGECOUNT { get; set; }

		public uint? CHILDCOUNT { get; set; }

		public string CIOMESSAGEID { get; set; }

		public string CIOMESSAGEIDOUTBOUND { get; set; }

		public uint? CLIENT { get; set; }

		public string COMMENTS { get; set; }

		public uint? COMPOUNDTXNTYPE { get; set; }

		public string COMPUTATIONHISTORYID { get; set; }

		public string COMPUTERNAME { get; set; }

		public uint? CONTAINERCHANGECOUNT { get; set; }

		public string CONTAINERID { get; set; }

		public string CONTAINERNAME { get; set; }

		public uint? DEFECTINCLUDED { get; set; }

		public string EMPLOYEEID { get; set; }

		public string ES_RECIPEID { get; set; }

		public string ESIGREQUIREMENTID { get; set; }

		public string FACTORYID { get; set; }

		public string HISTORYID { get; set; }

		public uint? ICONID { get; set; }

		public uint? IMPLICIT { get; set; }

		public uint? INREWORK { get; set; }

		public string INTEGRATIONTXNID { get; set; }

		public uint? ISFAILED { get; set; }

		public DateTime? LASTMOVEDATE { get; set; }

		public DateTime? LASTMOVEDATEGMT { get; set; }

		public DateTime? LASTMOVEOUTDATE { get; set; }

		public DateTime? LASTMOVEOUTDATEGMT { get; set; }

		public uint? LOCALREWORKINCLUDED { get; set; }

		public string LOGINID { get; set; }

		public uint? LOSSINCLUDED { get; set; }

		public DateTime? MFGDATE { get; set; }

		public string MFGPROCESSOVERRIDESID { get; set; }

		public DateTime? MOVEINDATE { get; set; }

		public DateTime? MOVEINDATEGMT { get; set; }

		public decimal? MOVEINQTY { get; set; }

		public decimal? MOVEINQTY2 { get; set; }

		public string OPERATIONID { get; set; }

		public string OWNERID { get; set; }

		public string PARAMETRICDETAILID { get; set; }

		public string PARENTCONTAINERID { get; set; }

		public string PARENTCONTAINERNAME { get; set; }

		public string PRODUCTID { get; set; }

		public decimal? QTY { get; set; }

		public decimal? QTY2 { get; set; }

		public uint? QUALITYESIGCONFIRMED { get; set; }

		public uint? RESOURCEAVAILABILITY { get; set; }

		public string RESOURCEID { get; set; }

		public string RESOURCESTATUSCODEID { get; set; }

		public string RESOURCESTATUSREASONID { get; set; }

		public uint? REVERSALSTATUS { get; set; }

		public uint? SERVER { get; set; }

		public string SERVERNAME { get; set; }

		public string SHIFTNAME { get; set; }

		public string SPECID { get; set; }

		public uint? STATUS { get; set; }

		public string STEPENTRYTXNID { get; set; }

		public uint? STEPPASS { get; set; }

		public DateTime? SYSTEMDATE { get; set; }

		public DateTime? SYSTEMDATEGMT { get; set; }

		public decimal? TOQTY { get; set; }

		public decimal? TOQTY2 { get; set; }

		public DateTime? TXNDATE { get; set; }

		public DateTime? TXNDATEGMT { get; set; }

		public uint? TXNHISTORYSEQUENCE { get; set; }

		public string TXNID { get; set; }

		public string TXNPARENTTYPENAME { get; set; }

		public uint? TXNSEQUENCE { get; set; }

		public string TXNSERVICENAME { get; set; }

		public uint? TXNSERVICESEQUENCE { get; set; }

		public uint? TXNTYPE { get; set; }

		public string TXNTYPENAME { get; set; }

		public string USERID { get; set; }

		public string WORKFLOWSTEPID { get; set; }

		public string WORKSTATIONID { get; set; }

	}

}
