using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class DEFECTHISTORY {

		public string DEFECTHISTORYID { get; set; }

		public uint? CDOTYPEID { get; set; }

		public uint? CHANGECOUNT { get; set; }

		public string CHARGETOSTEPID { get; set; }

		public string CONTAINERLEVELINSPECTEDID { get; set; }

		public uint? CONTAINERSINSPECTED { get; set; }

		public string EXPORTIMPORTKEY { get; set; }

		public string HISTORYID { get; set; }

		public string HISTORYMAINLINEID { get; set; }

		public string INTEGRATIONTXNID { get; set; }

		public decimal? QTY2INSPECTED { get; set; }

		public decimal? QTYINSPECTED { get; set; }

		public string RESOURCEID { get; set; }

		public string TXNID { get; set; }

	}

}
