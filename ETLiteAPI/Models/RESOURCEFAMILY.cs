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
	public partial class RESOURCEFAMILY {

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)", IsPrimary = true, IsNullable = false)]
		public string RESOURCEFAMILYID { get; set; }

		[JsonProperty, Column(Name = "BIZ_EQUIPDAILYCHECKID", DbType = "CHAR(16 BYTE)")]
		public string BIZEQUIPDAILYCHECKID { get; set; }

		[JsonProperty, Column(Name = "BIZ_EQUIPHEALTHCHECKID", DbType = "CHAR(16 BYTE)")]
		public string BIZEQUIPHEALTHCHECKID { get; set; }

		[JsonProperty, Column(Name = "BIZ_EQUIPMAINTL1ID", DbType = "CHAR(16 BYTE)")]
		public string BIZEQUIPMAINTL1ID { get; set; }

		[JsonProperty, Column(Name = "BIZ_EQUIPMAINTL2ID", DbType = "CHAR(16 BYTE)")]
		public string BIZEQUIPMAINTL2ID { get; set; }

		[JsonProperty, Column(Name = "BIZ_EQUIPMAINTL3ID", DbType = "CHAR(16 BYTE)")]
		public string BIZEQUIPMAINTL3ID { get; set; }

		[JsonProperty, Column(Name = "BIZ_INPROCESSCHECKID", DbType = "CHAR(16 BYTE)")]
		public string BIZINPROCESSCHECKID { get; set; }

		[JsonProperty]
		public uint? CARRIERPOSITIONALMETHOD { get; set; }

		[JsonProperty]
		public uint? CARRIERXPOSITIONS { get; set; }

		[JsonProperty]
		public uint? CARRIERYPOSITIONS { get; set; }

		[JsonProperty]
		public uint? CARRIERZPOSITIONS { get; set; }

		[JsonProperty]
		public uint? CDOTYPEID { get; set; }

		[JsonProperty]
		public uint? CHANGECOUNT { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string CHANGEHISTORYID { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(255 BYTE)")]
		public string DESCRIPTION { get; set; }

		[JsonProperty]
		public uint? ENABLECARRIERPOSITIONS { get; set; }

		[JsonProperty, Column(DbType = "CLOB")]
		public string FILTERTAGS { get; set; }

		[JsonProperty]
		public uint? ICONID { get; set; }

		[JsonProperty]
		public uint? ISFROZEN { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string ISMFGORDERID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string ISOEESETTINGSID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string ISPRINTQUEUEID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string ISPRODUCTID { get; set; }

		[JsonProperty]
		public uint? ISREUSETRACKINGCONTAINER { get; set; }

		[JsonProperty]
		public uint? ISSINGLEMFGORDER { get; set; }

		[JsonProperty]
		public uint? ISSINGLEPRODUCT { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string ISTRAININGREQGROUPID { get; set; }

		[JsonProperty]
		public uint? ISUSEPOSITION { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string ISVENDORID { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(30 BYTE)")]
		public string ISVENDORMODEL { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(30 BYTE)")]
		public string ISVENDORSERIALNUMBER { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string JOBNOTIFICATIONEMAILGROUPID { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(2000 BYTE)")]
		public string NOTES { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(40 BYTE)")]
		public string OBJECTCATEGORY { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(40 BYTE)")]
		public string OBJECTTYPE { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(40 BYTE)")]
		public string RESOURCEFAMILYNAME { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string RESOURCESTATUSMODELID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string SETUPACCESSID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string UIPREFERENCEID { get; set; }

	}

}
