using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class BIZ_MFGORDERREPORT {

		public string BIZ_MFGORDERREPORTID { get; set; }

		public string ABNORMALHOUR { get; set; }

		public string ACTIVATIONHOUR { get; set; }

		public string BIZ_DEPTID { get; set; }

		public string BIZ_MFGORDERREPORTNAME { get; set; }

		public DateTime? CALENDARDAY { get; set; }

		public uint? CDOTYPEID { get; set; }

		public uint? CHANGECOUNT { get; set; }

		public string CHARGINGHOUR { get; set; }

		public DateTime? CONFIRMTIME { get; set; }

		public string CONFIRMUSERID { get; set; }

		public DateTime? CREATETIME { get; set; }

		public string CREATEUSERID { get; set; }

		public string ERPROUTEID { get; set; }

		public string EXCEPTIONDETAILS { get; set; }

		public string EXCEPTIONREASON { get; set; }

		public string FACTORYID { get; set; }

		public string HISTORYID { get; set; }

		public string HISTORYMAINLINEID { get; set; }

		public string INTEGRATIONTXNID { get; set; }

		public string LABORHOUR { get; set; }

		public DateTime? LASTUPDATETIME { get; set; }

		public string LASTUPDATEUSERID { get; set; }

		public string MACHINEHOUR { get; set; }

		public string MFGLINEID { get; set; }

		public string MFGORDERID { get; set; }

		public decimal? NGQTY { get; set; }

		public string PREPAREHOUR { get; set; }

		public string PRODUCTID { get; set; }

		public decimal? QTY { get; set; }

		public string REQUESTTYPE { get; set; }

		public string ROUTESTEPID { get; set; }

		public string ROUTESTEPNAME { get; set; }

		public string SHIFTID { get; set; }

		public uint? STATUS { get; set; }

		public string TXNID { get; set; }

	}

}
