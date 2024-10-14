using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class DATAPOINT {

		public string DATAPOINTID { get; set; }

		public string ATTRIBUTENAME { get; set; }

		public string BOOLEANFALSE { get; set; }

		public string BOOLEANTRUE { get; set; }

		public uint? CDOTYPEID { get; set; }

		public uint? CHANGECOUNT { get; set; }

		public uint? COLUMNPOSITION { get; set; }

		public string DATACOLLECTIONDEFID { get; set; }

		public string DATAPOINTNAME { get; set; }

		public uint? DATATYPE { get; set; }

		public uint? DECIMALSCALE { get; set; }

		public uint? DISPLAYLIMITS { get; set; }

		public uint? DISPLAYMODE { get; set; }

		public string EXPORTIMPORTKEY { get; set; }

		public string FAILUREHOLDREASONID { get; set; }

		public string FAILURERESOURCESTATUSCODEID { get; set; }

		public string FAILURERESOURCESTATUSREASONID { get; set; }

		public string INNERLOWERLIMIT { get; set; }

		public string INNERUPPERLIMIT { get; set; }

		public string ISDEFECTREASONID { get; set; }

		public uint? ISFROZEN { get; set; }

		public uint? ISLIMITOVERRIDEALLOWED { get; set; }

		public uint? ISREQUIRED { get; set; }

		public uint? ISREQUIREDEFECTREASON { get; set; }

		public string LISTFIELDEXPRESSION { get; set; }

		public string LOWERLIMIT { get; set; }

		public uint? MAPTOUSERATTRIBUTE { get; set; }

		public uint? MINIMUMSAMPLES { get; set; }

		public string OBJECTGROUPID { get; set; }

		public uint? OBJECTSELVALTYPE { get; set; }

		public uint? OBJECTTYPE { get; set; }

		public string OUTERLOWERLIMIT { get; set; }

		public string OUTERUPPERLIMIT { get; set; }

		public string QUERYNAME { get; set; }

		public uint? QUERYTYPE { get; set; }

		public uint? ROUNDINGRULE { get; set; }

		public uint? ROWPOSITION { get; set; }

		public uint? SEQUENCE { get; set; }

		public string UOMID { get; set; }

		public string UPPERLIMIT { get; set; }

	}

}
