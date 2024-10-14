using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class BIZ_FOURINONELABLECORRELATION {

		public string BIZ_FOURINONELABLECORRELATIOID { get; set; }

		public string ATEDATE { get; set; }

		public string ATESERIALCODE { get; set; }

		public string ATESN { get; set; }

		public string BIZ_FOURINONELABLECORRELATNAME { get; set; }

		public uint? CDOTYPEID { get; set; }

		public uint? CHANGECOUNT { get; set; }

		public string CHANGEHISTORYID { get; set; }

		public string CONTAINERID { get; set; }

		public DateTime? CREATIONTIME { get; set; }

		public string CREATORID { get; set; }

		public string DESCRIPTION { get; set; }

		public string DOCKDC { get; set; }

		public string DOCKPN { get; set; }

		public string DOCKREV { get; set; }

		public string DOCKSERIALCODE { get; set; }

		public string FILTERTAGS { get; set; }

		public DateTime? GENERATIONTIME { get; set; }

		public string GENERATORID { get; set; }

		public uint? ICONID { get; set; }

		public uint? ISFROZEN { get; set; }

		public string MAC { get; set; }

		public string MFGORDERID { get; set; }

		public string NOTES { get; set; }

		public string PPID { get; set; }

		public string SERVICECODE { get; set; }

		public string SERVICETAG { get; set; }

		public string SETUPACCESSID { get; set; }

	}

}
