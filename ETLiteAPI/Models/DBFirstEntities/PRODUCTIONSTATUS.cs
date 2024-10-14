using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class PRODUCTIONSTATUS {

		public string PRODUCTIONSTATUSID { get; set; }

		public uint? AVAILABILITY { get; set; }

		public uint? CDOTYPEID { get; set; }

		public uint? CHANGECOUNT { get; set; }

		public string COMMENTS { get; set; }

		public string CONTAINERID { get; set; }

		public string ES_TOOLPLANDETAILID { get; set; }

		public string EXPORTIMPORTKEY { get; set; }

		public uint? INPROCESS { get; set; }

		public uint? ISOEELOSSCATEGORY { get; set; }

		public string ISTRACKINGCONTAINERID { get; set; }

		public uint? JOBCOUNT { get; set; }

		public DateTime? LASTACTIVITYDATE { get; set; }

		public DateTime? LASTACTIVITYDATEGMT { get; set; }

		public DateTime? LASTCOMPONENTSETUPDATE { get; set; }

		public DateTime? LASTCOMPONENTSETUPDATEGMT { get; set; }

		public string LASTPROCESSEDCONTAINERID { get; set; }

		public string LASTREVTXNID { get; set; }

		public string LASTROUTESTEPID { get; set; }

		public DateTime? LASTSTATUSCHANGEDATE { get; set; }

		public DateTime? LASTSTATUSCHANGEDATEGMT { get; set; }

		public DateTime? LASTTHRUPUTDATE { get; set; }

		public DateTime? LASTTHRUPUTDATEGMT { get; set; }

		public string MFGLINEID { get; set; }

		public string MFGORDERID { get; set; }

		public uint? PARTDECOMMISSIONED { get; set; }

		public DateTime? PARTEXPIRYDATE { get; set; }

		public string PARTEXPIRYSTATUS { get; set; }

		public uint? PARTLIFETIMECOUNT { get; set; }

		public uint? PARTLIFETIMECOUNT2 { get; set; }

		public string PARTLIFETIMESTATUS { get; set; }

		public string PARTLIFETIMESTATUS2 { get; set; }

		public uint? PARTQTY { get; set; }

		public uint? PARTRECONDITIONCOUNT { get; set; }

		public uint? PARTREQUESTCOUNT { get; set; }

		public uint? PARTUSAGECOUNT { get; set; }

		public uint? PARTUSAGECOUNT2 { get; set; }

		public string PARTUSAGESTATUS { get; set; }

		public string PARTUSAGESTATUS2 { get; set; }

		public string PHYSICALLOCATIONID { get; set; }

		public string PHYSICALPOSITIONID { get; set; }

		public string PRODUCTBASEID { get; set; }

		public string PRODUCTID { get; set; }

		public string REASONID { get; set; }

		public string RESOURCEID { get; set; }

		public uint? RESOURCESTATE { get; set; }

		public string RUN { get; set; }

		public string SETUPBASEID { get; set; }

		public string SETUPID { get; set; }

		public string STATUSID { get; set; }

		public decimal? TOTALTHRUPUTQTY { get; set; }

		public decimal? TOTALTHRUPUTQTY2 { get; set; }

		public string UOM2ID { get; set; }

		public string UOMID { get; set; }

		public uint? UPDATELASTSTATUSCHANGEDATE { get; set; }

	}

}
