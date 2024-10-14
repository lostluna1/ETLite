using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class BIZ_WIREPOSTION {

		public string BIZ_WIREPOSTIONID { get; set; }

		public string BASEOBJECTID { get; set; }

		public string BIZ_WIREPOSTIONNAME { get; set; }

		public uint? CDOTYPEID { get; set; }

		public uint? CHANGECOUNT { get; set; }

		public decimal? CONDUCTOROD { get; set; }

		public decimal? CONDUCTORSA { get; set; }

		public decimal? CUTTINGLENGTH { get; set; }

		public uint? ISFROZEN { get; set; }

		public string LAYLENGTH { get; set; }

		public decimal? NEGATIVETOLERANCE { get; set; }

		public decimal? POSITIVETOLERANCE { get; set; }

		public string PRINTINGCONTENT { get; set; }

		public string REMARK { get; set; }

		public string SPECIFICATIONCODE { get; set; }

		public decimal? TWISTEDLENGTH { get; set; }

		public string WIRECOLOR { get; set; }

		public string WIREGROUPID { get; set; }

		public string WIRENO { get; set; }

		public string WIREPRODUCTID { get; set; }

		public string WIRERODPRODUCTID { get; set; }

		public string WIRESPECIFICATIONS { get; set; }

		public string WORKFLOWID { get; set; }

		public string XENGTOOLFAMILYID { get; set; }

		public string XFIRSTCROSSMATERIAL { get; set; }

		public string XMERGECRIMPING { get; set; }

		public string XMERGINGID { get; set; }

		public uint? XMERGINGNO { get; set; }

		public decimal? XPCBELECPOTPEELINGLENGTH { get; set; }

		public string XPOSTPROCESSING { get; set; }

		public string XQUOTATIONWPFPLUG { get; set; }

		public decimal? XROUNDWIREPEELINGLENGTH { get; set; }

		public decimal? XRWPEELINGLENGTHNTOLERENCE { get; set; }

		public decimal? XRWPEELINGLENGTHPTOLERENCE { get; set; }

		public decimal? XSPLICEPEELINGLENGTH { get; set; }

		public decimal? XSPOTPLATINGTINPEELINGLENGTH { get; set; }

		public string XTERMINALPOSITON { get; set; }

		public string XTERMINALPRODUCTID { get; set; }

		public string XTERMINALSPECIFICATIONS { get; set; }

		public string XTERMINALSPLICE { get; set; }

		public string XUSAGEMERGINGID { get; set; }

		public string XWPFPLUGPRODUCTID { get; set; }

		public string YENGTOOLFAMILYID { get; set; }

		public string YFIRSTCROSSMATERIAL { get; set; }

		public string YMERGECRIMPING { get; set; }

		public string YMERGINGID { get; set; }

		public uint? YMERGINGNO { get; set; }

		public decimal? YPCBELECPOTPEELINGLENGTH { get; set; }

		public string YPOSTPROCESSING { get; set; }

		public string YQUOTATIONWPFPLUG { get; set; }

		public decimal? YROUNDWIREPEELINGLENGTH { get; set; }

		public decimal? YRWPEELINGLENGTHNTOLERENCE { get; set; }

		public decimal? YRWPEELINGLENGTHPTOLERENCE { get; set; }

		public decimal? YSPLICEPEELINGLENGTH { get; set; }

		public decimal? YSPOTPLATINGTINPEELINGLENGTH { get; set; }

		public string YTERMINALPOSITON { get; set; }

		public string YTERMINALPRODUCTID { get; set; }

		public string YTERMINALSPECIFICATIONS { get; set; }

		public string YTERMINALSPLICE { get; set; }

		public string YUSAGEMERGINGID { get; set; }

		public string YWPFPLUGPRODUCTID { get; set; }

	}

}
