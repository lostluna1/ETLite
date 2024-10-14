using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class ISOEETHRUPUTDETAILS {

		public string ISOEETHRUPUTDETAILSID { get; set; }

		public string CALENDARSHIFTID { get; set; }

		public uint? CDOTYPEID { get; set; }

		public uint? CHANGECOUNT { get; set; }

		public uint? CHILDCOUNT { get; set; }

		public DateTime? CYCLESTARTGMT { get; set; }

		public decimal? CYCLETIME { get; set; }

		public uint? ES_NFFDEFECTCOUNT { get; set; }

		public decimal? GOODQTY { get; set; }

		public decimal? GOODQTY2 { get; set; }

		public decimal? IDEALCYCLETIME { get; set; }

		public string ISERPOPERATION { get; set; }

		public uint? ISFAILED { get; set; }

		public decimal? ISFAILEDQTY { get; set; }

		public string ISOEETHRUPUTDETAILSNAME { get; set; }

		public uint? ISOPENDEFECTCOUNT { get; set; }

		public string ISOPERATIONNAME { get; set; }

		public string ISRECIPENAME { get; set; }

		public uint? ISREPAIREDDEFECTCOUNT { get; set; }

		public string ISRESOURCENAME { get; set; }

		public string ISROUTESTEPNAME { get; set; }

		public string ISSPECNAME { get; set; }

		public string ISSPECREVISION { get; set; }

		public string ISSTEPNAME { get; set; }

		public uint? ISTOTALDEFECTCOUNT { get; set; }

		public string ISUOM { get; set; }

		public string ISUOM2 { get; set; }

		public string ISWORKFLOWNAME { get; set; }

		public string ISWORKFLOWREVISION { get; set; }

		public decimal? LOSSQTY { get; set; }

		public decimal? LOSSQTY2 { get; set; }

		public string OPERATIONID { get; set; }

		public string PARENTID { get; set; }

		public string RESOURCEID { get; set; }

		public decimal? REWORKEDQTY { get; set; }

		public decimal? REWORKEDQTY2 { get; set; }

		public string ROUTESTEPID { get; set; }

		public string SPECID { get; set; }

		public string STEPID { get; set; }

		public decimal? TOTALQTY { get; set; }

		public decimal? TOTALQTY2 { get; set; }

		public string WORKFLOWID { get; set; }

	}

}
