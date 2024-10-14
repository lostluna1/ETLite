using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class SPCVIOLATIONHISTORYDETAIL {

		public string SPCCHARTVIOLATIONSHISTDTLSID { get; set; }

		public uint? CDOTYPEID { get; set; }

		public uint? CHANGECOUNT { get; set; }

		public string CHARTVARIABLE { get; set; }

		public decimal? CL { get; set; }

		public string COLLECTEDDATAVALUE { get; set; }

		public string CONTAINERID { get; set; }

		public string CONTAINERNAME { get; set; }

		public string CUSTOMSPCDATAID { get; set; }

		public string DATAPOINTID { get; set; }

		public string DATAPOINTNAME { get; set; }

		public string DERIVEDCHARTDATAVALUE { get; set; }

		public string EXPORTIMPORTKEY { get; set; }

		public string FAILUREACTION { get; set; }

		public string HISTORYID { get; set; }

		public string HOLDREASONID { get; set; }

		public decimal? LCL { get; set; }

		public string PARAMETRICDATAID { get; set; }

		public string PARENTID { get; set; }

		public string RESOURCEID { get; set; }

		public string RESOURCENAME { get; set; }

		public string RESOURCESTATUSCODEID { get; set; }

		public string RULEVIOLATED { get; set; }

		public string TXNID { get; set; }

		public decimal? UCL { get; set; }

		public string VIOLATIONNAME { get; set; }

	}

}
