using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models {

	[JsonObject(MemberSerialization.OptIn), Table(DisableSyncStructure = true)]
	public partial class OUTBOUNDXMLDOCPROCESSING {

		[JsonProperty, Column(IsPrimary = true)]
		public uint DOCID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)", IsPrimary = true, IsNullable = false)]
		public string TXNID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string DATATRANSPORTID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(50 BYTE)")]
		public string OWNEDBYUUID { get; set; }

		[JsonProperty, Column(DbType = "DATE(7)")]
		public DateTime? STARTTIMESTAMP { get; set; }

	}

}
