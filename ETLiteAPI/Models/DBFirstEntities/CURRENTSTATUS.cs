using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class CURRENTSTATUS {

		public string CURRENTSTATUSID { get; set; }

		public string CARRIERID { get; set; }

		public uint? CDOTYPEID { get; set; }

		public uint? CHANGECOUNT { get; set; }

		public uint? CURRENTSTEPPASS { get; set; }

		public string FACTORYID { get; set; }

		public string INITIALRECIPELISTID { get; set; }

		public uint? INPROCESS { get; set; }

		public decimal? INQUEUETIME { get; set; }

		public uint? INREWORK { get; set; }

		public string ISFACTORYNAME { get; set; }

		public string ISOPERATIONNAME { get; set; }

		public decimal? ISOPSTARTQTY { get; set; }

		public decimal? ISOPSTARTQTY2 { get; set; }

		public string ISRESOURCENAME { get; set; }

		public string ISROUTESTEPID { get; set; }

		public string ISSPECNAME { get; set; }

		public string ISSPECREVISION { get; set; }

		public string ISWORKFLOWNAME { get; set; }

		public string ISWORKFLOWREVISION { get; set; }

		public string ISWORKFLOWSTEPNAME { get; set; }

		public uint? ISWORKFLOWSTEPSEQUENCE { get; set; }

		public string LASTCOMPLETEDTASKID { get; set; }

		public DateTime? LASTMOVEDATE { get; set; }

		public DateTime? LASTMOVEDATEGMT { get; set; }

		public DateTime? LASTMOVEOUTDATE { get; set; }

		public DateTime? LASTMOVEOUTDATEGMT { get; set; }

		public string LASTREVTXNID { get; set; }

		public string LOCATIONID { get; set; }

		public uint? LOOPPASS { get; set; }

		public DateTime? MOVEINDATE { get; set; }

		public DateTime? MOVEINDATEGMT { get; set; }

		public string RESOURCEID { get; set; }

		public uint? REWORKLOOPCOUNT { get; set; }

		public uint? REWORKTOTALCOUNT { get; set; }

		public string SPECID { get; set; }

		public string STEPENTRYTXNID { get; set; }

		public uint? TIMERSCOUNT { get; set; }

		public string WORKFLOWSTEPID { get; set; }

		public string WORKSTATIONID { get; set; }

	}

}
