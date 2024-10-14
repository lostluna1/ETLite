using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class BIZ_PRODUCTIONDISPATCH {

		public string BIZ_PRODUCTIONDISPATCHID { get; set; }

		public string BIZ_PRODUCTIONDISPATCHNAME { get; set; }

		public uint? CDOTYPEID { get; set; }

		public uint? CHANGECOUNT { get; set; }

		public string CHANGEHISTORYID { get; set; }

		public DateTime? CREATIONDATE { get; set; }

		public string DESCRIPTION { get; set; }

		public uint? DISPATCHSTATUS { get; set; }

		public string FATHERMFGORDERID { get; set; }

		public string FILTERTAGS { get; set; }

		public string FOUNDERID { get; set; }

		public uint? ICONID { get; set; }

		public uint? ISFROZEN { get; set; }

		public string MFGLINEID { get; set; }

		public string MFGORDERID { get; set; }

		public DateTime? MODIFICATIONDATE { get; set; }

		public string MODIFIERID { get; set; }

		public string NOTES { get; set; }

		public string RESOURCEID { get; set; }

		public string SETUPACCESSID { get; set; }

		public string WIRENO { get; set; }

	}

}
