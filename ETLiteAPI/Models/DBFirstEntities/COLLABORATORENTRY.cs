using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class COLLABORATORENTRY {

		public string COLLABORATORENTRYID { get; set; }

		public string ASSIGNEDCOLLABORATORID { get; set; }

		public DateTime? ASSIGNEDDATEGMT { get; set; }

		public uint? CDOTYPEID { get; set; }

		public uint? CHANGECOUNT { get; set; }

		public string COLLABORATORCOMMENTS { get; set; }

		public string COLLABORATORENTRYNAME { get; set; }

		public string COLLABORATORID { get; set; }

		public DateTime? COMPLETEBYGMT { get; set; }

		public string COMPLETEDBYID { get; set; }

		public DateTime? COMPLETIONDATEGMT { get; set; }

		public string DELEGATIONTASKID { get; set; }

		public decimal? DURATION { get; set; }

		public decimal? DURATIONUOM { get; set; }

		public string PARENTID { get; set; }

		public string ROLEID { get; set; }

		public uint? SHEETLEVEL { get; set; }

		public string SPECIALINSTRUCTIONS { get; set; }

		public uint? STATUS { get; set; }

		public uint? SUBSTITUTEOPTION { get; set; }

	}

}
