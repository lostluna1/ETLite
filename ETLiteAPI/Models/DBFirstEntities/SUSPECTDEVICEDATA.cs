using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class SUSPECTDEVICEDATA {

		public string SUSPECTDEVICEDATAID { get; set; }

		public string BRANDNAME { get; set; }

		public string CATALOGNUMBER { get; set; }

		public uint? CDOTYPEID { get; set; }

		public uint? CHANGECOUNT { get; set; }

		public string COMMONDEVICENAME { get; set; }

		public string CONCOMITANTPRODUCTNAME { get; set; }

		public DateTime? DEVICEMANUFACTUREDATE { get; set; }

		public DateTime? DEVICEMANUFACTUREDATEGMT { get; set; }

		public string EVENTDATAID { get; set; }

		public DateTime? EXPIRATIONDATE { get; set; }

		public DateTime? EXPIRATIONDATEGMT { get; set; }

		public string EXPORTIMPORTKEY { get; set; }

		public string LOTNUMBER { get; set; }

		public string MODELNUMBER { get; set; }

		public string OTHERNUMBER { get; set; }

		public string SERIALNUMBER { get; set; }

		public string SUSPECTDEVICENAME { get; set; }

		public string SUSPECTDEVICEREV { get; set; }

	}

}
