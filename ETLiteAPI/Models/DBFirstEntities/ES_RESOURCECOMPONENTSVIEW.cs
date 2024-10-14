using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class ES_RESOURCECOMPONENTSVIEW {

		public string CONTAINERNAME { get; set; }

		public string CONTAINERPRODUCT { get; set; }

		public string CONTAINERPRODUCTID { get; set; }

		public string CONTAINERREVISION { get; set; }

		public string FEEDERCONTAINERID { get; set; }

		public string FeederContainerName { get; set; }

		public string FeederIdentifier { get; set; }

		public string FeederProductId { get; set; }

		public string FeederProductName { get; set; }

		public string FeederProductRevision { get; set; }

		public decimal? FeederQty { get; set; }

		public string FeederSlotName { get; set; }

		public string FROMCONTAINERID { get; set; }

		public string FROMFEEDER { get; set; }

		public string FROMLOT { get; set; }

		public string FROMSTOCKPOINT { get; set; }

		public string IDENTIFIER { get; set; }

		public uint? ISSUECONTROL { get; set; }

		public string ISSUEDIFFERENCEREASONNAME { get; set; }

		public string PRODUCTID { get; set; }

		public string PRODUCTNAME { get; set; }

		public string PRODUCTREVISION { get; set; }

		public decimal? QTY { get; set; }

		public string RESOURCECOMPONENTSID { get; set; }

		public string RESOURCENAME { get; set; }

		public uint? SLOTSEQUENCE { get; set; }

		public string SUBSTITUTIONREASONNAME { get; set; }

	}

}
