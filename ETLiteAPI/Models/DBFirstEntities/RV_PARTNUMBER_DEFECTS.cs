using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class RV_PARTNUMBER_DEFECTS {

		public string CONTAINERID { get; set; }

		public string CONTAINERNAME { get; set; }

		public uint? ES_BOARDSIDE { get; set; }

		public string ES_NET1 { get; set; }

		public string ES_NET2 { get; set; }

		public uint? ES_PCBNUMBER { get; set; }

		public string ES_PIN { get; set; }

		public string ES_PIN2 { get; set; }

		public string ES_PRIMARYSERIALNUMBER { get; set; }

		public string ES_SERIALNUMBER2 { get; set; }

		public string ES_SERIALNUMBER3 { get; set; }

		public string ISDEFECTREASONNAME { get; set; }

		public string ISDEFECTSEVERITYNAME { get; set; }

		public string ISREFDES { get; set; }

		public uint? ISSTATUS { get; set; }

		public uint? ISX { get; set; }

		public uint? ISY { get; set; }

		public string PARENTCONTAINERID { get; set; }

		public string PARENTCONTAINERNAME { get; set; }

		public string PARENTPRIMARYSERIALNUMBER { get; set; }

	}

}
