using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class A_YIELDLIMITSTXNDETAIL {

		public string YIELDLIMITSTXNDETAILID { get; set; }

		public decimal? BASEQTY { get; set; }

		public decimal? BASEQTY2 { get; set; }

		public uint? CDOTYPEID { get; set; }

		public uint? CHANGECOUNT { get; set; }

		public uint? DETAILSEQUENCE { get; set; }

		public string EXPORTIMPORTKEY { get; set; }

		public uint? FAILLOWERLIMIT { get; set; }

		public uint? FAILLOWERLIMIT2 { get; set; }

		public uint? FAILUPPERLIMIT { get; set; }

		public uint? FAILUPPERLIMIT2 { get; set; }

		public uint? FAILYIELDCUTLIMIT { get; set; }

		public uint? FAILYIELDCUTLIMIT2 { get; set; }

		public uint? ISFROZEN { get; set; }

		public decimal? LOWERLIMIT { get; set; }

		public decimal? LOWERLIMIT2 { get; set; }

		public decimal? QTY { get; set; }

		public decimal? QTY2 { get; set; }

		public decimal? UPPERLIMIT { get; set; }

		public decimal? UPPERLIMIT2 { get; set; }

		public uint? YIELDASPECT { get; set; }

		public decimal? YIELDCUTLIMIT { get; set; }

		public decimal? YIELDCUTLIMIT2 { get; set; }

		public string YIELDLIMITSTXNID { get; set; }

		public decimal? YIELDVALUE { get; set; }

		public decimal? YIELDVALUE2 { get; set; }

	}

}
