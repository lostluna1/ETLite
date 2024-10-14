using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class ISAUTOSTARTSETTINGS {

		public string ISAUTOSTARTSETTINGSID { get; set; }

		public uint? CDOTYPEID { get; set; }

		public uint? CHANGECOUNT { get; set; }

		public string CHANGEHISTORYID { get; set; }

		public string DESCRIPTION { get; set; }

		public uint? ES_LASERMARKERFAIL { get; set; }

		public string FILTERTAGS { get; set; }

		public uint? ICONID { get; set; }

		public string ISAUTOSTARTSETTINGSNAME { get; set; }

		public string ISDEFECTMAPPINGID { get; set; }

		public uint? ISFROZEN { get; set; }

		public string ISLEVELID { get; set; }

		public string ISMMAPICONNECTION { get; set; }

		public string ISOWNERID { get; set; }

		public string ISPRODUCTTYPEID { get; set; }

		public string ISSTARTREASONID { get; set; }

		public string ISWORKFLOWID { get; set; }

		public string NOTES { get; set; }

		public string PRODUCTTYPEID { get; set; }

		public string SETUPACCESSID { get; set; }

	}

}
