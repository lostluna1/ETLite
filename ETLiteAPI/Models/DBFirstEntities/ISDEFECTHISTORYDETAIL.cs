using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class ISDEFECTHISTORYDETAIL {

		public string ISDEFECTHISTORYDETAILID { get; set; }

		public uint? CDOTYPEID { get; set; }

		public uint? CHANGECOUNT { get; set; }

		public string CONTAINERID { get; set; }

		public uint? DEFECTCOUNT { get; set; }

		public string DEFECTHISTORYID { get; set; }

		public string ES_ASSEMBLYSHAPE { get; set; }

		public DateTime? ES_AUTOINSPECTTIMESTAMP { get; set; }

		public uint? ES_BOARDSIDE { get; set; }

		public string ES_HVISSUEKEY { get; set; }

		public string ES_ISSUEACTUALSHISTORYID { get; set; }

		public string ES_NET1 { get; set; }

		public string ES_NET2 { get; set; }

		public uint? ES_PCBNUMBER { get; set; }

		public string ES_PIN { get; set; }

		public string ES_PIN2 { get; set; }

		public uint? ES_SEGMENT1X1 { get; set; }

		public uint? ES_SEGMENT1X2 { get; set; }

		public uint? ES_SEGMENT1Y1 { get; set; }

		public uint? ES_SEGMENT1Y2 { get; set; }

		public uint? ES_SEGMENT2X1 { get; set; }

		public uint? ES_SEGMENT2X2 { get; set; }

		public uint? ES_SEGMENT2Y1 { get; set; }

		public uint? ES_SEGMENT2Y2 { get; set; }

		public string ES_SYMPTOM { get; set; }

		public string HISTORYID { get; set; }

		public string INTEGRATIONTXNID { get; set; }

		public string ISCOMMENTS { get; set; }

		public string ISCONTAINERID { get; set; }

		public DateTime? ISCREATEDATE { get; set; }

		public string ISDEFECTHISTORYDETAILNAME { get; set; }

		public string ISDEFECTREASONID { get; set; }

		public string ISGUID { get; set; }

		public string ISINSPECTNOTE { get; set; }

		public string ISINSPECTUSERID { get; set; }

		public string ISLOTNUMBER { get; set; }

		public string ISMFGORDERID { get; set; }

		public string ISOPERATIONID { get; set; }

		public string ISPRODUCTID { get; set; }

		public string ISREFDES { get; set; }

		public DateTime? ISREPAIRDATE { get; set; }

		public string ISREPAIRNOTES { get; set; }

		public string ISREPAIROPERATIONID { get; set; }

		public string ISREPAIRRESOURCEID { get; set; }

		public string ISREPAIRSPECID { get; set; }

		public string ISREPAIRUSERID { get; set; }

		public uint? ISREQUIREDEFECTREASON { get; set; }

		public string ISRESOURCEID { get; set; }

		public string ISSEVERITYID { get; set; }

		public string ISSPECID { get; set; }

		public uint? ISSTATUS { get; set; }

		public DateTime? ISUPDATEDATE { get; set; }

		public string ISWORKFLOWID { get; set; }

		public string ISWORKFLOWSTEPID { get; set; }

		public uint? ISX { get; set; }

		public uint? ISY { get; set; }

		public string REASONCODEID { get; set; }

		public string TXNID { get; set; }

	}

}
