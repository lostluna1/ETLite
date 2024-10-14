using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class BIZ_AXISLABELPRINTING {

		public string BIZ_AXISLABELPRINTINGID { get; set; }

		public string ADDITIONALDESCRIPTION { get; set; }

		public string BIZ_AXISLABELPRINTINGNAME { get; set; }

		public uint? CDOTYPEID { get; set; }

		public uint? CHANGECOUNT { get; set; }

		public string CONTAINERQTY { get; set; }

		public string CONTROLNUMBER { get; set; }

		public DateTime? CREATETIME { get; set; }

		public string CREATORID { get; set; }

		public string FATHERMFGORDERID { get; set; }

		public string FATHERPRODUCT { get; set; }

		public string FATHERPRODUCTDESCRIPTION { get; set; }

		public string FINALPRINTERID { get; set; }

		public DateTime? FINALPRINTTIME { get; set; }

		public string HISTORYID { get; set; }

		public string HISTORYMAINLINEID { get; set; }

		public string INTEGRATIONTXNID { get; set; }

		public string JOINTONEDESCRIPTION { get; set; }

		public string JOINTTHREEDESCRIPTION { get; set; }

		public string JOINTTWODESCRIPTION { get; set; }

		public string MATCHINGFLOW { get; set; }

		public string MFGORDERID { get; set; }

		public uint? PRINTCOUNT { get; set; }

		public string PRODUCT { get; set; }

		public string PRODUCTDESCRIPTION { get; set; }

		public decimal? QTY { get; set; }

		public string RESOURCEID { get; set; }

		public string SN { get; set; }

		public string TOPMFGORDERID { get; set; }

		public string TOPPRODUCT { get; set; }

		public string TXNID { get; set; }

	}

}
