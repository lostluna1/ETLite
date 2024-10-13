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
	public partial class CHANGEPACKAGE {

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)", IsPrimary = true, IsNullable = false)]
		public string CHANGEPACKAGEID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string AUTHORID { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(40 BYTE)")]
		public string AUTHORNAME { get; set; }

		[JsonProperty]
		public uint? CDOTYPEID { get; set; }

		[JsonProperty]
		public uint? CHANGECOUNT { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string COLLABORATORDATAID { get; set; }

		[JsonProperty]
		public uint? CPEXPORTSTATUS { get; set; }

		[JsonProperty]
		public uint? CPIMPORTSTATUS { get; set; }

		[JsonProperty, Column(DbType = "DATE(7)")]
		public DateTime? CREATIONDATE { get; set; }

		[JsonProperty, Column(DbType = "DATE(7)")]
		public DateTime? CREATIONDATEGMT { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string CURRENTSTATUSID { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(255 BYTE)")]
		public string DESCRIPTION { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(30 BYTE)")]
		public string ECOECN { get; set; }

		[JsonProperty]
		public uint? EXPORTCOUNT { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(255 BYTE)")]
		public string EXPORTFOLDERLOCATION { get; set; }

		[JsonProperty, Column(DbType = "DATE(7)")]
		public DateTime? EXPORTREQUESTDATE { get; set; }

		[JsonProperty, Column(DbType = "DATE(7)")]
		public DateTime? EXPORTREQUESTDATEGMT { get; set; }

		[JsonProperty, Column(DbType = "DATE(7)")]
		public DateTime? LASTACTIVITYDATE { get; set; }

		[JsonProperty, Column(DbType = "DATE(7)")]
		public DateTime? LASTACTIVITYDATEGMT { get; set; }

		[JsonProperty, Column(DbType = "DATE(7)")]
		public DateTime? LASTUPDATEDDATE { get; set; }

		[JsonProperty, Column(DbType = "DATE(7)")]
		public DateTime? LASTUPDATEDDATEGMT { get; set; }

		[JsonProperty]
		public uint? LOCKALLMODELINGINSTANCES { get; set; }

		[JsonProperty]
		public uint? LOCKLNSTANCES { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(512 BYTE)")]
		public string MODELINGIMPORTFILE { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(40 BYTE)")]
		public string NAME { get; set; }

		[JsonProperty]
		public uint? NOTIFYOWNERALLSTATECHANGES { get; set; }

		[JsonProperty]
		public uint? NOTIFYOWNERROLEALLSTATECHGS { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string OWNERID { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(40 BYTE)")]
		public string OWNERNAME { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string OWNERROLEID { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(40 BYTE)")]
		public string OWNERROLENAME { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string PACKAGECREATIONTEMPLATEID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string PACKAGETYPEID { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(40 BYTE)")]
		public string PACKAGETYPENAME { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string PRIORITYID { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(40 BYTE)")]
		public string PRIORITYNAME { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string REASONID { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(40 BYTE)")]
		public string REASONNAME { get; set; }

		[JsonProperty, Column(DbType = "DATE(7)")]
		public DateTime? RECOMMENDEDDEPLOYMENTDATE { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(40 BYTE)")]
		public string SOURCESYSTEMNAME { get; set; }

		[JsonProperty]
		public uint? STATUS { get; set; }

	}

}
