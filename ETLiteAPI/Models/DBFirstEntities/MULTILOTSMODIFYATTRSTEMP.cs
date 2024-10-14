using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class MULTILOTSMODIFYATTRSTEMP {

		public bool? ACCESSLEVEL { get; set; }

		public string ALTERNATENAME1 { get; set; }

		public string ALTERNATENAME2 { get; set; }

		public bool? APPLYTOCHILDLOTS { get; set; }

		public string ATTRIBUTECDONAME { get; set; }

		public string ATTRIBUTENAME { get; set; }

		public string ATTRIBUTEREVISION { get; set; }

		public string ATTRIBUTETYPEID { get; set; }

		public string ATTRIBUTETYPENAME { get; set; }

		public string ATTRIBUTEVALUE { get; set; }

		public string CDODEFID { get; set; }

		public string CDONAME { get; set; }

		public string CONTAINERNAME { get; set; }

		public string DBBASECOLUMNNAME { get; set; }

		public string DBCOLUMNNAME { get; set; }

		public string DBNAMECOLUMNNAME { get; set; }

		public string DBREVISIONCOLNAME { get; set; }

		public string DOCOLUMNNAME { get; set; }

		public string FIELDNAME { get; set; }

		public string FIELDTYPE { get; set; }

		public bool? ISUPDATED { get; set; }

		public string LOTTYPEID { get; set; }

		public string MODIFYATTRIBUTESETUPID { get; set; }

		public string MODIFYATTRSHISTORYDETAILSID { get; set; }

		public string OBJECTID { get; set; }

		public string OLDOBJECTID { get; set; }

		public string OLDREVISION { get; set; }

		public string OLDVALUE { get; set; }

		public decimal? PRECISIONVALUE { get; set; }

		public bool? REQUIREMODIFYATTRSREASON { get; set; }

		public string TABLENAME { get; set; }

		public bool? VALIDATIONFAIL { get; set; }

	}

}
