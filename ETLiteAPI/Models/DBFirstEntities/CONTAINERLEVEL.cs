using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class CONTAINERLEVEL {

		public string CONTAINERLEVELID { get; set; }

		public uint? ALLOWMOVE { get; set; }

		public uint? CDOTYPEID { get; set; }

		public uint? CHANGECOUNT { get; set; }

		public string CHANGEHISTORYID { get; set; }

		public string CHILDCONTAINERNUMBERINGRULEID { get; set; }

		public string CONTAINERLEVELNAME { get; set; }

		public string CONTAINERNUMBERINGRULEID { get; set; }

		public string DESCRIPTION { get; set; }

		public string ES_CHILDSNRULEID { get; set; }

		public uint? ES_LEVELTYPE { get; set; }

		public string ES_PARENTSNRULEID { get; set; }

		public string FILTERTAGS { get; set; }

		public uint? ICONID { get; set; }

		public uint? ISFROZEN { get; set; }

		public uint? ISNAMEUNIQUE { get; set; }

		public string NOTES { get; set; }

		public string SETUPACCESSID { get; set; }

		public string UIPREFERENCEID { get; set; }

		public string WIPMSGCONFIGID { get; set; }

		public string WIPMSGDEFMGRID { get; set; }

	}

}
