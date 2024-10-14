using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class EXPORTIMPORTHEADER {

		public uint EXPORTIMPORTHEADERID { get; set; }

		public string COMPLETIONMESSAGE { get; set; }

		public uint? DOCCONTENTSID { get; set; }

		public DateTime? EXPORTDATE { get; set; }

		public DateTime? EXPORTDATEGMT { get; set; }

		public string EXPORTDBID { get; set; }

		public string EXPORTFACTORYNAME { get; set; }

		public string EXPORTIMPORTFILENAME { get; set; }

		public string EXPORTIMPORTNAME { get; set; }

		public uint? EXPORTIMPORTTYPE { get; set; }

		public string EXPORTIMPORTUSERID { get; set; }

		public uint? EXPORTIMPORTUSERUTCOFFSET { get; set; }

		public string EXPORTSITENAME { get; set; }

		public string EXPORTUSERDOMAINNAME { get; set; }

		public string EXPORTUSERFULLNAME { get; set; }

		public string EXPORTUSERNAME { get; set; }

		public uint? GENERATEEXPORTFILE { get; set; }

		public DateTime? LASTUPDATEDATE { get; set; }

		public DateTime? LASTUPDATEDATEGMT { get; set; }

		public uint? PROCESSEDOBJECTCOUNT { get; set; }

		public DateTime? PROCESSSTARTDATE { get; set; }

		public DateTime? PROCESSSTARTDATEGMT { get; set; }

		public uint? STATUS { get; set; }

		public uint? TARGETSYSTEMCOUNT { get; set; }

		public uint? TOTALOBJECTCOUNT { get; set; }

		public string TRACKABLEOBJECTNAME { get; set; }

	}

}
