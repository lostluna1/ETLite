using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class BIZ_METGNO {

		public string BIZ_METGNOID { get; set; }

		public string BIZ_METGNONAME { get; set; }

		public string BU_CODEID { get; set; }

		public uint? CDOTYPEID { get; set; }

		public uint? CHANGECOUNT { get; set; }

		public string CHANGEHISTORYID { get; set; }

		public string CREATED_BY { get; set; }

		public DateTime? CREATION_DATE { get; set; }

		public string DESCRIPTION { get; set; }

		public string ENABLE_FLAG { get; set; }

		public string EQUIPMENT_PARA { get; set; }

		public string FILTERTAGS { get; set; }

		public string FSS_CODEID { get; set; }

		public uint? ICONID { get; set; }

		public uint? ISFROZEN { get; set; }

		public DateTime? LAST_UPDATE_DATE { get; set; }

		public string LAST_UPDATED_BY { get; set; }

		public string MOLD_TYPEID { get; set; }

		public string NOTES { get; set; }

		public string PLANT_CODEID { get; set; }

		public string REMARK { get; set; }

		public string SETUPACCESSID { get; set; }

		public string TER_ITEM_CODEID { get; set; }

		public string ZAUTH { get; set; }

		public string ZAWG { get; set; }

		public string ZDZBM { get; set; }

		public string ZDZCS { get; set; }

		public string ZFORMAT { get; set; }

		public string ZGFBH { get; set; }

		public string ZHBMK { get; set; }

		public string ZHBXH { get; set; }

		public string ZJX { get; set; }

		public string ZJXPD { get; set; }

		public string ZMM2 { get; set; }

		public decimal? ZNMGF { get; set; }

		public decimal? ZNMGT { get; set; }

		public decimal? ZNMHD { get; set; }

		public decimal? ZNMKD { get; set; }

		public decimal? ZNMKF { get; set; }

		public decimal? ZNMKT { get; set; }

		public decimal? ZNXHD { get; set; }

		public decimal? ZNXKD { get; set; }

		public string ZOD { get; set; }

		public decimal? ZSCLL { get; set; }

		public decimal? ZTP01 { get; set; }

		public decimal? ZTP02 { get; set; }

		public decimal? ZTP03 { get; set; }

		public string ZVISN { get; set; }

		public decimal? ZWMGF { get; set; }

		public decimal? ZWMGT { get; set; }

		public decimal? ZWMHD { get; set; }

		public decimal? ZWMKD { get; set; }

		public decimal? ZWMKF { get; set; }

		public decimal? ZWMKT { get; set; }

		public decimal? ZWXHD { get; set; }

		public decimal? ZWXKD { get; set; }

		public string ZYBWZ { get; set; }

	}

}
