using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class CDOFIELDS {

		public bool? ALLOWCLIENTTOREAD { get; set; }

		public bool? ALLOWCLIENTTOUPDATE { get; set; }

		public bool? ALLOWROR { get; set; }

		public bool? ALLOWSUBTYPES { get; set; }

		public uint? CDODEFID { get; set; }

		public uint? CDOFIELDUSAGEID { get; set; }

		public uint? CPPDATATYPEID { get; set; }

		public bool? CREATEONINITIALIZE { get; set; }

		public string CURRENTVALUEEXPRESSION { get; set; }

		public uint? DBCOLUMNID { get; set; }

		public uint? DBTABLEID { get; set; }

		public string DEFAULTVALUE { get; set; }

		public string DEFAULTVALUEEXPRESSION { get; set; }

		public bool? EXPOSETOUI { get; set; }

		public uint? FIELDDEFID { get; set; }

		public string FIELDDESCRIPTION { get; set; }

		public uint? FIELDID { get; set; }

		public string FIELDNAME { get; set; }

		public uint? INHERITEDID { get; set; }

		public uint? INHERITMASK { get; set; }

		public bool? ISDERIVEDUNIQUE { get; set; }

		public bool? ISLISTTYPE { get; set; }

		public bool? ISNONPERSISTENT { get; set; }

		public bool? ISRESOLVEONREQUEST { get; set; }

		public bool? ISTYPEUNIQUE { get; set; }

		public uint? LABELID { get; set; }

		public uint? LISTFIELDPARENT { get; set; }

		public uint? LISTFIELDREFERENCED { get; set; }

		public uint? LISTFIELDSEQUENCE { get; set; }

		public uint? MAXITEMCOUNT { get; set; }

		public uint? MINITEMCOUNT { get; set; }

		public bool? NEGATE { get; set; }

		public uint? OWNERSHIP { get; set; }

		public bool? PROCESSTEXTVARIABLE { get; set; }

		public uint? REQUIRED { get; set; }

		public bool? RETAINVALUE { get; set; }

		public bool? REVERSE { get; set; }

		public uint? SELVALMODE { get; set; }

		public uint? SELVALQUERYDEFID { get; set; }

		public uint? SEQUENCENUMBER { get; set; }

		public uint? SERIALIZATION { get; set; }

		public uint? VISIBILITY { get; set; }

		public string WORKSPACECODE { get; set; }

		public bool? WRITECURRENTVALUE { get; set; }

	}

}
