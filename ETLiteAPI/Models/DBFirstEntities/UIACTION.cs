using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class UIACTION {

		public string UIACTIONID { get; set; }

		public string ACTIONCATEGORYID { get; set; }

		public uint? BUTTONPOSITION { get; set; }

		public string BUTTONSLAYOUTID { get; set; }

		public uint? CDOTYPEID { get; set; }

		public uint? CHANGECOUNT { get; set; }

		public uint? CLEARVALUES { get; set; }

		public uint? CLOSEBUTTONONLY { get; set; }

		public string CONDITIONHANDLER { get; set; }

		public string CUSTOMMETHODHANDLER { get; set; }

		public uint? DENYDATACONTRACT { get; set; }

		public string DESCRIPTION { get; set; }

		public string DISABLECONDITION { get; set; }

		public uint? DISPLAYMODE { get; set; }

		public uint? ESIGREQUIRED { get; set; }

		public uint? EXECUTEONSUBMIT { get; set; }

		public string EXPORTIMPORTKEY { get; set; }

		public uint? FORCEREDIRECT { get; set; }

		public string FRAMELOCATIONID { get; set; }

		public string HIDDENCONDITION { get; set; }

		public string HORIZONTALSHIFTID { get; set; }

		public string INITCONTRACTHANDLER { get; set; }

		public uint? ISDISABLED { get; set; }

		public uint? ISFROZEN { get; set; }

		public uint? ISHIDDEN { get; set; }

		public uint? ISPRIMARY { get; set; }

		public uint? ISRETURN { get; set; }

		public string LABELNAME { get; set; }

		public string LABELTEXT { get; set; }

		public uint? LOCATION { get; set; }

		public string MAPITEM { get; set; }

		public string PARAMETERS { get; set; }

		public string PARENTID { get; set; }

		public string PERMISSIONSID { get; set; }

		public string PORTALTABID { get; set; }

		public uint? PORTALTABOPTION { get; set; }

		public string QUERYSTRINGPARAMETERSID { get; set; }

		public uint? RELOADVALUES { get; set; }

		public uint? SEQUENCE { get; set; }

		public string SERVICENAME { get; set; }

		public uint? SHOWBUTTONS { get; set; }

		public uint? SIDEBARCOLLECTIBLE { get; set; }

		public string SIDEBARCSS { get; set; }

		public uint? SPCENABLED { get; set; }

		public string UIACTIONNAME { get; set; }

		public uint? UIINDEX { get; set; }

		public string UIPAGEFLOWID { get; set; }

		public string UIVIRTUALPAGEID { get; set; }

		public string URL { get; set; }

		public uint? WIPMESSAGESREQUIRED { get; set; }

	}

}
