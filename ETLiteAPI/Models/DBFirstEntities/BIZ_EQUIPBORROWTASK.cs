using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class BIZ_EQUIPBORROWTASK {

		public string BIZ_EQUIPBORROWTASKID { get; set; }

		public string BIZ_BORROWATTACH { get; set; }

		public string BIZ_EQUIPBORROWERID { get; set; }

		public uint? BIZ_EQUIPBORROWQTY { get; set; }

		public string BIZ_EQUIPBORROWTASKNAME { get; set; }

		public DateTime? BIZ_EQUIPBORROWTIME { get; set; }

		public DateTime? BIZ_EQUIPDUETIME { get; set; }

		public string BIZ_EQUIPOPERATORID { get; set; }

		public string BIZ_EQUIPREMARK { get; set; }

		public DateTime? BIZ_EQUIPRETURNTIME { get; set; }

		public string BIZ_EQUIPSTATUSID { get; set; }

		public string BIZ_MATCHINGEQUIPID { get; set; }

		public string BIZ_MATCHINGPNID { get; set; }

		public uint? BIZ_MAXRETURNDAYQTY { get; set; }

		public string BIZ_OBJECTTYPE { get; set; }

		public uint? BIZ_OLDPARTRETURN { get; set; }

		public uint? BIZ_PARTBORROWACTUALQTY { get; set; }

		public uint? CDOTYPEID { get; set; }

		public uint? CHANGECOUNT { get; set; }

		public string CHANGEHISTORYID { get; set; }

		public string DESCRIPTION { get; set; }

		public string FILTERTAGS { get; set; }

		public uint? ICONID { get; set; }

		public uint? ISFROZEN { get; set; }

		public string NOTES { get; set; }

		public string SETUPACCESSID { get; set; }

	}

}
