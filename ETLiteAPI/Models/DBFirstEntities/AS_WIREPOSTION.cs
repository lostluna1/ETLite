using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class AS_WIREPOSTION {

		public decimal? CUTTINGLENGTH { get; set; }

		public string PARTNO { get; set; }

		public string PRINTINGCONTENT { get; set; }

		public string SPECIFICATIONCODE { get; set; }

		public string WIRECOLOR { get; set; }

		public string WIREGROUPID { get; set; }

		public string WIRENO { get; set; }

		public string WIREPRODUCT { get; set; }

		public string WIRERODPRODUCT { get; set; }

		public string WIRESPECIFICATIONS { get; set; }

		public string XENGTOOLFAMILY { get; set; }

		public string XMERGECRIMPING { get; set; }

		public string XMERGINGID { get; set; }

		public uint? XMERGINGNO { get; set; }

		public string XTERMINALPOSITION { get; set; }

		public string XTERMINALPRODUCT { get; set; }

		public string XUSAGEMERGINGID { get; set; }

		public string YENGTOOLFAMILY { get; set; }

		public string YMERGECRIMPING { get; set; }

		public string YMERGINGID { get; set; }

		public uint? YMERGINGNO { get; set; }

		public string YTERMINALPOSITION { get; set; }

		public string YTERMINALPRODUCT { get; set; }

		public string YUSAGEMERGINGID { get; set; }

	}

}
