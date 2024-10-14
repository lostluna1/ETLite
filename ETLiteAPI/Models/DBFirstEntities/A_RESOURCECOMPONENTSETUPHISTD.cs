using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class A_RESOURCECOMPONENTSETUPHISTD {

		public string RESOURCECOMPONENTSETUPHISTDID { get; set; }

		public uint? BIZ_FEEDING { get; set; }

		public string BIZ_MFGORDERID { get; set; }

		public uint? CDOTYPEID { get; set; }

		public uint? CHANGECOUNT { get; set; }

		public DateTime? CREATETIME { get; set; }

		public string EMPLOYEEID { get; set; }

		public string EXPORTIMPORTKEY { get; set; }

		public uint? FEEDERBANKACTION { get; set; }

		public string FEEDERBANKID { get; set; }

		public string FROMCONTAINERID { get; set; }

		public string FROMFEEDERID { get; set; }

		public string FROMFEEDERSLOTID { get; set; }

		public string FROMLOT { get; set; }

		public string FROMSTOCKPOINT { get; set; }

		public string HISTORYID { get; set; }

		public string INTEGRATIONTXNID { get; set; }

		public uint? ISSUECONTROL { get; set; }

		public string ISSUEDIFFERENCEREASONID { get; set; }

		public string PRODUCTID { get; set; }

		public string RESOURCECOMPONENTSETUPHISTID { get; set; }

		public string SUBSTITUTIONREASONID { get; set; }

		public string TXNID { get; set; }

	}

}
