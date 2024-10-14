using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class BIZ_MFGCHECKLIST {

		public string BIZ_MFGCHECKLISTID { get; set; }

		public DateTime? BIZ_COMPLETEDATE { get; set; }

		public DateTime? BIZ_CONFIRMDATE { get; set; }

		public DateTime? BIZ_CREATEDATE { get; set; }

		public string BIZ_CREATEEMPLOYEEID { get; set; }

		public uint? BIZ_ISCONFIRM { get; set; }

		public string BIZ_MFGCHECKLISTNAME { get; set; }

		public string BIZ_PRINCIPALID { get; set; }

		public uint? CDOTYPEID { get; set; }

		public uint? CHANGECOUNT { get; set; }

		public string CHANGEHISTORYID { get; set; }

		public string DATANAME { get; set; }

		public uint? DATATYPE { get; set; }

		public string DATAVALUE { get; set; }

		public string DESCRIPTION { get; set; }

		public string FILTERTAGS { get; set; }

		public uint? ICONID { get; set; }

		public string IMPROVETTHESITUATION { get; set; }

		public uint? ISFROZEN { get; set; }

		public string MFGLINEID { get; set; }

		public string MFGORDERID { get; set; }

		public string NOTES { get; set; }

		public string PRODUCTID { get; set; }

		public string PRODUCTIONTYPE { get; set; }

		public string REMARK { get; set; }

		public string SETUPACCESSID { get; set; }

		public uint? STATUSDETERMINATION { get; set; }

	}

}
