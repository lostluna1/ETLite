using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class PORTALMENUITEM {

		public string PORTALMENUITEMID { get; set; }

		public string APOLLOICON { get; set; }

		public string CAPTION { get; set; }

		public uint? CDOTYPEID { get; set; }

		public uint? CHANGECOUNT { get; set; }

		public string EXPORTIMPORTKEY { get; set; }

		public uint? ISFROZEN { get; set; }

		public string LABELNAME { get; set; }

		public string MENUDEFINITIONID { get; set; }

		public uint? PAGEDISPLAY { get; set; }

		public string PAGEFLOWID { get; set; }

		public string PAGEURL { get; set; }

		public string PARENTID { get; set; }

		public string PORTALTABID { get; set; }

		public uint? PORTALTABOPTION { get; set; }

		public string QUERYSTRING { get; set; }

		public uint? SEQUENCE { get; set; }

		public string SERVICENAME { get; set; }

		public string VIRTUALPAGEID { get; set; }

	}

}
