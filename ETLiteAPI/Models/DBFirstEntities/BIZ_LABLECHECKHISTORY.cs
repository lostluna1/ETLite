using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class BIZ_LABLECHECKHISTORY {

		public string BIZ_LABLECHECKHISTORYID { get; set; }

		public string BARCODELENGTH { get; set; }

		public string BIZ_LABLECHECKHISTORYNAME { get; set; }

		public uint? CDOTYPEID { get; set; }

		public uint? CHANGECOUNT { get; set; }

		public string CHECKENDPOSITION { get; set; }

		public string CHECKSTARTPOSITION { get; set; }

		public string CHECKVALUE { get; set; }

		public string CONTAINERID { get; set; }

		public string CONTAINERNAME { get; set; }

		public string HISTORYID { get; set; }

		public string HISTORYMAINLINEID { get; set; }

		public string INTEGRATIONTXNID { get; set; }

		public string LABLECHECKGROUPNAME { get; set; }

		public string LABLECHECKPLANNAME { get; set; }

		public string LABLEITEMNAME { get; set; }

		public string PRODUCTID { get; set; }

		public string SCANEMPLOYEEID { get; set; }

		public string SCANRESULT { get; set; }

		public DateTime? SCANTIME { get; set; }

		public uint? SEQUENCE { get; set; }

		public string SPECID { get; set; }

		public string TXNID { get; set; }

	}

}
