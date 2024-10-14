using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class SHOPFLOORSETTINGS {

		public string SHOPFLOORSETTINGSID { get; set; }

		public uint? CDOTYPEID { get; set; }

		public uint? CHANGECOUNT { get; set; }

		public string CHANGEHISTORYID { get; set; }

		public string DESCRIPTION { get; set; }

		public uint? ES_LASERMARKERFAIL { get; set; }

		public string FILTERTAGS { get; set; }

		public uint? ICONID { get; set; }

		public string ISDEFECTMAPPINGID { get; set; }

		public uint? ISFROZEN { get; set; }

		public string LEVELID { get; set; }

		public string MMAPICONNECTION { get; set; }

		public string NOTES { get; set; }

		public string OWNERID { get; set; }

		public string PRODUCTTYPEID { get; set; }

		public string SHOPFLOORSETTINGSNAME { get; set; }

		public string SRCAPICONNECTION { get; set; }

		public string STARTREASONID { get; set; }

		public string WORKFLOWID { get; set; }

	}

}
