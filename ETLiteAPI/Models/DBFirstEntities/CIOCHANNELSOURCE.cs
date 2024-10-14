using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class CIOCHANNELSOURCE {

		public string CIOCHANNELSOURCEID { get; set; }

		public string ADMINADDRESS { get; set; }

		public string ADMINBINDINGCONFIG { get; set; }

		public uint? BACKUPPOLLINTERVAL { get; set; }

		public string BACKUPSOURCENAME { get; set; }

		public uint? CDOTYPEID { get; set; }

		public uint? CHANGECOUNT { get; set; }

		public string CHANGEHISTORYID { get; set; }

		public string CIOADMINBINDINGID { get; set; }

		public string CIOBUFFERID { get; set; }

		public string CIOCHANNELSOURCENAME { get; set; }

		public string CIOMESSAGECHANNELID { get; set; }

		public string CIOOUTBOUNDBINDINGID { get; set; }

		public string CONTROLADDRESS { get; set; }

		public string DESCRIPTION { get; set; }

		public string FILTERTAGS { get; set; }

		public string HOST1 { get; set; }

		public uint? ICONID { get; set; }

		public uint? ISACTIVE { get; set; }

		public uint? ISFROZEN { get; set; }

		public DateTime? LASTINITIALIZATIONGMT { get; set; }

		public uint? MESSAGEACTIVITYTIMESPAN { get; set; }

		public uint? MESSAGEHISTORYEXPIRY { get; set; }

		public uint? MINSENDRETRYINTERVAL { get; set; }

		public string NOTES { get; set; }

		public uint? NOTIFYCHANGES { get; set; }

		public string OUTBOUNDADDRESS { get; set; }

		public string OUTBOUNDBINDINGCONFIG { get; set; }

		public uint? PRIORITYBUFFERMAXTHREADS { get; set; }

		public string SETUPACCESS { get; set; }

		public string SOURCENAME { get; set; }

		public DateTime? UPDATERESERVATIONGMT { get; set; }

	}

}
