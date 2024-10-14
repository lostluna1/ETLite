using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class COMPUTATIONHISTORY {

		public string COMPUTATIONHISTORYID { get; set; }

		public string ATTRIBUTENAME { get; set; }

		public uint? CDOTYPEID { get; set; }

		public uint? CHANGECOUNT { get; set; }

		public string COMPUTATIONEXPRESSION { get; set; }

		public string COMPUTATIONID { get; set; }

		public string COMPUTATIONNAME { get; set; }

		public string EXPORTIMPORTKEY { get; set; }

		public string HISTORYID { get; set; }

		public string HISTORYMAINLINEID { get; set; }

		public string INTEGRATIONTXNID { get; set; }

		public uint? ISLIMITOVERRIDE { get; set; }

		public uint? ISLIMITOVERRIDEALLOWED { get; set; }

		public uint? ISLIMITVIOLATION { get; set; }

		public string LOWERLIMIT { get; set; }

		public uint? MAPTOCONTAINERATTRIBUTE { get; set; }

		public uint? RESULTDATATYPE { get; set; }

		public string RESULTNAME { get; set; }

		public string RESULTVALUE { get; set; }

		public string TXNID { get; set; }

		public string UPPERLIMIT { get; set; }

	}

}
