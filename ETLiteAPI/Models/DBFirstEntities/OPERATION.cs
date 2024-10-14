using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class OPERATION {

		public string OPERATIONID { get; set; }

		public string ACTIONSMENUID { get; set; }

		public decimal? AUTOADJUSTLIMIT { get; set; }

		public string AUTOADJUSTREASONID { get; set; }

		public string BONUSREASONSID { get; set; }

		public string BUYREASONSID { get; set; }

		public uint? CDOTYPEID { get; set; }

		public uint? CHANGECOUNT { get; set; }

		public string CHANGESTATUSID { get; set; }

		public string COMPONENTDEFECTREASONSID { get; set; }

		public string CONTAINERDEFECTREASONSID { get; set; }

		public string DEFAULTROLLUPREASONID { get; set; }

		public string DESCRIPTION { get; set; }

		public string DISPATCHRULEID { get; set; }

		public string ES_DISPLAYOPTIONSID { get; set; }

		public string ES_ISDEFECTREASONGROUPID { get; set; }

		public string ES_NPIDOCUMENTVIEW { get; set; }

		public string FILTERTAGS { get; set; }

		public uint? ICONID { get; set; }

		public string IMAGE { get; set; }

		public uint? INTRANSIT { get; set; }

		public uint? INVENTORYPOINT { get; set; }

		public uint? ISFROZEN { get; set; }

		public string LOCALREWORKREASONSID { get; set; }

		public string LOSSREASONSID { get; set; }

		public string NOTES { get; set; }

		public string OPERATIONNAME { get; set; }

		public uint? OUTSIDESERVICEPOINT { get; set; }

		public string PRINTQUEUEID { get; set; }

		public string QTYADJUSTREASONID { get; set; }

		public uint? REJECTINCOMINGNCCONTAINER { get; set; }

		public string REWORKREASONSID { get; set; }

		public string SCHEDULINGDETAILID { get; set; }

		public string SELLREASONSID { get; set; }

		public string SETUPACCESSID { get; set; }

		public string SHIPMENTDESTINATIONSID { get; set; }

		public uint? SUMMARYTHRUPUT { get; set; }

		public string THRUPUTREPORTINGLEVELID { get; set; }

		public string TRAININGREQGROUPID { get; set; }

		public uint? USEQUEUE { get; set; }

		public string WIPMSGDEFMGRID { get; set; }

		public string WORKCENTERID { get; set; }

	}

}
