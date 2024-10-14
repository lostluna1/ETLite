using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class ATTACHEDDOCS {

		public string ATTACHEDDOCID { get; set; }

		public uint? CDOTYPEID { get; set; }

		public uint? CHANGECOUNT { get; set; }

		public string DESCRIPTION { get; set; }

		public string DOCATTACHMENTSID { get; set; }

		public uint? DOCCONTENTSID { get; set; }

		public string DOCUMENTNAME { get; set; }

		public string EXPORTIMPORTKEY { get; set; }

		public string FILEEXTENSION { get; set; }

		public string FILENAME { get; set; }

		public uint? ISFROZEN { get; set; }

		public string ORIGINALFILENAME { get; set; }

		public string ORIGINALFILEPATH { get; set; }

		public string VERSION { get; set; }

	}

}
