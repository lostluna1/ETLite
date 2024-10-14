using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class MOVEHISTORY {

		public string MOVEHISTORYID { get; set; }

		public uint? CDOTYPEID { get; set; }

		public uint? CHANGECOUNT { get; set; }

		public uint? CHILDCOUNT { get; set; }

		public uint? CLOSEFLAG { get; set; }

		public uint? CONTAINERSTATUS { get; set; }

		public uint? CUMULATIVEREWORKSTEPCOUNT { get; set; }

		public decimal? CYCLETIME { get; set; }

		public decimal? ELAPSEDTIME { get; set; }

		public string ENDREWORKSTEPID { get; set; }

		public decimal? EQUIPMENTCYCLETIMEMS { get; set; }

		public string ES_TESTID { get; set; }

		public string EXPORTIMPORTKEY { get; set; }

		public string HISTORYID { get; set; }

		public string HISTORYMAINLINEID { get; set; }

		public string INTEGRATIONTXNID { get; set; }

		public uint? ISFAILED { get; set; }

		public string LOCATIONID { get; set; }

		public uint? MOVEALLQTY { get; set; }

		public string OWNERID { get; set; }

		public string PATHID { get; set; }

		public string PRODUCTID { get; set; }

		public decimal? QTY { get; set; }

		public decimal? QTY2 { get; set; }

		public string REENTRYSTEPID { get; set; }

		public uint? REMOTECONTAINERSTATUS { get; set; }

		public string REWORKREASONID { get; set; }

		public string RUN { get; set; }

		public string SETUPID { get; set; }

		public string SHIPMENTDESTINATIONID { get; set; }

		public string STEPID { get; set; }

		public string TOCUSTOMERID { get; set; }

		public string TOFACTORYID { get; set; }

		public string TOLOCATIONID { get; set; }

		public string TORESOURCEID { get; set; }

		public string TOSPECID { get; set; }

		public string TOSTEPID { get; set; }

		public uint? TOSTEPUSAGE { get; set; }

		public string TXNID { get; set; }

		public uint? UNITCOUNT { get; set; }

		public string UOM2ID { get; set; }

		public string UOMID { get; set; }

	}

}
