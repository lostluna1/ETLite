using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class RECIPELIST {

		public string RECIPELISTID { get; set; }

		public string CARRIERSID { get; set; }

		public uint? CDOTYPEID { get; set; }

		public uint? CHANGECOUNT { get; set; }

		public string CHANGEHISTORYID { get; set; }

		public string DESCRIPTION { get; set; }

		public string ECO { get; set; }

		public uint? EXECUTIONMODE { get; set; }

		public string FILTERTAGS { get; set; }

		public uint? ICONID { get; set; }

		public string INSTRUCTION { get; set; }

		public uint? ISFROZEN { get; set; }

		public string ISIMAGEID { get; set; }

		public string NOTES { get; set; }

		public string PREREQUISITETASKLISTID { get; set; }

		public string RECIPELISTBASEID { get; set; }

		public string REPORTINSTRUCTION { get; set; }

		public string REVISION { get; set; }

		public string SCALESID { get; set; }

		public string SETUPACCESSID { get; set; }

		public uint? STATUS { get; set; }

		public string TARGETCONTAINERLEVELID { get; set; }

		public string TARGETCONTAINERPLANNEDQTY { get; set; }

		public string TARGETCONTAINERPRODUCTBASEID { get; set; }

		public string TARGETCONTAINERPRODUCTID { get; set; }

		public string TARGETCONTAINERUOMID { get; set; }

		public string WIPMSGDEFMGRID { get; set; }

		public string WORKSTATIONGROUPID { get; set; }

		public string WORKSTATIONID { get; set; }

	}

}
