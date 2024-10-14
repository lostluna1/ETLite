using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class PROCESSTIMER {

		public string PROCESSTIMERID { get; set; }

		public uint? CDOTYPEID { get; set; }

		public uint? CHANGECOUNT { get; set; }

		public string CHANGEHISTORYID { get; set; }

		public string DESCRIPTION { get; set; }

		public string ECO { get; set; }

		public string FILTERTAGS { get; set; }

		public uint? ICONID { get; set; }

		public uint? ISFROZEN { get; set; }

		public decimal? MAXTIME { get; set; }

		public string MAXTIMECOLOR { get; set; }

		public decimal? MAXWARNINGTIME { get; set; }

		public string MAXWARNINGTIMECOLOR { get; set; }

		public decimal? MINTIME { get; set; }

		public string MINTIMECOLOR { get; set; }

		public decimal? MINWARNINGTIME { get; set; }

		public string MINWARNINGTIMECOLOR { get; set; }

		public string NOTES { get; set; }

		public string PROCESSTIMERBASEID { get; set; }

		public string PROCESSTIMERMAXTIMEDTLID { get; set; }

		public string PROCESSTIMERMINTIMEDTLID { get; set; }

		public string PROCESSTIMERTYPEID { get; set; }

		public string REVISION { get; set; }

		public uint? STATUS { get; set; }

		public uint? TIMERTYPE { get; set; }

		public string WIPMSGDEFMGRID { get; set; }

	}

}
