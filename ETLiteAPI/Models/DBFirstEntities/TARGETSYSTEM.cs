using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class TARGETSYSTEM {

		public string TARGETSYSTEMID { get; set; }

		public string ADDOMAIN { get; set; }

		public string ADMINISTRATOR { get; set; }

		public string CAMSTARVERSION { get; set; }

		public uint? CDOTYPEID { get; set; }

		public uint? CHANGECOUNT { get; set; }

		public string CHANGEHISTORYID { get; set; }

		public uint? DELIVERYOPTION { get; set; }

		public string DESCRIPTION { get; set; }

		public string FILTERTAGS { get; set; }

		public string FOLDERLOCATION { get; set; }

		public uint? ICONID { get; set; }

		public string IPADDRESS { get; set; }

		public uint? ISFROZEN { get; set; }

		public uint? ISNOTACAMSTARSERVER { get; set; }

		public uint? ISSOURCESYSTEM { get; set; }

		public string LOCATION { get; set; }

		public string MDBVERSION { get; set; }

		public string NOTES { get; set; }

		public string PASSWORD { get; set; }

		public uint? PORT { get; set; }

		public string PROCESSINGFOLDER { get; set; }

		public string SERVERTYPE { get; set; }

		public string TARGETSYSTEMNAME { get; set; }

		public string USERNAME { get; set; }

	}

}
