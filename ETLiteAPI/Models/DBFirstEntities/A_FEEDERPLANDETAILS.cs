using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class A_FEEDERPLANDETAILS {

		public string FEEDERPLANDETAILSID { get; set; }

		public string BIZ_MAINMATERIALID { get; set; }

		public string BIZ_MOUNTID { get; set; }

		public uint? BIZ_POINTMOUNTQTY { get; set; }

		public string BIZ_SMTMACHINELOCID { get; set; }

		public string BIZ_SUBMATERIALDES { get; set; }

		public string BIZ_SUBMATERIALGRP { get; set; }

		public string BIZ_SUBMATERIALTYPE { get; set; }

		public uint? CDOTYPEID { get; set; }

		public uint? CHANGECOUNT { get; set; }

		public string EXPORTIMPORTKEY { get; set; }

		public string FEEDERFAMILYID { get; set; }

		public string FEEDERGROUPID { get; set; }

		public string FEEDERID { get; set; }

		public string FEEDERPLANID { get; set; }

		public uint? ISFROZEN { get; set; }

		public string PRODUCTBASEID { get; set; }

		public string PRODUCTID { get; set; }

		public string REMARK { get; set; }

		public string SLOTID { get; set; }

	}

}
