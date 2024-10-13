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
	public partial class CIOCHANNELADAPTER {

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)", IsPrimary = true, IsNullable = false)]
		public string CIOCHANNELADAPTERID { get; set; }

		[JsonProperty]
		public uint? ACTIVEBACKUP { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(30 BYTE)")]
		public string ADAPTERKIND { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(15 BYTE)")]
		public string ADAPTERVERSION { get; set; }

		[JsonProperty]
		public uint? AGGRESSIVEWAKEUP { get; set; }

		[JsonProperty]
		public uint? AUTHENTICATIONEXPIRATION { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(255 BYTE)")]
		public string AUTHENTICATIONEXTENSION { get; set; }

		[JsonProperty]
		public uint? AUTHENTICATIONTYPE { get; set; }

		[JsonProperty]
		public uint? BAUDRATE { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(30 BYTE)")]
		public string BINDINGNAME { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(255 BYTE)")]
		public string CACHEFILENAME { get; set; }

		[JsonProperty]
		public uint? CDOTYPEID { get; set; }

		[JsonProperty]
		public uint? CHANGECOUNT { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string CHANGEHISTORY { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string CHANGEHISTORYID { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(100 BYTE)")]
		public string CHECKINBOUNDMESSAGESP { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string CIOBINDINGID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string CIOBUFFERID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string CIOCAMSTARCONNECTIONID { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(30 BYTE)")]
		public string CIOCHANNELADAPTERNAME { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string CIOCHANNELSOURCEID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string CIODATAHANDLERID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string CIODETAILSECTIONID { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(255 BYTE)")]
		public string CIOHTTPVERB { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string CIOMESSAGECHANNELID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string CIOMESSAGETYPEID { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(255 BYTE)")]
		public string CIOPROCESSRESPONSE { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(255 BYTE)")]
		public string CIOSERIALTRIGGER { get; set; }

		[JsonProperty]
		public uint? CLEARORIGINALCONTENTS { get; set; }

		[JsonProperty]
		public uint? CONNECTADAPTERMAXRETRIES { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(100 BYTE)")]
		public string CONNECTADAPTERSP { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(100 BYTE)")]
		public string CONNECTIONNAME { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(2000 BYTE)")]
		public string CONNECTIONSTRING { get; set; }

		[JsonProperty]
		public uint? CONNECTTIMEOUT { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(2000 BYTE)")]
		public string CUSTOMHEADERCONFIGURATION { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(255 BYTE)")]
		public string CUSTOMHEADERPLUGIN { get; set; }

		[JsonProperty]
		public uint? DATABITS { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(255 BYTE)")]
		public string DATAHANDLERCONFIGURATION { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(100 BYTE)")]
		public string DATAHANDLERNAME { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(512 BYTE)")]
		public string DATAHUBADDRESS { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(512 BYTE)")]
		public string DATAHUBBINDINGCONFIG { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(100 BYTE)")]
		public string DBSCHEMA { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(255 BYTE)")]
		public string DBTYPE { get; set; }

		[JsonProperty]
		public uint? DELETEINTERVAL { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(30 BYTE)")]
		public string DELIMITERS { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(255 BYTE)")]
		public string DESCRIPTION { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(255 BYTE)")]
		public string DESCRIPTION1 { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(100 BYTE)")]
		public string DISCONNECTADAPTERSP { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(30 BYTE)")]
		public string DOMAINNAME { get; set; }

		[JsonProperty]
		public uint? DONOTSEND { get; set; }

		[JsonProperty]
		public uint? DONOTSENDOUTBOUND { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(100 BYTE)")]
		public string ENCODINGNAME { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(512 BYTE)")]
		public string ERRORURI { get; set; }

		[JsonProperty, Column(Name = "ES_DELETEINTERVAL")]
		public uint? ESDELETEINTERVAL { get; set; }

		[JsonProperty, Column(Name = "ES_ERRORURI", DbType = "VARCHAR2(512 BYTE)")]
		public string ESERRORURI { get; set; }

		[JsonProperty, Column(Name = "ES_INBOUNDDRIVETOMAPEDIF", DbType = "VARCHAR2(2 BYTE)")]
		public string ESINBOUNDDRIVETOMAPEDIF { get; set; }

		[JsonProperty, Column(Name = "ES_INBOUNDDRIVETOMAPFAT", DbType = "VARCHAR2(2 BYTE)")]
		public string ESINBOUNDDRIVETOMAPFAT { get; set; }

		[JsonProperty, Column(Name = "ES_INBOUNDDRIVETOMAPODB", DbType = "VARCHAR2(2 BYTE)")]
		public string ESINBOUNDDRIVETOMAPODB { get; set; }

		[JsonProperty, Column(Name = "ES_INBOUNDDRIVETOMAPPDW", DbType = "VARCHAR2(2 BYTE)")]
		public string ESINBOUNDDRIVETOMAPPDW { get; set; }

		[JsonProperty, Column(Name = "ES_INBOUNDURIEDIF", DbType = "VARCHAR2(512 BYTE)")]
		public string ESINBOUNDURIEDIF { get; set; }

		[JsonProperty, Column(Name = "ES_INBOUNDURIFAT", DbType = "VARCHAR2(512 BYTE)")]
		public string ESINBOUNDURIFAT { get; set; }

		[JsonProperty, Column(Name = "ES_INBOUNDURIODB", DbType = "VARCHAR2(512 BYTE)")]
		public string ESINBOUNDURIODB { get; set; }

		[JsonProperty, Column(Name = "ES_INBOUNDURIPDW", DbType = "VARCHAR2(512 BYTE)")]
		public string ESINBOUNDURIPDW { get; set; }

		[JsonProperty, Column(Name = "ES_MAXREADRETRIES")]
		public uint? ESMAXREADRETRIES { get; set; }

		[JsonProperty, Column(Name = "ES_OUTBOUNDDRIVETOMAP", DbType = "VARCHAR2(2 BYTE)")]
		public string ESOUTBOUNDDRIVETOMAP { get; set; }

		[JsonProperty, Column(Name = "ES_OUTBOUNDURI", DbType = "VARCHAR2(512 BYTE)")]
		public string ESOUTBOUNDURI { get; set; }

		[JsonProperty, Column(Name = "ES_RETRYDELAY")]
		public uint? ESRETRYDELAY { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(255 BYTE)")]
		public string EXPRESSMAPCONFIGURATION { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(100 BYTE)")]
		public string EXPRESSMAPCUSTOMPLUGIN { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(255 BYTE)")]
		public string EXPRESSMAPPLUGIN { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(30 BYTE)")]
		public string EXPRESSSUBMITCONFIGURATION { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(100 BYTE)")]
		public string EXPRESSSUBMITPLUGIN { get; set; }

		[JsonProperty]
		public uint? FASTINTERVAL { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(255 BYTE)")]
		public string FILTERTAGS { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(30 BYTE)")]
		public string FORMATTER { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(30 BYTE)")]
		public string GATEWAYPHONENUMBER { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(255 BYTE)")]
		public string HANDSHAKE { get; set; }

		[JsonProperty]
		public uint? HEARTBEATACTIVE { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(2000 BYTE)")]
		public string HEARTBEATFAILURESTRING { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string HEARTBEATFAILURETEMPLATEID { get; set; }

		[JsonProperty]
		public uint? HEARTBEATINTERVAL { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(2000 BYTE)")]
		public string HEARTBEATRESTORESTRING { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string HEARTBEATRESTORETEMPLATEID { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(512 BYTE)")]
		public string HOSTURL { get; set; }

		[JsonProperty]
		public uint? ICONID { get; set; }

		[JsonProperty]
		public uint? INBOUNDAUTHENTICATION { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(512 BYTE)")]
		public string INBOUNDDRIVETOMAP { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(255 BYTE)")]
		public string INBOUNDFILENAMEFILTER { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(100 BYTE)")]
		public string INBOUNDMESSAGERECEIVEDSP { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(100 BYTE)")]
		public string INBOUNDNAMEFORMAT { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(512 BYTE)")]
		public string INBOUNDQUEUENAME { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(512 BYTE)")]
		public string INBOUNDURI { get; set; }

		[JsonProperty]
		public uint? INPROCESSMESSAGESEXPIRY { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(512 BYTE)")]
		public string INTERFACEURL { get; set; }

		[JsonProperty]
		public uint? ISACTIVE { get; set; }

		[JsonProperty]
		public uint? ISFROZEN { get; set; }

		[JsonProperty]
		public uint? ISRECOVERABLE { get; set; }

		[JsonProperty]
		public uint? ISTRANSACTIONAL { get; set; }

		[JsonProperty]
		public uint? ISXML { get; set; }

		[JsonProperty]
		public uint? LASREADEXPIRY { get; set; }

		[JsonProperty]
		public uint? LINESPERMESSAGE { get; set; }

		[JsonProperty]
		public uint? LOGHEARTBEATFAILURES { get; set; }

		[JsonProperty]
		public uint? MAXADAPTERTHREADS { get; set; }

		[JsonProperty]
		public uint? MAXCACHEDURATION { get; set; }

		[JsonProperty]
		public uint? MAXIMUMSCALE { get; set; }

		[JsonProperty]
		public uint? MAXREADRETRIES { get; set; }

		[JsonProperty]
		public uint? MAXSHOPFLOORINTERFACETHREADS { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string MESSAGENAMEPARAMETERID { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(30 BYTE)")]
		public string MESSAGEPRIORITY { get; set; }

		[JsonProperty]
		public uint? MESSAGERECVDMAXRETRIES { get; set; }

		[JsonProperty]
		public uint? MESSAGERECVDRETRYINTERVAL { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string MESSAGETEMPLATEBASEID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string MESSAGETEMPLATEID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string MESSAGETYPEPARAMETERID { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(2000 BYTE)")]
		public string NOMATCHTEXT { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(2000 BYTE)")]
		public string NOTES { get; set; }

		[JsonProperty]
		public uint? NUMBEROFOCCURENCES { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(255 BYTE)")]
		public string OUTBOUNDAUTHCONFIGURATION { get; set; }

		[JsonProperty]
		public uint? OUTBOUNDAUTHENTICATION { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(255 BYTE)")]
		public string OUTBOUNDAUTHPLUGIN { get; set; }

		[JsonProperty]
		public uint? OUTBOUNDCACHEEXPIRY { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(512 BYTE)")]
		public string OUTBOUNDDRIVETOMAP { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(100 BYTE)")]
		public string OUTBOUNDFAILCONFIGURATION { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(100 BYTE)")]
		public string OUTBOUNDFAILPLUGIN { get; set; }

		[JsonProperty]
		public uint? OUTBOUNDMAXRETRIES { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(100 BYTE)")]
		public string OUTBOUNDNAMEFORMAT { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(512 BYTE)")]
		public string OUTBOUNDOAUTHURI { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(512 BYTE)")]
		public string OUTBOUNDQUEUENAME { get; set; }

		[JsonProperty]
		public uint? OUTBOUNDRETRYINTERVAL { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(512 BYTE)")]
		public string OUTBOUNDURI { get; set; }

		[JsonProperty]
		public uint? OVERRIDEBUFFER { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(255 BYTE)")]
		public string PARITY { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(128 BYTE)")]
		public string PASSWORD { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(255 BYTE)")]
		public string PASSWORDENCRYPTED { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(30 BYTE)")]
		public string PLUGINKIND { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(100 BYTE)")]
		public string PLUGINNAME { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(15 BYTE)")]
		public string PLUGINVERSION { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(100 BYTE)")]
		public string PORTNAME { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(30 BYTE)")]
		public string READDATAPOINTSFORMAT { get; set; }

		[JsonProperty]
		public uint? RECEIVEPROCESSINGTIMEOUT { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string REQUESTIDPARAMETERID { get; set; }

		[JsonProperty]
		public uint? REQUIREAUTHENTICATION { get; set; }

		[JsonProperty]
		public uint? RESPONSETIMEOUT { get; set; }

		[JsonProperty]
		public uint? RETRYDELAY { get; set; }

		[JsonProperty]
		public uint? SCHEDULETYPE { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(100 BYTE)")]
		public string SENDOUTBOUNDMESSAGESP { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(100 BYTE)")]
		public string SENDRESPONSEMESSAGESP { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(512 BYTE)")]
		public string SERVERURI { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string SETUPACCESS { get; set; }

		[JsonProperty]
		public uint? SHUTDOWNMAXTIME { get; set; }

		[JsonProperty]
		public uint? SLOWINTERVAL { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string SMSJOURNALID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string SMSJOURNALSID { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(255 BYTE)")]
		public string STOPBITS { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(30 BYTE)")]
		public string SUBSCRIPTIONSTATEFORMAT { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(30 BYTE)")]
		public string SUBSCRIPTIONTRIGGERFORMAT { get; set; }

		[JsonProperty]
		public uint? SUPRESSEMPTYROWS { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string TAGDATAPARAMETERID { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(30 BYTE)")]
		public string TEXTQUALIFIER { get; set; }

		[JsonProperty, Column(DbType = "DATE(7)")]
		public DateTime? TIMEOFDAY { get; set; }

		[JsonProperty]
		public uint? TIMETOBERECEIVED { get; set; }

		[JsonProperty]
		public uint? TIMETOREACHQUEUE { get; set; }

		[JsonProperty]
		public uint? TRIMWHITESPACE { get; set; }

		[JsonProperty]
		public uint? UNIQUECACHEEXPIRY { get; set; }

		[JsonProperty]
		public uint? UNIQUEWITHTIMESTAMP { get; set; }

		[JsonProperty]
		public uint? USEBINARYFORMATTING { get; set; }

		[JsonProperty]
		public uint? USEDEADLETTER { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(255 BYTE)")]
		public string USERNAME { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(50 BYTE)")]
		public string USERQUERYMESSAGETYPE { get; set; }

		[JsonProperty]
		public uint? VERIFYUNIQUE { get; set; }

		[JsonProperty]
		public uint? WAKEINTERVAL { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(100 BYTE)")]
		public string WAKEUPADAPTERSP { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(512 BYTE)")]
		public string WEBAPIHOSTURI { get; set; }

		[JsonProperty]
		public uint? WEBSERVICETIMEOUT { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(30 BYTE)")]
		public string WRITEDATAPOINTSFORMAT { get; set; }

	}

}
