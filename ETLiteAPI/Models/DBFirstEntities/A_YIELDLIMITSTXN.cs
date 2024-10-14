using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class A_YIELDLIMITSTXN {

		public string YIELDLIMITSTXNID { get; set; }

		public uint? CDOTYPEID { get; set; }

		public uint? CHANGECOUNT { get; set; }

		public string CHANGEHISTORYID { get; set; }

		public string CONTAINERID { get; set; }

		public string DESCRIPTION { get; set; }

		public uint? FAILURECOUNT { get; set; }

		public string FAILUREEMAILGROUPID { get; set; }

		public string FAILUREHOLDREASONID { get; set; }

		public string FILTERTAGS { get; set; }

		public string HISTORYMAINLINEID { get; set; }

		public uint? ICONID { get; set; }

		public string INTEGRATIONTXNID { get; set; }

		public uint? ISFROZEN { get; set; }

		public string MFGLINEID { get; set; }

		public string NOTES { get; set; }

		public string OPERATIONID { get; set; }

		public string RESOURCEID { get; set; }

		public string SETUPACCESSID { get; set; }

		public DateTime? TXNDATE { get; set; }

		public DateTime? TXNDATEGMT { get; set; }

		public string TXNTYPENAME { get; set; }

		public string USERID { get; set; }

		public string USERNAME { get; set; }

		public string YIELDLIMITSID { get; set; }

		public string YIELDLIMITSTXNNAME { get; set; }

	}

}
