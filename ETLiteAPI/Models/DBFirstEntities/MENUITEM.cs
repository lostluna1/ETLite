using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class MENUITEM {

		public string MENUITEMID { get; set; }

		public uint? ALLOWMULTIPLE { get; set; }

		public string CAPTION { get; set; }

		public uint? CATEGORYID { get; set; }

		public uint? CDOTYPEID { get; set; }

		public uint? CHANGECOUNT { get; set; }

		public string DESCRIPTION { get; set; }

		public string EXPORTIMPORTKEY { get; set; }

		public uint? HELPCONTEXTID { get; set; }

		public string HELPFILENAME { get; set; }

		public string HELPFILEPATH { get; set; }

		public string IMAGEFILENAME { get; set; }

		public string IMAGEFILEPATH { get; set; }

		public uint? ISFROZEN { get; set; }

		public string MAINLICENSEKEY { get; set; }

		public string MAINPROGID { get; set; }

		public string MAINQUERY { get; set; }

		public string MENUDEFINITIONID { get; set; }

		public uint? MENUITEMTYPE { get; set; }

		public string PARENTID { get; set; }

		public string PORTALTABID { get; set; }

		public uint? PORTALTABOPTION { get; set; }

		public uint? REFRESHONSELECTION { get; set; }

		public uint? SEQUENCE { get; set; }

		public uint? SERVICETYPEDEFID { get; set; }

		public string SHORTCUT { get; set; }

		public string SUBQUERY { get; set; }

		public string URL { get; set; }

		public string UTILITYLICENSEKEY { get; set; }

		public string UTILITYPROGID { get; set; }

		public string WORKINGSECTIONURL { get; set; }

	}

}
