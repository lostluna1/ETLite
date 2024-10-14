using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class RESOURCEFAMILY {

		public string RESOURCEFAMILYID { get; set; }

		public string BIZ_EQUIPDAILYCHECKID { get; set; }

		public string BIZ_EQUIPHEALTHCHECKID { get; set; }

		public string BIZ_EQUIPMAINTL1ID { get; set; }

		public string BIZ_EQUIPMAINTL2ID { get; set; }

		public string BIZ_EQUIPMAINTL3ID { get; set; }

		public string BIZ_INPROCESSCHECKID { get; set; }

		public uint? CARRIERPOSITIONALMETHOD { get; set; }

		public uint? CARRIERXPOSITIONS { get; set; }

		public uint? CARRIERYPOSITIONS { get; set; }

		public uint? CARRIERZPOSITIONS { get; set; }

		public uint? CDOTYPEID { get; set; }

		public uint? CHANGECOUNT { get; set; }

		public string CHANGEHISTORYID { get; set; }

		public string DESCRIPTION { get; set; }

		public uint? ENABLECARRIERPOSITIONS { get; set; }

		public string FILTERTAGS { get; set; }

		public uint? ICONID { get; set; }

		public uint? ISFROZEN { get; set; }

		public string ISMFGORDERID { get; set; }

		public string ISOEESETTINGSID { get; set; }

		public string ISPRINTQUEUEID { get; set; }

		public string ISPRODUCTID { get; set; }

		public uint? ISREUSETRACKINGCONTAINER { get; set; }

		public uint? ISSINGLEMFGORDER { get; set; }

		public uint? ISSINGLEPRODUCT { get; set; }

		public string ISTRAININGREQGROUPID { get; set; }

		public uint? ISUSEPOSITION { get; set; }

		public string ISVENDORID { get; set; }

		public string ISVENDORMODEL { get; set; }

		public string ISVENDORSERIALNUMBER { get; set; }

		public string JOBNOTIFICATIONEMAILGROUPID { get; set; }

		public string NOTES { get; set; }

		public string OBJECTCATEGORY { get; set; }

		public string OBJECTTYPE { get; set; }

		public string RESOURCEFAMILYNAME { get; set; }

		public string RESOURCESTATUSMODELID { get; set; }

		public string SETUPACCESSID { get; set; }

		public string UIPREFERENCEID { get; set; }

	}

}
