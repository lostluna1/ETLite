using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class AS_PRODUCT {

		public decimal? BIZ_ASSEMBLYSCRAPRATE { get; set; }

		public string BIZ_BUNAME { get; set; }

		public string BIZ_EXTPRODUCT { get; set; }

		public decimal? BIZ_GROSSWEIGHT { get; set; }

		public string BIZ_MATERIALFAMILYNAME { get; set; }

		public uint? BIZ_MATERIALLT { get; set; }

		public string BIZ_MRPCONTROLLER { get; set; }

		public DateTime? BIZ_MULTPSTATUSEFFSTARTDATE { get; set; }

		public decimal? BIZ_NETWEIGHT { get; set; }

		public decimal? BIZ_PACKINGQTY { get; set; }

		public string BIZ_POTYPENAME { get; set; }

		public decimal? BIZ_SCRAPRATE { get; set; }

		public uint? BIZ_SELFPRODUCTIONDAY { get; set; }

		public DateTime? BIZ_SINGLEPSTATUSEFFSTARTDATE { get; set; }

		public string BIZ_SPECIALPOTYPENAME { get; set; }

		public string BIZ_STDCOSTPRICE { get; set; }

		public string BIZ_STORAGELOCATION { get; set; }

		public string BIZ_SUPPLYTYPE { get; set; }

		public string DESCRIPTION { get; set; }

		public string EXSBSPECNAME { get; set; }

		public string MULTISTATUSMATERIALSTATUSNAME { get; set; }

		public string NETUOMNAME { get; set; }

		public string NOTES { get; set; }

		public string PRODUCTBASEID { get; set; }

		public string PRODUCTFAMILYNAME { get; set; }

		public string PRODUCTNAME { get; set; }

		public string PRODUCTREVISION { get; set; }

		public string PRODUCTTYPENAME { get; set; }

		public string SINGLESTATUSMATERIALSTATUSNAME { get; set; }

		public uint? STATUS { get; set; }

		public string UOMNAME { get; set; }

		public string WHSBSPECNAME { get; set; }

		public string WORKFLOWNAME { get; set; }

		public string WORKFLOWREVISION { get; set; }

	}

}
