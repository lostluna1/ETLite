using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class ES_CONTAINERVIEW {

		public string CARRIERID { get; set; }

		public uint? CHILDCOUNT { get; set; }

		public string CONTAINERID { get; set; }

		public string CONTAINERLEVELNAME { get; set; }

		public string CONTAINERNAME { get; set; }

		public uint? CURRENTHOLDCOUNT { get; set; }

		public string CURRENTSTATUSID { get; set; }

		public uint? CURRENTSTEPPASS { get; set; }

		public string DESCRIPTION { get; set; }

		public uint? ES_HOLDTYPE { get; set; }

		public string ES_NPIJOBID { get; set; }

		public uint? ES_PCBNUMBER { get; set; }

		public uint? ES_PERFORMMFGORDERREASSIGNPC { get; set; }

		public string ES_PRIMARYSERIALNUMBER { get; set; }

		public string ES_PRODUCTIONBOMID { get; set; }

		public string ES_SERIALNUMBER2 { get; set; }

		public string ES_SERIALNUMBER3 { get; set; }

		public uint? ES_XOUT { get; set; }

		public DateTime? EXPIRATIONDATE { get; set; }

		public DateTime? EXPIRATIONDATEGMT { get; set; }

		public string FACTORYID { get; set; }

		public string FACTORYNAME { get; set; }

		public string GROUPID { get; set; }

		public string IDENTIFIER { get; set; }

		public uint? INPROCESS { get; set; }

		public uint? ISCARRIER { get; set; }

		public uint? ISCARRIERSLOT { get; set; }

		public uint? ISFAILED { get; set; }

		public string ISTRACKINGCONTAINERID { get; set; }

		public string LINENUMBER { get; set; }

		public string MFGLINENAME { get; set; }

		public string MFGORDERID { get; set; }

		public string MFGORDERNAME { get; set; }

		public string OPERATIONID { get; set; }

		public string OPERATIONNAME { get; set; }

		public string ORIGINALCONTAINERID { get; set; }

		public string PARENTCONTAINERID { get; set; }

		public string PARENTCONTAINERIDENTIFIER { get; set; }

		public string PRODUCTID { get; set; }

		public string PRODUCTNAME { get; set; }

		public string PRODUCTREVISION { get; set; }

		public decimal? QTY { get; set; }

		public string RESOURCEID { get; set; }

		public uint? REWORKLOOPCOUNT { get; set; }

		public uint? REWORKTOTALCOUNT { get; set; }

		public string SPECID { get; set; }

		public string STARTPARENTCONTAINERID { get; set; }

		public uint? STATUS { get; set; }

		public string WORKCENTERID { get; set; }

		public string WORKCENTERNAME { get; set; }

		public string WORKFLOWSTEPID { get; set; }

	}

}
