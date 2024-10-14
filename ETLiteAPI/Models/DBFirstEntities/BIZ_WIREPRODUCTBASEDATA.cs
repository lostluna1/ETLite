using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class BIZ_WIREPRODUCTBASEDATA {

		public string BIZ_WIREPRODUCTBASEDATAID { get; set; }

		public string BIZ_WIREPRODUCTBASEDATANAME { get; set; }

		public uint? CDOTYPEID { get; set; }

		public uint? CHANGECOUNT { get; set; }

		public string CHANGEHISTORYID { get; set; }

		public decimal? CONDUCTOROD { get; set; }

		public decimal? CONDUCTORSA { get; set; }

		public string DESCRIPTION { get; set; }

		public string FACTORYID { get; set; }

		public string FILTERTAGS { get; set; }

		public uint? ICONID { get; set; }

		public uint? ISAVAILABLE { get; set; }

		public uint? ISFROZEN { get; set; }

		public string NOTES { get; set; }

		public string SETUPACCESSID { get; set; }

		public string SPECIFICATIONCODE { get; set; }

		public string WIRECOLOR { get; set; }

		public string WIRERODPRODUCTID { get; set; }

		public string WIRESPECIFICATIONS { get; set; }

	}

}
