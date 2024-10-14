using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class CIOSENDOUTBOUNDMSGPARAMS {

		public string SENDOUTBOUNDMSGPARAMSID { get; set; }

		public uint? CDOTYPEID { get; set; }

		public uint? CHANGECOUNT { get; set; }

		public string CIODATABASEADAPTERID { get; set; }

		public uint? DATALENGTH { get; set; }

		public string DATATYPE { get; set; }

		public string DATAVALUE { get; set; }

		public string EXPORTIMPORTKEY { get; set; }

		public uint? ISFROZEN { get; set; }

		public string SENDOUTBOUNDMSGPARAMSNAME { get; set; }

	}

}
