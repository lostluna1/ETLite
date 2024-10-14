using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class RP_MFGDATA {

		public decimal? ACHIEVEMENT { get; set; }

		public decimal? ACTUALQTY { get; set; }

		public decimal? ACUTUAL_MANPOWER { get; set; }

		public string BASEUOM { get; set; }

		public string BDDESC { get; set; }

		public decimal? BIZ_ACTIVETIME { get; set; }

		public string BIZ_ATUOMID { get; set; }

		public string BIZ_BUNAME { get; set; }

		public string BIZ_DEPTNAME { get; set; }

		public decimal? BIZ_EQTTIME { get; set; }

		public decimal? BIZ_MANTIME { get; set; }

		public decimal? BIZ_PREPARETIME { get; set; }

		public decimal? BIZ_PRODCOSTSTIME { get; set; }

		public decimal? BIZ_STAQTY { get; set; }

		public string BIZ_WORKCENTER { get; set; }

		public string BUDESC { get; set; }

		public DateTime? CALENDARDAY { get; set; }

		public DateTime? CREATETIME { get; set; }

		public string CTODESC { get; set; }

		public string CUSTOMERNAME { get; set; }

		public string DESCRIPTION { get; set; }

		public decimal? EFFCIENCY { get; set; }

		public string EMPLOYEENAME { get; set; }

		public string ERPOPERATION { get; set; }

		public string ERPROUTENAME { get; set; }

		public uint? ES_STARTVIRTUALSN { get; set; }

		public string ETUOM { get; set; }

		public string FACTORY { get; set; }

		public string FULLNAME { get; set; }

		public string LINEDESC { get; set; }

		public string MFGLINENAME { get; set; }

		public string MFGORDERNAME { get; set; }

		public string MTUOM { get; set; }

		public string NAME { get; set; }

		public decimal? NGQTY { get; set; }

		public string ORDERSTATUSNAME { get; set; }

		public string ORDERTYPENAME { get; set; }

		public string OSDESC { get; set; }

		public string PBDESC { get; set; }

		public string PFDESC { get; set; }

		public DateTime? PLANNEDCOMPLETIONDATE { get; set; }

		public DateTime? PLANNEDSTARTDATE { get; set; }

		public string PREUOM { get; set; }

		public string PRODUCTFAMILYNAME { get; set; }

		public string PRODUCTNAME { get; set; }

		public string PRODUCTTYPENAME { get; set; }

		public string PROUOM { get; set; }

		public string PTDESC { get; set; }

		public decimal? QTY { get; set; }

		public DateTime? RELEASEDATE { get; set; }

		public string SEQUENCE { get; set; }

		public string SFTDESC { get; set; }

		public string SHIFTNAME { get; set; }

		public decimal? TARGETQTY { get; set; }

		public string UOMNAME { get; set; }

		public string WODESC { get; set; }

		public decimal? YIELD { get; set; }

	}

}
