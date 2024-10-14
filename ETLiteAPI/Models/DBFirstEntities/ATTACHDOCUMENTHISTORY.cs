using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class ATTACHDOCUMENTHISTORY {

		public string ATTACHDOCUMENTHISTORYID { get; set; }

		public uint? ATTACHASROR { get; set; }

		public string ATTACHEDDOCUMENTID { get; set; }

		public string ATTACHEDFILEEXTENSION { get; set; }

		public string ATTACHEDFILENAME { get; set; }

		public uint? ATTACHMENTTYPE { get; set; }

		public uint? CDOTYPEID { get; set; }

		public uint? CHANGECOUNT { get; set; }

		public string COMMENTS { get; set; }

		public DateTime? DOCTRANSACTIONDATE { get; set; }

		public string DOCUMENTDESCRIPTION { get; set; }

		public string DOCUMENTNAME { get; set; }

		public string DOCUMENTREVISION { get; set; }

		public string EXPORTIMPORTKEY { get; set; }

		public string FILEPATH { get; set; }

		public string HISTORYID { get; set; }

		public string HISTORYMAINLINEID { get; set; }

		public uint? INSTANCEISROR { get; set; }

		public string INSTANCENAME { get; set; }

		public string INSTANCEREVISION { get; set; }

		public uint? ISDETACHED { get; set; }

		public string OBJECTINSTANCEID { get; set; }

		public uint? OBJECTTYPE { get; set; }

		public uint? OBJECTTYPEID { get; set; }

		public string TXNID { get; set; }

		public string USERID { get; set; }

		public uint? USEROR { get; set; }

	}

}
