using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class CONTAINERMAINTHISTDETAIL {

		public string CONTAINERMAINTHISTDETAILID { get; set; }

		public string BILLOFPROCESSID { get; set; }

		public uint? CDOTYPEID { get; set; }

		public uint? CHANGECOUNT { get; set; }

		public string CHGCONTAINERATTRHISTORYID { get; set; }

		public string CONTAINERCOMMENTS { get; set; }

		public string CUSTOMERID { get; set; }

		public string CUSTOMERSERIALNUMBER { get; set; }

		public DateTime? DUEDATE { get; set; }

		public DateTime? DUEDATEGMT { get; set; }

		public DateTime? ES_MANUFACTURINGDATE { get; set; }

		public string ES_PRIMARYSERIALNUMBER { get; set; }

		public string ES_SERIALNUMBER2 { get; set; }

		public string ES_SERIALNUMBER3 { get; set; }

		public DateTime? EXPIRATIONDATE { get; set; }

		public string EXPORTIMPORTKEY { get; set; }

		public string FACTORYID { get; set; }

		public string HISTORYID { get; set; }

		public string INTEGRATIONTXNID { get; set; }

		public uint? ISPREHISTORY { get; set; }

		public string LEVELID { get; set; }

		public string LINENUMBER { get; set; }

		public string LOCATIONID { get; set; }

		public string MFGLINEID { get; set; }

		public string MFGORDERID { get; set; }

		public string NAME { get; set; }

		public string OWNERID { get; set; }

		public string PLANNEDPRODUCTID { get; set; }

		public decimal? PLANNEDQTY { get; set; }

		public decimal? PLANNEDQTY2 { get; set; }

		public string PLANNEDQTYUOM2ID { get; set; }

		public string PLANNEDQTYUOMID { get; set; }

		public string PONUMBER { get; set; }

		public string PRIORITYID { get; set; }

		public string PRODUCTID { get; set; }

		public DateTime? RECEIVEDDATE { get; set; }

		public string REFERENCECONTAINERNAME { get; set; }

		public uint? RELATIVEPRIORITY { get; set; }

		public DateTime? REQUESTDATE { get; set; }

		public DateTime? REQUESTDATEGMT { get; set; }

		public string RESOURCEID { get; set; }

		public string RMANUMBER { get; set; }

		public string SALESORDERID { get; set; }

		public string STARTREASONID { get; set; }

		public string TXNID { get; set; }

		public string UOM2ID { get; set; }

		public string UOMID { get; set; }

		public string VENDORITEMID { get; set; }

		public string VENDORLOTNUMBER { get; set; }

		public string VENDORNAME { get; set; }

	}

}
