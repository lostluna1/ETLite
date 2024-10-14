using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class MASTERRECIPE {

		public string MASTERRECIPEID { get; set; }

		public uint? CDOTYPEID { get; set; }

		public uint? CHANGECOUNT { get; set; }

		public string CHANGEHISTORYID { get; set; }

		public string DESCRIPTION { get; set; }

		public uint? DISPLAYMODE { get; set; }

		public string ECO { get; set; }

		public uint? EXECUTIONMODE { get; set; }

		public string FILTERTAGS { get; set; }

		public uint? ICONID { get; set; }

		public uint? ISFROZEN { get; set; }

		public string MASTERRECIPEBASEID { get; set; }

		public string NOTES { get; set; }

		public string PRINTERLABELDEFINITIONID { get; set; }

		public string RECIPEPRODUCTBASEID { get; set; }

		public string RECIPEPRODUCTID { get; set; }

		public string RECIPEQTYLOWERLIMIT { get; set; }

		public string RECIPEQTYNOMINAL { get; set; }

		public string RECIPEQTYUPPERLIMIT { get; set; }

		public string RECIPEUOMID { get; set; }

		public string REVISION { get; set; }

		public string SETUPACCESSID { get; set; }

		public uint? STATUS { get; set; }

		public string WIPMSGDEFMGRID { get; set; }

		public string WORKFLOWBASEID { get; set; }

		public string WORKFLOWID { get; set; }

	}

}
