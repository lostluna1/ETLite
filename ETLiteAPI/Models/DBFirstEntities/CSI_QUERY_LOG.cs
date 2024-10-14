using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class CSI_QUERY_LOG {

		public DateTime? LOG_DATE { get; set; }

		public string MESSAGE_TEXT { get; set; }

		public string QUERY_NAME { get; set; } = "SelectionValueEx_QualityObjectInquiry_QualityObject";

	}

}
