using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class EXECUTETASKHISTORY {

		public string EXECUTETASKHISTORYID { get; set; }

		public string CARRIERID { get; set; }

		public uint? CDOTYPEID { get; set; }

		public uint? CHANGECOUNT { get; set; }

		public uint? COMPLETETASKFORBATCH { get; set; }

		public string DOCUMENTSETID { get; set; }

		public string ELECTRONICPROCEDUREID { get; set; }

		public string EXPORTIMPORTKEY { get; set; }

		public string HISTORYID { get; set; }

		public string HISTORYMAINLINEID { get; set; }

		public string INSTRUCTION { get; set; }

		public string INTEGRATIONTXNID { get; set; }

		public string ISSUEDIFFERENCEREASONID { get; set; }

		public string MATERIALCONTAINERID { get; set; }

		public uint? PASS { get; set; }

		public uint? SEQUENCE { get; set; }

		public string SPECID { get; set; }

		public string TASKCOMMENTS { get; set; }

		public string TASKID { get; set; }

		public string TASKLISTID { get; set; }

		public uint? TASKLISTSEQUENCE { get; set; }

		public uint? TASKTYPE { get; set; }

		public string TRAININGREQGROUPID { get; set; }

		public string TXNID { get; set; }

		public string WORKCELLID { get; set; }

		public string WORKSTATIONID { get; set; }

	}

}
