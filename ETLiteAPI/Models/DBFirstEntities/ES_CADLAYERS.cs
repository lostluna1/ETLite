using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class ES_CADLAYERS {

		public string ES_CADLAYERSID { get; set; }

		public string ATTACHMENTHOLDERID { get; set; }

		public uint? AUTHENTICATIONTYPE { get; set; }

		public uint? BROWSEMODE { get; set; }

		public uint? CDOTYPEID { get; set; }

		public uint? CHANGECOUNT { get; set; }

		public string CHANGEHISTORYID { get; set; }

		public string DESCRIPTION { get; set; }

		public string ECO { get; set; }

		public string ES_CADLAYERSBASEID { get; set; }

		public string FILEVERSION { get; set; }

		public string FILTERTAGS { get; set; }

		public uint? ICONID { get; set; }

		public string IDENTIFIER { get; set; }

		public uint? ISATTACHMENT { get; set; }

		public uint? ISFROZEN { get; set; }

		public string NOTES { get; set; }

		public string REVISION { get; set; }

		public string SETUPACCESSID { get; set; }

		public uint? STATUS { get; set; }

		public string VIEWERID { get; set; }

		public string WIPMSGDEFMGRID { get; set; }

		public string XSHARECOLLABSPACEID { get; set; }

		public string XSHARECONTAINERID { get; set; }

		public string XSHARECONTAINERNAME { get; set; }

		public string XSHARECONTAINERTYPE { get; set; }

		public string XSHAREPARENTFOLDER { get; set; }

		public string XSHAREURN { get; set; }

	}

}
