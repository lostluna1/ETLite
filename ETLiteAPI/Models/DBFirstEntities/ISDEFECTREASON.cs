using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class ISDEFECTREASON {

		public string ISDEFECTREASONID { get; set; }

		public uint? ASSOCIATEDPACKAGES { get; set; }

		public uint? CDOTYPEID { get; set; }

		public uint? CHANGECOUNT { get; set; }

		public string CHANGEHISTORYID { get; set; }

		public string DESCRIPTION { get; set; }

		public uint? ES_BOARD { get; set; }

		public uint? ES_MODULE { get; set; }

		public uint? ES_MOUNTINGTECHNOLOGY { get; set; }

		public uint? ES_PART { get; set; }

		public uint? ES_PIN { get; set; }

		public uint? ES_PINSHORT { get; set; }

		public uint? ES_SEGMENT { get; set; }

		public uint? ES_SHORT { get; set; }

		public uint? ES_TRACE { get; set; }

		public uint? ES_VIA { get; set; }

		public string FILTERTAGS { get; set; }

		public uint? ICONID { get; set; }

		public uint? INSTANCELOCKED { get; set; }

		public string ISDEFECTREASONNAME { get; set; }

		public string ISEMAILDISTRIBUTIONID { get; set; }

		public string ISEMAILMESSAGEID { get; set; }

		public uint? ISFROZEN { get; set; }

		public uint? ISINITIALSTATUS { get; set; }

		public string ISREPAIRACTIONGROUPID { get; set; }

		public string ISSEVERITYID { get; set; }

		public string NOTES { get; set; }

		public string SETUPACCESS { get; set; }

	}

}
