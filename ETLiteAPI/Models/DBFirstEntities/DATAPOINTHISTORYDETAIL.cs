using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class DATAPOINTHISTORYDETAIL {

		public string DATAPOINTHISTORYDETAILID { get; set; }

		public string ATTRIBUTENAME { get; set; }

		public uint? BOOLEANVALUE { get; set; }

		public uint? CDOTYPEID { get; set; }

		public uint? CHANGECOUNT { get; set; }

		public string COMMENTS { get; set; }

		public string DATACOLLECTIONDEFID { get; set; }

		public string DATANAME { get; set; }

		public string DATAPOINTHISTORYID { get; set; }

		public string DATAPOINTID { get; set; }

		public uint? DATATYPE { get; set; }

		public string DATAVALUE { get; set; }

		public uint? DECIMALSCALE { get; set; }

		public decimal? DECIMALVALUE { get; set; }

		public string ENUMERATIONVALUE { get; set; }

		public string EXPORTIMPORTKEY { get; set; }

		public decimal? FIXEDVALUE { get; set; }

		public decimal? FLOATVALUE { get; set; }

		public string HISTORYID { get; set; }

		public uint? INTEGERVALUE { get; set; }

		public string INTEGRATIONTXNID { get; set; }

		public string ISDEFECTREASONID { get; set; }

		public uint? ISLIMITOVERRIDE { get; set; }

		public uint? ISLIMITOVERRIDEALLOWED { get; set; }

		public uint? ISLIMITVIOLATION { get; set; }

		public uint? ISREQUIRED { get; set; }

		public uint? ISREQUIREDEFECTREASON { get; set; }

		public string LOWERLIMIT { get; set; }

		public uint? MAPTOUSERATTRIBUTE { get; set; }

		public string NDOVALUEID { get; set; }

		public string OBJECTTYPENAME { get; set; }

		public string ORIGINALVALUE { get; set; }

		public string RDOVALUEID { get; set; }

		public DateTime? TIMESTAMPVALUE { get; set; }

		public string TXNID { get; set; }

		public string UOMID { get; set; }

		public string UPPERLIMIT { get; set; }

	}

}
