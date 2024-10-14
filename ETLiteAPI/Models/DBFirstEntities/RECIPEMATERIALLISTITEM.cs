using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class RECIPEMATERIALLISTITEM {

		public string RECIPEMATERIALLISTITEMID { get; set; }

		public uint? ALLOWOVERCONSUMPTION { get; set; }

		public uint? ALLOWSUBSTITUTION { get; set; }

		public uint? ALLOWUNDERCONSUMPTION { get; set; }

		public uint? ASSEMBLYSEQUENCE { get; set; }

		public uint? CDOTYPEID { get; set; }

		public uint? CHANGECOUNT { get; set; }

		public DateTime? EFFECTIVEFROMDATE { get; set; }

		public DateTime? EFFECTIVEFROMDATEGMT { get; set; }

		public DateTime? EFFECTIVETHRUDATE { get; set; }

		public DateTime? EFFECTIVETHRUDATEGMT { get; set; }

		public uint? ES_MOUNTINGTECHNOLOGY { get; set; }

		public uint? ES_PCBSIDE { get; set; }

		public string EXPORTIMPORTKEY { get; set; }

		public uint? FEFOENFORCE { get; set; }

		public string FEFOOVERRIDEESIGREQUIREMENTID { get; set; }

		public uint? ISENABLED { get; set; }

		public uint? ISFROZEN { get; set; }

		public string ISIMAGEID { get; set; }

		public uint? ISPHANTOM { get; set; }

		public string ISPRODUCTDESCRIPTION { get; set; }

		public uint? ISSUECONTROL { get; set; }

		public string PHANTOMBILLID { get; set; }

		public string PRODUCINGORDER { get; set; }

		public string PRODUCTID { get; set; }

		public uint? QTYADDITIVE { get; set; }

		public string QTYREQUIREDLOWERLIMIT { get; set; }

		public string QTYREQUIREDNOMINAL { get; set; }

		public string QTYREQUIREDUPPERLIMIT { get; set; }

		public string RECIPEISSUEITEMID { get; set; }

		public string RECIPEMATERIALLISTITEMNAME { get; set; }

		public string REFERENCEDESIGNATOR { get; set; }

		public decimal? SCRAPPERCENT { get; set; }

		public decimal? SETUPQTY { get; set; }

		public decimal? SETUPQTY2 { get; set; }

		public string UOM2ID { get; set; }

		public string UOMID { get; set; }

		public uint? VENDORCONTROL { get; set; }

	}

}
