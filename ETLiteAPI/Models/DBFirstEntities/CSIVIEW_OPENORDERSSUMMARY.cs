using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class CSIVIEW_OPENORDERSSUMMARY {

		public decimal? COMPLETEDSTARTQTY { get; set; }

		public decimal? CONTAINERCOMPLETEDQTY { get; set; }

		public decimal? CONTAINERCURRENTQTY { get; set; }

		public string CONTAINERID { get; set; }

		public string CONTAINERNAME { get; set; }

		public string DEFAULTLOT { get; set; }

		public decimal? FACTORYSTARTQTY { get; set; }

		public string HOLDREASONID { get; set; }

		public uint? INREWORK { get; set; }

		public uint? ISLASTSTEP { get; set; }

		public DateTime? LASTACTIVITYDATE { get; set; }

		public string MFGORDERID { get; set; }

		public string MFGORDERNAME { get; set; }

		public DateTime? MOVETOLASTSTEPDATE { get; set; }

		public DateTime? ONHOLDDATE { get; set; }

		public decimal? ORDERQTY { get; set; }

		public string ORDERSTATUSNAME { get; set; }

		public DateTime? PLANNEDCOMPLETIONDATE { get; set; }

		public DateTime? PLANNEDSTARTDATE { get; set; }

		public string PRODUCTID { get; set; }

		public string PRODUCTNAME { get; set; }

		public string PRODUCTREVISION { get; set; }

		public decimal? SECONDSPERCONTAINER { get; set; }

		public decimal? SECONDSPERPIECE { get; set; }

		public string UOMNAME { get; set; }

		public string WORKFLOWSTEPNAME { get; set; }

	}

}
