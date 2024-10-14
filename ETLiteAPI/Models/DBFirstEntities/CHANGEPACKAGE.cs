using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class CHANGEPACKAGE {

		public string CHANGEPACKAGEID { get; set; }

		public string AUTHORID { get; set; }

		public string AUTHORNAME { get; set; }

		public uint? CDOTYPEID { get; set; }

		public uint? CHANGECOUNT { get; set; }

		public string COLLABORATORDATAID { get; set; }

		public uint? CPEXPORTSTATUS { get; set; }

		public uint? CPIMPORTSTATUS { get; set; }

		public DateTime? CREATIONDATE { get; set; }

		public DateTime? CREATIONDATEGMT { get; set; }

		public string CURRENTSTATUSID { get; set; }

		public string DESCRIPTION { get; set; }

		public string ECOECN { get; set; }

		public uint? EXPORTCOUNT { get; set; }

		public string EXPORTFOLDERLOCATION { get; set; }

		public DateTime? EXPORTREQUESTDATE { get; set; }

		public DateTime? EXPORTREQUESTDATEGMT { get; set; }

		public DateTime? LASTACTIVITYDATE { get; set; }

		public DateTime? LASTACTIVITYDATEGMT { get; set; }

		public DateTime? LASTUPDATEDDATE { get; set; }

		public DateTime? LASTUPDATEDDATEGMT { get; set; }

		public uint? LOCKALLMODELINGINSTANCES { get; set; }

		public uint? LOCKLNSTANCES { get; set; }

		public string MODELINGIMPORTFILE { get; set; }

		public string NAME { get; set; }

		public uint? NOTIFYOWNERALLSTATECHANGES { get; set; }

		public uint? NOTIFYOWNERROLEALLSTATECHGS { get; set; }

		public string OWNERID { get; set; }

		public string OWNERNAME { get; set; }

		public string OWNERROLEID { get; set; }

		public string OWNERROLENAME { get; set; }

		public string PACKAGECREATIONTEMPLATEID { get; set; }

		public string PACKAGETYPEID { get; set; }

		public string PACKAGETYPENAME { get; set; }

		public string PRIORITYID { get; set; }

		public string PRIORITYNAME { get; set; }

		public string REASONID { get; set; }

		public string REASONNAME { get; set; }

		public DateTime? RECOMMENDEDDEPLOYMENTDATE { get; set; }

		public string SOURCESYSTEMNAME { get; set; }

		public uint? STATUS { get; set; }

	}

}
