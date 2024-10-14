using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class SPCCHARTDEF {

		public string SPCCHARTDEFID { get; set; }

		public uint? CDOTYPEID { get; set; }

		public uint? CHANGECOUNT { get; set; }

		public string CHANGEHISTORYID { get; set; }

		public uint? CHARTHEIGHT { get; set; }

		public string CHARTPROPERTIES { get; set; }

		public string CHARTTYPE { get; set; }

		public string CHARTVARIABLE { get; set; }

		public uint? CHARTWIDTH { get; set; }

		public string DESCRIPTION { get; set; }

		public uint? DISPLAYONEXCEPTION { get; set; }

		public string DOCTOVIEWID { get; set; }

		public string EMAILMESSAGEID { get; set; }

		public string EMAILNOTIFICATION { get; set; }

		public string FILTERTAGS { get; set; }

		public uint? ICONID { get; set; }

		public uint? ISFROZEN { get; set; }

		public uint? ISNEWSPC { get; set; }

		public uint? LEGENDLOCATION { get; set; }

		public string MACRO { get; set; }

		public string NOTES { get; set; }

		public string PUTCONTAINERONHOLDID { get; set; }

		public uint? RECORDAGAINSTCUSTOMSPCDATASRC { get; set; }

		public uint? REQUIREANNOTATION { get; set; }

		public uint? RUNTIMEDISPLAY { get; set; }

		public string SETRESOURCESTATUSID { get; set; }

		public string SETUPACCESSID { get; set; }

		public string SPCCHARTDEFNAME { get; set; }

		public uint? SPCCHARTDISPLAYOPTION { get; set; }

		public uint? SPCCHARTSAVEOPTIONS { get; set; }

		public string SPCCHARTTYPEID { get; set; }

		public string SPCCONNECTIONID { get; set; }

		public string SPCQUERYID { get; set; }

		public string SPCRULESID { get; set; }

		public uint? TRIGGEROCAPS { get; set; }

		public string USERPARM1 { get; set; }

		public string USERPARM10 { get; set; }

		public string USERPARM2 { get; set; }

		public string USERPARM3 { get; set; }

		public string USERPARM4 { get; set; }

		public string USERPARM5 { get; set; }

		public string USERPARM6 { get; set; }

		public string USERPARM7 { get; set; }

		public string USERPARM8 { get; set; }

		public string USERPARM9 { get; set; }

	}

}
