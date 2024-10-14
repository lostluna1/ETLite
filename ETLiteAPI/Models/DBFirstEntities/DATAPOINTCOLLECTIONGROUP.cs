using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class DATAPOINTCOLLECTIONGROUP {

		public string DATAPOINTCOLLECTIONGROUPID { get; set; }

		public uint? CDOTYPEID { get; set; }

		public uint? CHANGECOUNT { get; set; }

		public string DATAPOINTCOLLECTIONGROUPNAME { get; set; }

		public string DATAPOINTCOLLECTIONID { get; set; }

		public string EXPORTIMPORTKEY { get; set; }

		public uint? GROUPLAYOUT { get; set; }

		public uint? ISFROZEN { get; set; }

		public string LASTENTEREDBYID { get; set; }

		public string LASTENTEREDBYROLEID { get; set; }

		public DateTime? LASTENTEREDON { get; set; }

		public DateTime? LASTENTEREDONGMT { get; set; }

		public uint? MINIMUMSAMPLES { get; set; }

		public uint? SEQUENCE { get; set; }

	}

}
