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
	public partial class EXPORTIMPORTHEADER {

		[JsonProperty, Column(IsPrimary = true)]
		public uint EXPORTIMPORTHEADERID { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(2000 BYTE)")]
		public string COMPLETIONMESSAGE { get; set; }

		[JsonProperty]
		public uint? DOCCONTENTSID { get; set; }

		[JsonProperty, Column(DbType = "DATE(7)")]
		public DateTime? EXPORTDATE { get; set; }

		[JsonProperty, Column(DbType = "DATE(7)")]
		public DateTime? EXPORTDATEGMT { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(30 BYTE)")]
		public string EXPORTDBID { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(30 BYTE)")]
		public string EXPORTFACTORYNAME { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(256 BYTE)")]
		public string EXPORTIMPORTFILENAME { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(256 BYTE)")]
		public string EXPORTIMPORTNAME { get; set; }

		[JsonProperty]
		public uint? EXPORTIMPORTTYPE { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string EXPORTIMPORTUSERID { get; set; }

		[JsonProperty]
		public uint? EXPORTIMPORTUSERUTCOFFSET { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(30 BYTE)")]
		public string EXPORTSITENAME { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(255 BYTE)")]
		public string EXPORTUSERDOMAINNAME { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(255 BYTE)")]
		public string EXPORTUSERFULLNAME { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(30 BYTE)")]
		public string EXPORTUSERNAME { get; set; }

		[JsonProperty]
		public uint? GENERATEEXPORTFILE { get; set; }

		[JsonProperty, Column(DbType = "DATE(7)")]
		public DateTime? LASTUPDATEDATE { get; set; }

		[JsonProperty, Column(DbType = "DATE(7)")]
		public DateTime? LASTUPDATEDATEGMT { get; set; }

		[JsonProperty]
		public uint? PROCESSEDOBJECTCOUNT { get; set; }

		[JsonProperty, Column(DbType = "DATE(7)")]
		public DateTime? PROCESSSTARTDATE { get; set; }

		[JsonProperty, Column(DbType = "DATE(7)")]
		public DateTime? PROCESSSTARTDATEGMT { get; set; }

		[JsonProperty]
		public uint? STATUS { get; set; }

		[JsonProperty]
		public uint? TARGETSYSTEMCOUNT { get; set; }

		[JsonProperty]
		public uint? TOTALOBJECTCOUNT { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(30 BYTE)")]
		public string TRACKABLEOBJECTNAME { get; set; }

	}

}
