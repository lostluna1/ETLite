using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class RV_DHRCOMPONENTSREMOVED {

		public decimal? ACTUALQTYISSUED { get; set; }

		public string COMPONENTISSUEHISTORYID { get; set; }

		public string COMPONENTREMOVEHISTORYID { get; set; }

		public string COMPONENTREPLACEHISTORYID { get; set; }

		public string CONTAINERID { get; set; }

		public string CONTAINERNAME { get; set; }

		public string EMPLOYEEID { get; set; }

		public string EMPLOYEENAME { get; set; }

		public string ES_FROMLOT2 { get; set; }

		public string ES_FROMLOT3 { get; set; }

		public uint? ES_PCBNUMBER { get; set; }

		public string ES_PRIMARYSERIALNUMBER { get; set; }

		public string ES_SERIALNUMBER2 { get; set; }

		public string ES_SERIALNUMBER3 { get; set; }

		public string FROMBATCHID { get; set; }

		public string FROMBATCHNAME { get; set; }

		public string FROMCONTAINERID { get; set; }

		public string FROMCONTAINERNAME { get; set; }

		public string FROMLOT { get; set; }

		public string FROMPRIMARYSERIALNUMBER { get; set; }

		public string FROMSTOCKPOINT { get; set; }

		public string IDENTIFIER { get; set; }

		public string ISSUEACTUALSHISTORYID { get; set; }

		public uint? ISSUECONTROL { get; set; }

		public string ISSUEDETAILS { get; set; }

		public string ISSUEHISTORYDETAILID { get; set; }

		public string ISSUEHISTORYMAINLINEID { get; set; }

		public string ISSUETXN { get; set; }

		public string ISSUETYPE { get; set; }

		public string PARENTCONTAINERID { get; set; }

		public string PARENTCONTAINERNAME { get; set; }

		public string PARENTPRIMARYSERIALNUMBER { get; set; }

		public string PARENTSERIALNUMBER2 { get; set; }

		public string PARENTSERIALNUMBER3 { get; set; }

		public string PRODUCT { get; set; }

		public string PRODUCTID { get; set; }

		public string PRODUCTMATERIALLISTITEMID { get; set; }

		public string PRODUCTNAME { get; set; }

		public string PRODUCTREVISION { get; set; }

		public decimal? QTY { get; set; }

		public decimal? QTYREMOVED { get; set; }

		public decimal? QTYREQUIRED { get; set; }

		public string REFERENCEDESIGNATOR { get; set; }

		public string REMOVALREASONID { get; set; }

		public string REMOVEHISTORYMAINLINEID { get; set; }

		public string REMOVETXN { get; set; }

		public string REPLACEHISTORYMAINLINEID { get; set; }

		public string REPLACEID { get; set; }

		public string REPLACEREASONID { get; set; }

		public string REPLACETXN { get; set; }

		public decimal? RMACTUALQTYISSUED { get; set; }

		public string RMES_FROMLOT2 { get; set; }

		public string RMES_FROMLOT3 { get; set; }

		public string RMFROMBATCHID { get; set; }

		public string RMFROMBATCHNAME { get; set; }

		public string RMFROMCONTAINERID { get; set; }

		public string RMFROMCONTAINERNAME { get; set; }

		public string RMFROMLOT { get; set; }

		public string RMFROMPRIMARYSERIALNUMBER { get; set; }

		public string RMFROMSTOCKPOINT { get; set; }

		public uint? RMISSUECONTROL { get; set; }

		public string RMPRODUCTID { get; set; }

		public string RMPRODUCTMATERIALLISTITEMID { get; set; }

		public string RMPRODUCTNAME { get; set; }

		public string RMPRODUCTREVISION { get; set; }

		public decimal? RMQTY { get; set; }

		public decimal? RMQTYREQUIRED { get; set; }

		public string RMREFERENCEDESIGNATOR { get; set; }

		public DateTime? SYSTEMDATE { get; set; }

		public DateTime? SYSTEMDATEGMT { get; set; }

		public DateTime? TXNDATE { get; set; }

		public DateTime? TXNDATEGMT { get; set; }

		public DateTime? TXNDATEISSUE { get; set; }

		public DateTime? TXNDATEREMOVE { get; set; }

		public DateTime? TXNDATEREPLACE { get; set; }

		public string WORKFLOWSTEPNAME { get; set; }

	}

}
