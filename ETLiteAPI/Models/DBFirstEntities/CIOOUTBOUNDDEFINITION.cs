using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class CIOOUTBOUNDDEFINITION {

		public string CIOOUTBOUNDDEFINITIONID { get; set; }

		public uint? CDOTYPEID { get; set; }

		public uint? CHANGECOUNT { get; set; }

		public string CHANNELADAPTEREXPRESSION { get; set; }

		public string CHANNELADAPTERNAME { get; set; }

		public string CIOACCEPT { get; set; }

		public string CIOCAMSTARCONNECTIONID { get; set; }

		public string CIOCHANNELADAPTERID { get; set; }

		public string CIOCONDITIONEXPRESSION { get; set; }

		public string CIOCONDITIONQUERYID { get; set; }

		public string CIOCONTENTTYPE { get; set; }

		public string CIOLISTEXPRESSION { get; set; }

		public string CIOLISTTEMPLATEDEFID { get; set; }

		public string CIOMESSAGECHANNELID { get; set; }

		public string CIOMESSAGETYPEID { get; set; }

		public string CIOOUTBOUNDMSGDEFID { get; set; }

		public uint? CIORESPONSERESULTOBJECT { get; set; }

		public uint? CIOSYNCHTIMING { get; set; }

		public string CIOTEMPLATEID { get; set; }

		public string ENDPOINTURL { get; set; }

		public string EXPORTIMPORTKEY { get; set; }

		public uint? ISENABLED { get; set; }

		public uint? ISFROZEN { get; set; }

		public uint? ISRESPONSE { get; set; }

		public uint? ISSYNCHRONOUS { get; set; }

		public string MESSAGETYPENAME { get; set; }

		public string USERQUERYID { get; set; }

	}

}
