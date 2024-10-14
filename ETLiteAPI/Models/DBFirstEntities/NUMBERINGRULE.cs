using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class NUMBERINGRULE {

		public string NUMBERINGRULEID { get; set; }

		public uint? CDOTYPEID { get; set; }

		public uint? CHANGECOUNT { get; set; }

		public string CHANGEHISTORYID { get; set; }

		public string DESCRIPTION { get; set; }

		public uint? EXCLUDEDVALUES { get; set; }

		public string FILTERTAGS { get; set; }

		public uint? ICONID { get; set; }

		public uint? ISFROZEN { get; set; }

		public uint? ISROLLOVER { get; set; }

		public uint? MAXIMUMVALUE { get; set; }

		public string NOTES { get; set; }

		public string NUMBERINGRULENAME { get; set; }

		public uint? NUMBERINGRULEOPTIONS { get; set; }

		public uint? NUMBERINGRULETYPE { get; set; }

		public string PREFIX { get; set; }

		public uint? SEQUENCELENGTH { get; set; }

		public string SETUPACCESSID { get; set; }

		public string SUFFIX { get; set; }

		public uint? USEALPHANUMBERICVALUE { get; set; }

		public uint? USEHEXADECIMALVALUE { get; set; }

		public uint? USEPREFIXBASED { get; set; }

	}

}
