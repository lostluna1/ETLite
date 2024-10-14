using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class CIOCHANNELADAPTER {

		public string CIOCHANNELADAPTERID { get; set; }

		public uint? ACTIVEBACKUP { get; set; }

		public string ADAPTERKIND { get; set; }

		public string ADAPTERVERSION { get; set; }

		public uint? AGGRESSIVEWAKEUP { get; set; }

		public uint? AUTHENTICATIONEXPIRATION { get; set; }

		public string AUTHENTICATIONEXTENSION { get; set; }

		public uint? AUTHENTICATIONTYPE { get; set; }

		public uint? BAUDRATE { get; set; }

		public string BINDINGNAME { get; set; }

		public string CACHEFILENAME { get; set; }

		public uint? CDOTYPEID { get; set; }

		public uint? CHANGECOUNT { get; set; }

		public string CHANGEHISTORY { get; set; }

		public string CHANGEHISTORYID { get; set; }

		public string CHECKINBOUNDMESSAGESP { get; set; }

		public string CIOBINDINGID { get; set; }

		public string CIOBUFFERID { get; set; }

		public string CIOCAMSTARCONNECTIONID { get; set; }

		public string CIOCHANNELADAPTERNAME { get; set; }

		public string CIOCHANNELSOURCEID { get; set; }

		public string CIODATAHANDLERID { get; set; }

		public string CIODETAILSECTIONID { get; set; }

		public string CIOHTTPVERB { get; set; }

		public string CIOMESSAGECHANNELID { get; set; }

		public string CIOMESSAGETYPEID { get; set; }

		public string CIOPROCESSRESPONSE { get; set; }

		public string CIOSERIALTRIGGER { get; set; }

		public uint? CLEARORIGINALCONTENTS { get; set; }

		public uint? CONNECTADAPTERMAXRETRIES { get; set; }

		public string CONNECTADAPTERSP { get; set; }

		public string CONNECTIONNAME { get; set; }

		public string CONNECTIONSTRING { get; set; }

		public uint? CONNECTTIMEOUT { get; set; }

		public string CUSTOMHEADERCONFIGURATION { get; set; }

		public string CUSTOMHEADERPLUGIN { get; set; }

		public uint? DATABITS { get; set; }

		public string DATAHANDLERCONFIGURATION { get; set; }

		public string DATAHANDLERNAME { get; set; }

		public string DATAHUBADDRESS { get; set; }

		public string DATAHUBBINDINGCONFIG { get; set; }

		public string DBSCHEMA { get; set; }

		public string DBTYPE { get; set; }

		public uint? DELETEINTERVAL { get; set; }

		public string DELIMITERS { get; set; }

		public string DESCRIPTION { get; set; }

		public string DESCRIPTION1 { get; set; }

		public string DISCONNECTADAPTERSP { get; set; }

		public string DOMAINNAME { get; set; }

		public uint? DONOTSEND { get; set; }

		public uint? DONOTSENDOUTBOUND { get; set; }

		public string ENCODINGNAME { get; set; }

		public string ERRORURI { get; set; }

		public uint? ES_DELETEINTERVAL { get; set; }

		public string ES_ERRORURI { get; set; }

		public string ES_INBOUNDDRIVETOMAPEDIF { get; set; }

		public string ES_INBOUNDDRIVETOMAPFAT { get; set; }

		public string ES_INBOUNDDRIVETOMAPODB { get; set; }

		public string ES_INBOUNDDRIVETOMAPPDW { get; set; }

		public string ES_INBOUNDURIEDIF { get; set; }

		public string ES_INBOUNDURIFAT { get; set; }

		public string ES_INBOUNDURIODB { get; set; }

		public string ES_INBOUNDURIPDW { get; set; }

		public uint? ES_MAXREADRETRIES { get; set; }

		public string ES_OUTBOUNDDRIVETOMAP { get; set; }

		public string ES_OUTBOUNDURI { get; set; }

		public uint? ES_RETRYDELAY { get; set; }

		public string EXPRESSMAPCONFIGURATION { get; set; }

		public string EXPRESSMAPCUSTOMPLUGIN { get; set; }

		public string EXPRESSMAPPLUGIN { get; set; }

		public string EXPRESSSUBMITCONFIGURATION { get; set; }

		public string EXPRESSSUBMITPLUGIN { get; set; }

		public uint? FASTINTERVAL { get; set; }

		public string FILTERTAGS { get; set; }

		public string FORMATTER { get; set; }

		public string GATEWAYPHONENUMBER { get; set; }

		public string HANDSHAKE { get; set; }

		public uint? HEARTBEATACTIVE { get; set; }

		public string HEARTBEATFAILURESTRING { get; set; }

		public string HEARTBEATFAILURETEMPLATEID { get; set; }

		public uint? HEARTBEATINTERVAL { get; set; }

		public string HEARTBEATRESTORESTRING { get; set; }

		public string HEARTBEATRESTORETEMPLATEID { get; set; }

		public string HOSTURL { get; set; }

		public uint? ICONID { get; set; }

		public uint? INBOUNDAUTHENTICATION { get; set; }

		public string INBOUNDDRIVETOMAP { get; set; }

		public string INBOUNDFILENAMEFILTER { get; set; }

		public string INBOUNDMESSAGERECEIVEDSP { get; set; }

		public string INBOUNDNAMEFORMAT { get; set; }

		public string INBOUNDQUEUENAME { get; set; }

		public string INBOUNDURI { get; set; }

		public uint? INPROCESSMESSAGESEXPIRY { get; set; }

		public string INTERFACEURL { get; set; }

		public uint? ISACTIVE { get; set; }

		public uint? ISFROZEN { get; set; }

		public uint? ISRECOVERABLE { get; set; }

		public uint? ISTRANSACTIONAL { get; set; }

		public uint? ISXML { get; set; }

		public uint? LASREADEXPIRY { get; set; }

		public uint? LINESPERMESSAGE { get; set; }

		public uint? LOGHEARTBEATFAILURES { get; set; }

		public uint? MAXADAPTERTHREADS { get; set; }

		public uint? MAXCACHEDURATION { get; set; }

		public uint? MAXIMUMSCALE { get; set; }

		public uint? MAXREADRETRIES { get; set; }

		public uint? MAXSHOPFLOORINTERFACETHREADS { get; set; }

		public string MESSAGENAMEPARAMETERID { get; set; }

		public string MESSAGEPRIORITY { get; set; }

		public uint? MESSAGERECVDMAXRETRIES { get; set; }

		public uint? MESSAGERECVDRETRYINTERVAL { get; set; }

		public string MESSAGETEMPLATEBASEID { get; set; }

		public string MESSAGETEMPLATEID { get; set; }

		public string MESSAGETYPEPARAMETERID { get; set; }

		public string NOMATCHTEXT { get; set; }

		public string NOTES { get; set; }

		public uint? NUMBEROFOCCURENCES { get; set; }

		public string OUTBOUNDAUTHCONFIGURATION { get; set; }

		public uint? OUTBOUNDAUTHENTICATION { get; set; }

		public string OUTBOUNDAUTHPLUGIN { get; set; }

		public uint? OUTBOUNDCACHEEXPIRY { get; set; }

		public string OUTBOUNDDRIVETOMAP { get; set; }

		public string OUTBOUNDFAILCONFIGURATION { get; set; }

		public string OUTBOUNDFAILPLUGIN { get; set; }

		public uint? OUTBOUNDMAXRETRIES { get; set; }

		public string OUTBOUNDNAMEFORMAT { get; set; }

		public string OUTBOUNDOAUTHURI { get; set; }

		public string OUTBOUNDQUEUENAME { get; set; }

		public uint? OUTBOUNDRETRYINTERVAL { get; set; }

		public string OUTBOUNDURI { get; set; }

		public uint? OVERRIDEBUFFER { get; set; }

		public string PARITY { get; set; }

		public string PASSWORD { get; set; }

		public string PASSWORDENCRYPTED { get; set; }

		public string PLUGINKIND { get; set; }

		public string PLUGINNAME { get; set; }

		public string PLUGINVERSION { get; set; }

		public string PORTNAME { get; set; }

		public string READDATAPOINTSFORMAT { get; set; }

		public uint? RECEIVEPROCESSINGTIMEOUT { get; set; }

		public string REQUESTIDPARAMETERID { get; set; }

		public uint? REQUIREAUTHENTICATION { get; set; }

		public uint? RESPONSETIMEOUT { get; set; }

		public uint? RETRYDELAY { get; set; }

		public uint? SCHEDULETYPE { get; set; }

		public string SENDOUTBOUNDMESSAGESP { get; set; }

		public string SENDRESPONSEMESSAGESP { get; set; }

		public string SERVERURI { get; set; }

		public string SETUPACCESS { get; set; }

		public uint? SHUTDOWNMAXTIME { get; set; }

		public uint? SLOWINTERVAL { get; set; }

		public string SMSJOURNALID { get; set; }

		public string SMSJOURNALSID { get; set; }

		public string STOPBITS { get; set; }

		public string SUBSCRIPTIONSTATEFORMAT { get; set; }

		public string SUBSCRIPTIONTRIGGERFORMAT { get; set; }

		public uint? SUPRESSEMPTYROWS { get; set; }

		public string TAGDATAPARAMETERID { get; set; }

		public string TEXTQUALIFIER { get; set; }

		public DateTime? TIMEOFDAY { get; set; }

		public uint? TIMETOBERECEIVED { get; set; }

		public uint? TIMETOREACHQUEUE { get; set; }

		public uint? TRIMWHITESPACE { get; set; }

		public uint? UNIQUECACHEEXPIRY { get; set; }

		public uint? UNIQUEWITHTIMESTAMP { get; set; }

		public uint? USEBINARYFORMATTING { get; set; }

		public uint? USEDEADLETTER { get; set; }

		public string USERNAME { get; set; }

		public string USERQUERYMESSAGETYPE { get; set; }

		public uint? VERIFYUNIQUE { get; set; }

		public uint? WAKEINTERVAL { get; set; }

		public string WAKEUPADAPTERSP { get; set; }

		public string WEBAPIHOSTURI { get; set; }

		public uint? WEBSERVICETIMEOUT { get; set; }

		public string WRITEDATAPOINTSFORMAT { get; set; }

	}

}
