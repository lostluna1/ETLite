using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class RV_TOOLUSAGE {

		public string CONTAINERID { get; set; }

		public string CONTAINERNAME { get; set; }

		public string EMPLOYEENAME { get; set; }

		public string IDENTIFIER { get; set; }

		public DateTime? MOVEINDATE { get; set; }

		public DateTime? MOVEOUTDATE { get; set; }

		public string RESOURCENAME { get; set; }

		public string RESOURCETOOL { get; set; }

		public string SPEC { get; set; }

		public uint? TOOLACTION { get; set; }

		public string TOOLACTIONNAME { get; set; }

		public string TOOLNAME { get; set; }

		public DateTime? TXNDATE { get; set; }

		public DateTime? TXNDATEGMT { get; set; }

	}

}
