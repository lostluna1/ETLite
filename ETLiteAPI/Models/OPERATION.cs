using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models {

	[JsonObject(MemberSerialization.OptIn), Table(DisableSyncStructure = true)]
	public partial class OPERATION {

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)", IsPrimary = true, IsNullable = false)]
		public string OPERATIONID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string ACTIONSMENUID { get; set; }

		[JsonProperty, Column(DbType = "NUMBER(22)")]
		public decimal? AUTOADJUSTLIMIT { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string AUTOADJUSTREASONID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string BONUSREASONSID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string BUYREASONSID { get; set; }

		[JsonProperty]
		public uint? CDOTYPEID { get; set; }

		[JsonProperty]
		public uint? CHANGECOUNT { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string CHANGESTATUSID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string COMPONENTDEFECTREASONSID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string CONTAINERDEFECTREASONSID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string DEFAULTROLLUPREASONID { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(255 BYTE)")]
		public string DESCRIPTION { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string DISPATCHRULEID { get; set; }

		[JsonProperty, Column(Name = "ES_DISPLAYOPTIONSID", DbType = "CHAR(16 BYTE)")]
		public string ESDISPLAYOPTIONSID { get; set; }

		[JsonProperty, Column(Name = "ES_ISDEFECTREASONGROUPID", DbType = "CHAR(16 BYTE)")]
		public string ESISDEFECTREASONGROUPID { get; set; }

		[JsonProperty, Column(Name = "ES_NPIDOCUMENTVIEW", DbType = "VARCHAR2(30 BYTE)")]
		public string ESNPIDOCUMENTVIEW { get; set; }

		[JsonProperty, Column(DbType = "CLOB")]
		public string FILTERTAGS { get; set; }

		[JsonProperty]
		public uint? ICONID { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(512 BYTE)")]
		public string IMAGE { get; set; }

		[JsonProperty]
		public uint? INTRANSIT { get; set; }

		[JsonProperty]
		public uint? INVENTORYPOINT { get; set; }

		[JsonProperty]
		public uint? ISFROZEN { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string LOCALREWORKREASONSID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string LOSSREASONSID { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(2000 BYTE)")]
		public string NOTES { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(40 BYTE)")]
		public string OPERATIONNAME { get; set; }

		[JsonProperty]
		public uint? OUTSIDESERVICEPOINT { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string PRINTQUEUEID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string QTYADJUSTREASONID { get; set; }

		[JsonProperty]
		public uint? REJECTINCOMINGNCCONTAINER { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string REWORKREASONSID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string SCHEDULINGDETAILID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string SELLREASONSID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string SETUPACCESSID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string SHIPMENTDESTINATIONSID { get; set; }

		[JsonProperty]
		public uint? SUMMARYTHRUPUT { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string THRUPUTREPORTINGLEVELID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string TRAININGREQGROUPID { get; set; }

		[JsonProperty]
		public uint? USEQUEUE { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string WIPMSGDEFMGRID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string WORKCENTERID { get; set; }

	}

}
