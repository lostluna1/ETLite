using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class ES_NPIJOB {

		public string ES_NPIJOBID { get; set; }

		public uint? CDOTYPEID { get; set; }

		public uint? CHANGECOUNT { get; set; }

		public string CHANGEHISTORYID { get; set; }

		public string DESCRIPTION { get; set; }

		public string ECO { get; set; }

		public string ES_CADDOCUMENTID { get; set; }

		public string ES_CADINSTRUCTIONSID { get; set; }

		public string ES_CADLAYERSID { get; set; }

		public string ES_CADPRIMARYID { get; set; }

		public uint? ES_COLUMNS { get; set; }

		public string ES_CREATEDBY { get; set; }

		public DateTime? ES_DATEOFCREATION { get; set; }

		public string ES_JOBFILE { get; set; }

		public DateTime? ES_LASTMODIFIED { get; set; }

		public string ES_NOTES { get; set; }

		public string ES_NPIJOBBASEID { get; set; }

		public uint? ES_PANELCONFIGURATION { get; set; }

		public uint? ES_ROWS { get; set; }

		public string ES_VERSION { get; set; }

		public string FILTERTAGS { get; set; }

		public uint? ICONID { get; set; }

		public uint? ISFROZEN { get; set; }

		public string NOTES { get; set; }

		public string REVISION { get; set; }

		public string SETUPACCESSID { get; set; }

		public uint? STATUS { get; set; }

		public string WIPMSGDEFMGRID { get; set; }

	}

}
