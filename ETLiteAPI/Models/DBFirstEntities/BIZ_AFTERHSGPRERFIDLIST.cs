﻿using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class BIZ_AFTERHSGPRERFIDLIST {

		public string BIZ_AFTERHSGPRERFIDLISTID { get; set; }

		public string BIZ_AFERPROCESSINGHSGID { get; set; }

		public string BIZ_AFTERHSGPRERFIDLISTNAME { get; set; }

		public string BIZ_BUID { get; set; }

		public string BIZ_RFID { get; set; }

		public uint? CDOTYPEID { get; set; }

		public uint? CHANGECOUNT { get; set; }

		public string COMMENTS { get; set; }

		public string CONTAINERID { get; set; }

		public string EMPLOYEEID { get; set; }

		public string HISTORYID { get; set; }

		public string INTEGRATIONTXNID { get; set; }

		public string LINEID { get; set; }

		public decimal? ORIGINALQTY { get; set; }

		public string PRODUCTID { get; set; }

		public decimal? QTY { get; set; }

		public string RESOURCEID { get; set; }

		public string RFIDEMPNOID { get; set; }

		public DateTime? RFIDOPERATETIME { get; set; }

		public string SHIFTID { get; set; }

		public string SPECID { get; set; }

		public uint? STATUS { get; set; }

		public string TXNID { get; set; }

	}

}
