using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class ES_CONTAINEREXVIEW {

		public uint? AUTOCOMPONENTISSUE { get; set; }

		public string BOMID { get; set; }

		public string CONTAINERNAME { get; set; }

		public string DOCUMENTNAME { get; set; }

		public string DOCUMENTREVISION { get; set; }

		public string ERPBOMID { get; set; }

		public uint? ES_AUTOOPENINSTRUCTIONS { get; set; }

		public string ES_CADDOCUMENTID { get; set; }

		public string ES_CADINSTRUCTIONSID { get; set; }

		public string ES_CADLAYERSID { get; set; }

		public string ES_CADPRIMARYID { get; set; }

		public uint? ES_FIRSTARTICLEMODE { get; set; }

		public uint? ES_FIRSTARTICLETRACKINGMODE { get; set; }

		public uint? ES_GUIDEDMANUALASSEMBLY { get; set; }

		public uint? ES_ISEDIF { get; set; }

		public string ES_NPIDOCUMENTVIEW { get; set; }

		public string ES_SCHEMATICID { get; set; }

		public uint? ES_USEPRODUCTIONCLIENTBOXMODE { get; set; }

		public DateTime? EXPIRATIONDATE { get; set; }

		public DateTime? EXPIRATIONDATEGMT { get; set; }

		public uint? INPROCESS { get; set; }

		public string LOSSREASONSID { get; set; }

		public string MFGORDERDESC { get; set; }

		public string MFGORDERNOTES { get; set; }

		public string OPERATIONID { get; set; }

		public string OPERATIONNAME { get; set; }

		public string PRODUCTID { get; set; }

		public string PRODUCTNAME { get; set; }

		public string PRODUCTNOTES { get; set; }

		public string PRODUCTREVISION { get; set; }

		public string RESOURCEGROUPID { get; set; }

		public string RESOURCEGROUPNAME { get; set; }

		public string RESOURCEID { get; set; }

		public string RESOURCENAME { get; set; }

		public decimal? ROUTESTEPDURATIONPERUNIT { get; set; }

		public string ROUTESTEPID { get; set; }

		public string RouteStepName { get; set; }

		public uint? ROUTESTEPRUNRATEOPTION { get; set; }

		public decimal? ROUTESTEPSETUPTIME { get; set; }

		public decimal? ROUTESTEPUNITSPERHOUR { get; set; }

		public string SPECID { get; set; }

		public uint? USEQUEUE { get; set; }

		public string WORKFLOWID { get; set; }

		public string WORKFLOWNAME { get; set; }

		public string WORKFLOWREVISION { get; set; }

		public string WORKFLOWSTEPID { get; set; }

		public string WORKFLOWSTEPNAME { get; set; }

	}

}
