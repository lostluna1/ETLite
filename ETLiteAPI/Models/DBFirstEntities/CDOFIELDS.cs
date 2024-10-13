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
	public partial class CDOFIELDS {

		[JsonProperty]
		public bool? ALLOWCLIENTTOREAD { get; set; }

		[JsonProperty]
		public bool? ALLOWCLIENTTOUPDATE { get; set; }

		[JsonProperty]
		public bool? ALLOWROR { get; set; }

		[JsonProperty]
		public bool? ALLOWSUBTYPES { get; set; }

		[JsonProperty]
		public uint? CDODEFID { get; set; }

		[JsonProperty]
		public uint? CDOFIELDUSAGEID { get; set; }

		[JsonProperty]
		public uint? CPPDATATYPEID { get; set; }

		[JsonProperty]
		public bool? CREATEONINITIALIZE { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(255 BYTE)")]
		public string CURRENTVALUEEXPRESSION { get; set; }

		[JsonProperty]
		public uint? DBCOLUMNID { get; set; }

		[JsonProperty]
		public uint? DBTABLEID { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(255 BYTE)")]
		public string DEFAULTVALUE { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(255 BYTE)")]
		public string DEFAULTVALUEEXPRESSION { get; set; }

		[JsonProperty]
		public bool? EXPOSETOUI { get; set; }

		[JsonProperty]
		public uint? FIELDDEFID { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(4000 BYTE)")]
		public string FIELDDESCRIPTION { get; set; }

		[JsonProperty]
		public uint? FIELDID { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(32 BYTE)")]
		public string FIELDNAME { get; set; }

		[JsonProperty]
		public uint? INHERITEDID { get; set; }

		[JsonProperty]
		public uint? INHERITMASK { get; set; }

		[JsonProperty]
		public bool? ISDERIVEDUNIQUE { get; set; }

		[JsonProperty]
		public bool? ISLISTTYPE { get; set; }

		[JsonProperty]
		public bool? ISNONPERSISTENT { get; set; }

		[JsonProperty]
		public bool? ISRESOLVEONREQUEST { get; set; }

		[JsonProperty]
		public bool? ISTYPEUNIQUE { get; set; }

		[JsonProperty]
		public uint? LABELID { get; set; }

		[JsonProperty]
		public uint? LISTFIELDPARENT { get; set; }

		[JsonProperty]
		public uint? LISTFIELDREFERENCED { get; set; }

		[JsonProperty]
		public uint? LISTFIELDSEQUENCE { get; set; }

		[JsonProperty]
		public uint? MAXITEMCOUNT { get; set; }

		[JsonProperty]
		public uint? MINITEMCOUNT { get; set; }

		[JsonProperty]
		public bool? NEGATE { get; set; }

		[JsonProperty]
		public uint? OWNERSHIP { get; set; }

		[JsonProperty]
		public bool? PROCESSTEXTVARIABLE { get; set; }

		[JsonProperty]
		public uint? REQUIRED { get; set; }

		[JsonProperty]
		public bool? RETAINVALUE { get; set; }

		[JsonProperty]
		public bool? REVERSE { get; set; }

		[JsonProperty]
		public uint? SELVALMODE { get; set; }

		[JsonProperty]
		public uint? SELVALQUERYDEFID { get; set; }

		[JsonProperty]
		public uint? SEQUENCENUMBER { get; set; }

		[JsonProperty]
		public uint? SERIALIZATION { get; set; }

		[JsonProperty]
		public uint? VISIBILITY { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(5 BYTE)")]
		public string WORKSPACECODE { get; set; }

		[JsonProperty]
		public bool? WRITECURRENTVALUE { get; set; }

	}

}
