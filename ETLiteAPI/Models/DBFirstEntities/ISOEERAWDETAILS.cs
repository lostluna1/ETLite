using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class ISOEERAWDETAILS {

		public string ISOEERAWDETAILSID { get; set; }

		public DateTime? CALENDARDATE { get; set; }

		public string CALENDARSHIFTID { get; set; }

		public uint? CDOTYPEID { get; set; }

		public uint? CHANGECOUNT { get; set; }

		public uint? CHILDCOUNT { get; set; }

		public string CONTAINERID { get; set; }

		public string CONTAINERNAME { get; set; }

		public DateTime? CYCLESTARTGMT { get; set; }

		public decimal? CYCLETIME { get; set; }

		public string EMPLOYEEID { get; set; }

		public string EMPLOYEENAME { get; set; }

		public decimal? EQUIPMENTCYCLETIMEMS { get; set; }

		public string ES_IDENTIFIER { get; set; }

		public uint? ES_LEVELTYPE { get; set; }

		public uint? ES_NFFDEFECTCOUNT { get; set; }

		public uint? ES_PCBNUMBER { get; set; }

		public string FACTORYID { get; set; }

		public string FACTORYNAME { get; set; }

		public decimal? GOODQTY { get; set; }

		public decimal? GOODQTY2 { get; set; }

		public string HISTORYMAINLINEID { get; set; }

		public decimal? IDEALCYCLETIME { get; set; }

		public string ISERPOPERATION { get; set; }

		public uint? ISFAILED { get; set; }

		public decimal? ISFAILEDQTY { get; set; }

		public string ISOEERAWDETAILSNAME { get; set; }

		public uint? ISOPENDEFECTCOUNT { get; set; }

		public decimal? ISQTY { get; set; }

		public string ISRECIPENAME { get; set; }

		public uint? ISREPAIREDDEFECTCOUNT { get; set; }

		public string ISROUTESTEPNAME { get; set; }

		public uint? ISTOTALDEFECTCOUNT { get; set; }

		public decimal? LOSSQTY { get; set; }

		public decimal? LOSSQTY2 { get; set; }

		public string MFGORDERID { get; set; }

		public string MFGORDERNAME { get; set; }

		public string OPERATIONID { get; set; }

		public string OPERATIONNAME { get; set; }

		public string OWNERNAME { get; set; }

		public string PARENTID { get; set; }

		public decimal? PROCESSTIME { get; set; }

		public string PRODUCTFAMILYID { get; set; }

		public string PRODUCTFAMILYNAME { get; set; }

		public string PRODUCTID { get; set; }

		public string PRODUCTNAME { get; set; }

		public string PRODUCTREVISION { get; set; }

		public string QTYADJUSTREASON { get; set; }

		public decimal? QUEUETIME { get; set; }

		public string RECIPEID { get; set; }

		public string RECIPENAME { get; set; }

		public string RESOURCEFAMILYID { get; set; }

		public string RESOURCEFAMILYNAME { get; set; }

		public string RESOURCEID { get; set; }

		public string RESOURCENAME { get; set; }

		public decimal? REWORKEDQTY { get; set; }

		public decimal? REWORKEDQTY2 { get; set; }

		public string REWORKREASON { get; set; }

		public string ROUTESTEPID { get; set; }

		public string SHIFT { get; set; }

		public string SPECID { get; set; }

		public string SPECNAME { get; set; }

		public string SPECREVISION { get; set; }

		public string STARTPARENTCONTAINERID { get; set; }

		public string STEPID { get; set; }

		public string STEPNAME { get; set; }

		public uint? STEPPASS { get; set; }

		public decimal? TOTALQTY { get; set; }

		public decimal? TOTALQTY2 { get; set; }

		public DateTime? TXNDATE { get; set; }

		public DateTime? TXNDATEGMT { get; set; }

		public string TXNNAME { get; set; }

		public uint? TXNTYPE { get; set; }

		public string UOM { get; set; }

		public string UOM2 { get; set; }

		public string WORKFLOWID { get; set; }

		public string WORKFLOWNAME { get; set; }

		public string WORKFLOWREVISION { get; set; }

		public uint? WORKFLOWSTEPSEQUENCE { get; set; }

	}

}
