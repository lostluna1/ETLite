using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class BIZ_MOPCBASNCREATHISDET {

		public string BIZ_MOPCBASNCREATHISDETID { get; set; }

		public string BGADATA { get; set; }

		public string BGALOT { get; set; }

		public string BIZ_MOPCBASNCREATHISDETNAME { get; set; }

		public string BIZ_MOPCBASNCREATHISID { get; set; }

		public uint? CDOTYPEID { get; set; }

		public uint? CHANGECOUNT { get; set; }

		public uint? CRTRULECODE { get; set; }

		public string HISTORYID { get; set; }

		public string INTEGRATIONTXNID { get; set; }

		public uint? ISLASER { get; set; }

		public uint? ISUPLOAD { get; set; }

		public DateTime? LASERTIME { get; set; }

		public string PANELID { get; set; }

		public string PCBASN { get; set; }

		public string PCSID { get; set; }

		public uint? PRIORITY { get; set; }

		public string SERIALCODE { get; set; }

		public string TXNID { get; set; }

		public string UPLOADEMPLOYEEID { get; set; }

		public DateTime? UPLOADTIME { get; set; }

	}

}
