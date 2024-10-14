using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class A_RESOURCECOMPONENTS {

		public string RESOURCECOMPONENTSID { get; set; }

		public string BIZ_MFGORDERID { get; set; }

		public uint? CDOTYPEID { get; set; }

		public uint? CHANGECOUNT { get; set; }

		public uint? COMPONENTSEQUENCE { get; set; }

		public DateTime? CREATETIME { get; set; }

		public string EMPLOYEEID { get; set; }

		public string EXPORTIMPORTKEY { get; set; }

		public string FROMCONTAINERID { get; set; }

		public string FROMFEEDERID { get; set; }

		public string FROMLOT { get; set; }

		public string FROMSTOCKPOINT { get; set; }

		public uint? ISFROZEN { get; set; }

		public uint? ISSUECONTROL { get; set; }

		public string ISSUEDIFFERENCEREASONID { get; set; }

		public string PRODUCTID { get; set; }

		public string RESOURCEID { get; set; }

		public string RESOURCESLOTID { get; set; }

		public string SUBSTITUTIONREASONID { get; set; }

	}

}
