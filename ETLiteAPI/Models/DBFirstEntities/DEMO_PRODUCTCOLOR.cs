using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class DEMO_PRODUCTCOLOR {

		public string PRODUCTCOLORID { get; set; }

		/// <summary>
		/// ����
		/// </summary>
		public string COLOR { get; set; }

		public DateTime? CREATEDATE { get; set; }

		public int? CREATEID { get; set; }

		public string CREATOR { get; set; }

		/// <summary>
		/// ����
		/// </summary>
		public string IMG { get; set; }

		public string MODIFIER { get; set; }

		public DateTime? MODIFYDATE { get; set; }

		public int? MODIFYID { get; set; }

		/// <summary>
		/// ����id
		/// </summary>
		public string PRODUCTID { get; set; }

		/// <summary>
		/// ����
		/// </summary>
		public string QTY { get; set; }

		/// <summary>
		/// ����
		/// </summary>
		public string REMARK { get; set; }

		/// <summary>
		/// ����
		/// </summary>
		public string UNIT { get; set; }

	}

}
