using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class RESOURCESTATUSHISTORY {

		public string RESOURCESTATUSHISTORYID { get; set; }

		public uint? AVAILABILITY { get; set; }

		public uint? CDOTYPEID { get; set; }

		public uint? CHANGECOUNT { get; set; }

		public string COMMENTS { get; set; }

		public string EXPORTIMPORTKEY { get; set; }

		public string HISTORYID { get; set; }

		public string HISTORYMAINLINEID { get; set; }

		public string INTEGRATIONTXNID { get; set; }

		public uint? ISOEELOSSCATEGORY { get; set; }

		public uint? ISOLDOEELOSSCATEGORY { get; set; }

		public string ISRECIPEID { get; set; }

		public DateTime? LASTSTATUSCHANGEDATE { get; set; }

		public DateTime? LASTSTATUSCHANGEDATEGMT { get; set; }

		public string MFGLINEID { get; set; }

		public uint? OLDAVAILABILITY { get; set; }

		public string OLDCOMMENTS { get; set; }

		public DateTime? OLDLASTACTIVITYDATE { get; set; }

		public DateTime? OLDLASTACTIVITYDATEGMT { get; set; }

		public DateTime? OLDLASTSTATUSCHANGEDATE { get; set; }

		public DateTime? OLDLASTSTATUSCHANGEDATEGMT { get; set; }

		public string OLDMFGLINEID { get; set; }

		public DateTime? OLDPARTEXPIRYDATE { get; set; }

		public uint? OLDPARTQTY { get; set; }

		public string OLDPHYSICALLOCATIONID { get; set; }

		public string OLDPHYSICALPOSITIONID { get; set; }

		public string OLDPRODUCTID { get; set; }

		public uint? OLDRESOURCESTATE { get; set; }

		public string OLDRESOURCESTATUSCODEID { get; set; }

		public string OLDRESOURCESTATUSREASONCODEID { get; set; }

		public string OLDRUN { get; set; }

		public string OLDSETUPID { get; set; }

		public uint? OLDUPDATELASTSTATUSCHANGEDATE { get; set; }

		public DateTime? PARTEXPIRYDATE { get; set; }

		public uint? PARTQTY { get; set; }

		public string PHYSICALLOCATIONID { get; set; }

		public string PHYSICALPOSITIONID { get; set; }

		public string PRODUCTID { get; set; }

		public uint? RESOURCESTATE { get; set; }

		public string RESOURCESTATUSCODEID { get; set; }

		public string RESOURCESTATUSREASONCODEID { get; set; }

		public string RUN { get; set; }

		public string SETUPID { get; set; }

		public string SS_NEWLOCATIONID { get; set; }

		public string SS_OLDLOCATIONID { get; set; }

		public string TXNID { get; set; }

		public uint? UPDATELASTSTATUSCHANGEDATE { get; set; }

		public uint? UPDATEPARAMS { get; set; }

	}

}
