using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models {

	[JsonObject(MemberSerialization.OptIn), Table(Name = "A_FEEDERPLANDETAILS", DisableSyncStructure = true)]
	public partial class AFEEDERPLANDETAILS {

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)", IsPrimary = true, IsNullable = false)]
		public string FEEDERPLANDETAILSID { get; set; }

		[JsonProperty, Column(Name = "BIZ_MAINMATERIALID", DbType = "CHAR(16 BYTE)")]
		public string BIZMAINMATERIALID { get; set; }

		[JsonProperty, Column(Name = "BIZ_MOUNTID", DbType = "VARCHAR2(255 BYTE)")]
		public string BIZMOUNTID { get; set; }

		[JsonProperty, Column(Name = "BIZ_POINTMOUNTQTY")]
		public uint? BIZPOINTMOUNTQTY { get; set; }

		[JsonProperty, Column(Name = "BIZ_SMTMACHINELOCID", DbType = "CHAR(16 BYTE)")]
		public string BIZSMTMACHINELOCID { get; set; }

		[JsonProperty, Column(Name = "BIZ_SUBMATERIALDES", DbType = "VARCHAR2(255 BYTE)")]
		public string BIZSUBMATERIALDES { get; set; }

		[JsonProperty, Column(Name = "BIZ_SUBMATERIALGRP", DbType = "VARCHAR2(4000 BYTE)")]
		public string BIZSUBMATERIALGRP { get; set; }

		[JsonProperty, Column(Name = "BIZ_SUBMATERIALTYPE", DbType = "VARCHAR2(255 BYTE)")]
		public string BIZSUBMATERIALTYPE { get; set; }

		[JsonProperty]
		public uint? CDOTYPEID { get; set; }

		[JsonProperty]
		public uint? CHANGECOUNT { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(36 BYTE)")]
		public string EXPORTIMPORTKEY { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string FEEDERFAMILYID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string FEEDERGROUPID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string FEEDERID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string FEEDERPLANID { get; set; }

		[JsonProperty]
		public uint? ISFROZEN { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string PRODUCTBASEID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string PRODUCTID { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(1000 BYTE)")]
		public string REMARK { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string SLOTID { get; set; }

	}

}
