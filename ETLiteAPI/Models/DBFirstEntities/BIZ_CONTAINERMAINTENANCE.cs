using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class BIZ_CONTAINERMAINTENANCE {

		public string BIZ_CONTAINERMAINTENANCEID { get; set; }

		public string BIZ_CONTAINERMAINTENANCENAME { get; set; }

		public string BIZ_RFID { get; set; }

		public string CAUSEANALYSIS { get; set; }

		public uint? CDOTYPEID { get; set; }

		public uint? CHANGECOUNT { get; set; }

		public string COMMENTS { get; set; }

		public string CONFIRMERID { get; set; }

		public DateTime? CONFIRMTIME { get; set; }

		public string CONTAINERID { get; set; }

		public DateTime? CREATETIME { get; set; }

		public string DEFECTLOCATION { get; set; }

		public string EMPLOYEEID { get; set; }

		public string HISTORYID { get; set; }

		public string HISTORYMAINLINEID { get; set; }

		public string IMPROVESTRATEGY { get; set; }

		public string INTEGRATIONTXNID { get; set; }

		public string ISDEFECTREASONID { get; set; }

		public string ISREPAIRACTIONID { get; set; }

		public uint? MAINTENANCECOUNT { get; set; }

		public string MOVEHISTORYID { get; set; }

		public string STATUS { get; set; }

		public string STEPID { get; set; }

		public string TXNID { get; set; }

	}

}
