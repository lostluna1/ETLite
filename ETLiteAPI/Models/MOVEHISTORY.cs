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
	public partial class MOVEHISTORY {

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)", IsPrimary = true, IsNullable = false)]
		public string MOVEHISTORYID { get; set; }

		[JsonProperty]
		public uint? CDOTYPEID { get; set; }

		[JsonProperty]
		public uint? CHANGECOUNT { get; set; }

		[JsonProperty]
		public uint? CHILDCOUNT { get; set; }

		[JsonProperty]
		public uint? CLOSEFLAG { get; set; }

		[JsonProperty]
		public uint? CONTAINERSTATUS { get; set; }

		[JsonProperty]
		public uint? CUMULATIVEREWORKSTEPCOUNT { get; set; }

		[JsonProperty, Column(DbType = "NUMBER(22)")]
		public decimal? CYCLETIME { get; set; }

		[JsonProperty, Column(DbType = "NUMBER(22)")]
		public decimal? ELAPSEDTIME { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string ENDREWORKSTEPID { get; set; }

		[JsonProperty, Column(DbType = "NUMBER(22)")]
		public decimal? EQUIPMENTCYCLETIMEMS { get; set; }

		[JsonProperty, Column(Name = "ES_TESTID", DbType = "VARCHAR2(36 BYTE)")]
		public string ESTESTID { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(36 BYTE)")]
		public string EXPORTIMPORTKEY { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string HISTORYID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string HISTORYMAINLINEID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string INTEGRATIONTXNID { get; set; }

		[JsonProperty]
		public uint? ISFAILED { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string LOCATIONID { get; set; }

		[JsonProperty]
		public uint? MOVEALLQTY { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string OWNERID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string PATHID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string PRODUCTID { get; set; }

		[JsonProperty, Column(DbType = "NUMBER(22)")]
		public decimal? QTY { get; set; }

		[JsonProperty, Column(DbType = "NUMBER(22)")]
		public decimal? QTY2 { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string REENTRYSTEPID { get; set; }

		[JsonProperty]
		public uint? REMOTECONTAINERSTATUS { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string REWORKREASONID { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(30 BYTE)")]
		public string RUN { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string SETUPID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string SHIPMENTDESTINATIONID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string STEPID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string TOCUSTOMERID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string TOFACTORYID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string TOLOCATIONID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string TORESOURCEID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string TOSPECID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string TOSTEPID { get; set; }

		[JsonProperty]
		public uint? TOSTEPUSAGE { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string TXNID { get; set; }

		[JsonProperty]
		public uint? UNITCOUNT { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string UOM2ID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string UOMID { get; set; }

	}

}
