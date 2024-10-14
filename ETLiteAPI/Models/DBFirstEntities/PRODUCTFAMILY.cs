using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class PRODUCTFAMILY {

		public string PRODUCTFAMILYID { get; set; }

		public uint? CDOTYPEID { get; set; }

		public uint? CHANGECOUNT { get; set; }

		public string CHANGESTATUSID { get; set; }

		public string CHILDCONTAINERNUMBERINGRULEID { get; set; }

		public string CONTAINERNUMBERINGRULEID { get; set; }

		public decimal? CURRENTCOST { get; set; }

		public string DESCRIPTION { get; set; }

		public string DOCUMENTSETID { get; set; }

		public string ES_CHILDSNRULEID { get; set; }

		public string ES_PARENTSNRULEID { get; set; }

		public uint? ES_SERIALNUMBERCONFIG { get; set; }

		public uint? ES_SERIALNUMBERGENERATION { get; set; }

		public uint? ES_SERIALNUMBERQTY { get; set; }

		public string ES_STDSTARTCHILDLEVELID { get; set; }

		public uint? ES_UNIQUESERIALNUMBERS { get; set; }

		public uint? ES_USECONTAINERNAMEFORSN { get; set; }

		public uint? ES_USEPRODUCTIONCLIENTBOXMODE { get; set; }

		public string FILTERTAGS { get; set; }

		public uint? ICONID { get; set; }

		public string ISDEFAULTINVENTORYLOCATIONID { get; set; }

		public uint? ISFROZEN { get; set; }

		public string ISRECIPEPLANID { get; set; }

		public uint? ISREGISTERCONTAINERS { get; set; }

		public string NOTES { get; set; }

		public decimal? PLANNEDCOST { get; set; }

		public string PRODUCTFAMILYNAME { get; set; }

		public string SAMPLINGPLANID { get; set; }

		public string SETUPACCESSID { get; set; }

		public decimal? STDCOST { get; set; }

		public decimal? STDSTARTCHILDQTY { get; set; }

		public decimal? STDSTARTCHILDQTY2 { get; set; }

		public string STDSTARTCUSTOMERID { get; set; }

		public string STDSTARTFACTORYID { get; set; }

		public string STDSTARTLEVELID { get; set; }

		public string STDSTARTOWNERID { get; set; }

		public string STDSTARTPRIORITYCODEID { get; set; }

		public decimal? STDSTARTQTY { get; set; }

		public decimal? STDSTARTQTY2 { get; set; }

		public string STDSTARTREASONID { get; set; }

		public string STDSTARTUOM2ID { get; set; }

		public string STDSTARTUOMID { get; set; }

		public string TRAININGREQGROUPID { get; set; }

		public string WIPMSGDEFMGRID { get; set; }

		public string WORKFLOWBASEID { get; set; }

		public string WORKFLOWID { get; set; }

	}

}
