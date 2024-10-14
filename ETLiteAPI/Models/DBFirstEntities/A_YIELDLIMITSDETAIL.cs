using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class A_YIELDLIMITSDETAIL {

		public string YIELDLIMITSDETAILID { get; set; }

		public uint? CDOTYPEID { get; set; }

		public uint? CHANGECOUNT { get; set; }

		public uint? DETAILSEQUENCE { get; set; }

		public string EXPORTIMPORTKEY { get; set; }

		public uint? ISFROZEN { get; set; }

		public decimal? LOWERLIMIT { get; set; }

		public decimal? LOWERLIMIT2 { get; set; }

		public decimal? UPPERLIMIT { get; set; }

		public decimal? UPPERLIMIT2 { get; set; }

		public uint? YIELDASPECT { get; set; }

		public decimal? YIELDCUTLIMIT { get; set; }

		public decimal? YIELDCUTLIMIT2 { get; set; }

		public string YIELDLIMITSID { get; set; }

	}

}
