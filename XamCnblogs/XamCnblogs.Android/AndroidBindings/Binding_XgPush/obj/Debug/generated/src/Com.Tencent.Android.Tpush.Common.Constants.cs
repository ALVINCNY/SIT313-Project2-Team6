using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Tencent.Android.Tpush.Common {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.tencent.android.tpush.common']/class[@name='Constants']"
	[global::Android.Runtime.Register ("com/tencent/android/tpush/common/Constants", DoNotGenerateAcw=true)]
	public partial class Constants : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.android.tpush.common']/class[@name='Constants']/field[@name='ACTION_BROADCAST_ACKNOWLEDGE_ACK']"
		[Register ("ACTION_BROADCAST_ACKNOWLEDGE_ACK")]
		public const string ActionBroadcastAcknowledgeAck = (string) "com.tencent.android.tpush.action.BROADCAST_ACK";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.android.tpush.common']/class[@name='Constants']/field[@name='ACTION_FEEDBACK']"
		[Register ("ACTION_FEEDBACK")]
		public const string ActionFeedback = (string) "com.tencent.android.tpush.action.FEEDBACK";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.android.tpush.common']/class[@name='Constants']/field[@name='ACTION_INTERNAL_PUSH_MESSAGE']"
		[Register ("ACTION_INTERNAL_PUSH_MESSAGE")]
		public const string ActionInternalPushMessage = (string) "com.tencent.android.tpush.action.INTERNAL_PUSH_MESSAGE";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.android.tpush.common']/class[@name='Constants']/field[@name='ACTION_KEEPALIVE']"
		[Register ("ACTION_KEEPALIVE")]
		public const string ActionKeepalive = (string) "com.tencent.android.tpush.action.keepalive";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.android.tpush.common']/class[@name='Constants']/field[@name='ACTION_PREFFIX']"
		[Register ("ACTION_PREFFIX")]
		public const string ActionPreffix = (string) "com.tencent.android.tpush.action";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.android.tpush.common']/class[@name='Constants']/field[@name='ACTION_PUSH_MESSAGE']"
		[Register ("ACTION_PUSH_MESSAGE")]
		public const string ActionPushMessage = (string) "com.tencent.android.tpush.action.PUSH_MESSAGE";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.android.tpush.common']/class[@name='Constants']/field[@name='ACTION_SDK_INSTALL']"
		[Register ("ACTION_SDK_INSTALL")]
		public const string ActionSdkInstall = (string) "com.tencent.android.tpush.action.SDK";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.android.tpush.common']/class[@name='Constants']/field[@name='ACTION_SDK_NOTIFICATION_CLEARED']"
		[Register ("ACTION_SDK_NOTIFICATION_CLEARED")]
		public const string ActionSdkNotificationCleared = (string) "Notification.cleared";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.android.tpush.common']/class[@name='Constants']/field[@name='ACTION_SDK_TYPE']"
		[Register ("ACTION_SDK_TYPE")]
		public const string ActionSdkType = (string) "type";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.android.tpush.common']/class[@name='Constants']/field[@name='ACTION_SLVAE_2_MAIN']"
		[Register ("ACTION_SLVAE_2_MAIN")]
		public const string ActionSlvae2Main = (string) "com.tencent.android.tpush.action.slave2main";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.android.tpush.common']/class[@name='Constants']/field[@name='ACTION_START_SLVAE']"
		[Register ("ACTION_START_SLVAE")]
		public const string ActionStartSlvae = (string) "com.tencent.android.tpush.action.start_slave";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.android.tpush.common']/class[@name='Constants']/field[@name='ACTION_STOP_CONNECT']"
		[Register ("ACTION_STOP_CONNECT")]
		public const string ActionStopConnect = (string) "com.tencent.android.tpush.action.stop_connect";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.android.tpush.common']/class[@name='Constants']/field[@name='CODE_ACCESSKET_OR_ACCESSID_ERROR']"
		[Register ("CODE_ACCESSKET_OR_ACCESSID_ERROR")]
		public const int CodeAccessketOrAccessidError = (int) 10006;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.android.tpush.common']/class[@name='Constants']/field[@name='CODE_AIDL_ERROR']"
		[Register ("CODE_AIDL_ERROR")]
		public const int CodeAidlError = (int) -10005;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.android.tpush.common']/class[@name='Constants']/field[@name='CODE_DUPLICATE_REGISTER_EEROR']"
		[Register ("CODE_DUPLICATE_REGISTER_EEROR")]
		public const int CodeDuplicateRegisterEeror = (int) 10115;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.android.tpush.common']/class[@name='Constants']/field[@name='CODE_JCE_ERROR']"
		[Register ("CODE_JCE_ERROR")]
		public const int CodeJceError = (int) 10009;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.android.tpush.common']/class[@name='Constants']/field[@name='CODE_LOGIC_ILLEGAL_ARGUMENT']"
		[Register ("CODE_LOGIC_ILLEGAL_ARGUMENT")]
		public const int CodeLogicIllegalArgument = (int) 10001;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.android.tpush.common']/class[@name='Constants']/field[@name='CODE_LOGIC_REGISTER_IN_PROCESS']"
		[Register ("CODE_LOGIC_REGISTER_IN_PROCESS")]
		public const int CodeLogicRegisterInProcess = (int) 10002;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.android.tpush.common']/class[@name='Constants']/field[@name='CODE_NETWORK_CHANNEL_CANCELLED']"
		[Register ("CODE_NETWORK_CHANNEL_CANCELLED")]
		public const int CodeNetworkChannelCancelled = (int) 10102;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.android.tpush.common']/class[@name='Constants']/field[@name='CODE_NETWORK_CREATE_OPTIOMAL_SC_FAILED']"
		[Register ("CODE_NETWORK_CREATE_OPTIOMAL_SC_FAILED")]
		public const int CodeNetworkCreateOptiomalScFailed = (int) 10101;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.android.tpush.common']/class[@name='Constants']/field[@name='CODE_NETWORK_HANDLER_NULL']"
		[Register ("CODE_NETWORK_HANDLER_NULL")]
		public const int CodeNetworkHandlerNull = (int) 10110;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.android.tpush.common']/class[@name='Constants']/field[@name='CODE_NETWORK_INNER_EXCEPTION_OCCUR']"
		[Register ("CODE_NETWORK_INNER_EXCEPTION_OCCUR")]
		public const int CodeNetworkInnerExceptionOccur = (int) 10104;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.android.tpush.common']/class[@name='Constants']/field[@name='CODE_NETWORK_IOEXCEPTION_OCCUR']"
		[Register ("CODE_NETWORK_IOEXCEPTION_OCCUR")]
		public const int CodeNetworkIoexceptionOccur = (int) 10103;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.android.tpush.common']/class[@name='Constants']/field[@name='CODE_NETWORK_SECERETY_EEROR']"
		[Register ("CODE_NETWORK_SECERETY_EEROR")]
		public const int CodeNetworkSeceretyEeror = (int) 10111;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.android.tpush.common']/class[@name='Constants']/field[@name='CODE_NETWORK_TIMEOUT_EXCEPTION_OCCUR']"
		[Register ("CODE_NETWORK_TIMEOUT_EXCEPTION_OCCUR")]
		public const int CodeNetworkTimeoutExceptionOccur = (int) 10105;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.android.tpush.common']/class[@name='Constants']/field[@name='CODE_NETWORK_TIMEOUT_WAITING_FOR_RESPONSE']"
		[Register ("CODE_NETWORK_TIMEOUT_WAITING_FOR_RESPONSE")]
		public const int CodeNetworkTimeoutWaitingForResponse = (int) 10107;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.android.tpush.common']/class[@name='Constants']/field[@name='CODE_NETWORK_TIMEOUT_WAITING_TO_SEND']"
		[Register ("CODE_NETWORK_TIMEOUT_WAITING_TO_SEND")]
		public const int CodeNetworkTimeoutWaitingToSend = (int) 10106;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.android.tpush.common']/class[@name='Constants']/field[@name='CODE_NETWORK_UNEXPECTED_DATA_EXCEPTION_OCCUR']"
		[Register ("CODE_NETWORK_UNEXPECTED_DATA_EXCEPTION_OCCUR")]
		public const int CodeNetworkUnexpectedDataExceptionOccur = (int) 10108;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.android.tpush.common']/class[@name='Constants']/field[@name='CODE_NETWORK_UNKNOWN_EXCEPTION']"
		[Register ("CODE_NETWORK_UNKNOWN_EXCEPTION")]
		public const int CodeNetworkUnknownException = (int) 10109;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.android.tpush.common']/class[@name='Constants']/field[@name='CODE_NETWORK_UNREACHABLE']"
		[Register ("CODE_NETWORK_UNREACHABLE")]
		public const int CodeNetworkUnreachable = (int) 10100;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.android.tpush.common']/class[@name='Constants']/field[@name='CODE_PERMISSIONS_ERROR']"
		[Register ("CODE_PERMISSIONS_ERROR")]
		public const int CodePermissionsError = (int) 10003;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.android.tpush.common']/class[@name='Constants']/field[@name='CODE_PROVIDER_ERROR']"
		[Register ("CODE_PROVIDER_ERROR")]
		public const int CodeProviderError = (int) 10008;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.android.tpush.common']/class[@name='Constants']/field[@name='CODE_SERVICE_DISABLED']"
		[Register ("CODE_SERVICE_DISABLED")]
		public const int CodeServiceDisabled = (int) 10007;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.android.tpush.common']/class[@name='Constants']/field[@name='CODE_SO_ERROR']"
		[Register ("CODE_SO_ERROR")]
		public const int CodeSoError = (int) 10004;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.android.tpush.common']/class[@name='Constants']/field[@name='CODE_STRATEGY_INIT']"
		[Register ("CODE_STRATEGY_INIT")]
		public const int CodeStrategyInit = (int) 10300;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.android.tpush.common']/class[@name='Constants']/field[@name='CODE_SUCCESS']"
		[Register ("CODE_SUCCESS")]
		public const int CodeSuccess = (int) 0;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.android.tpush.common']/class[@name='Constants']/field[@name='ERRORCODE_UNKNOWN']"
		[Register ("ERRORCODE_UNKNOWN")]
		public const int ErrorcodeUnknown = (int) 10000;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.android.tpush.common']/class[@name='Constants']/field[@name='E_MOBILE_CHINAMOBILE']"
		[Register ("E_MOBILE_CHINAMOBILE")]
		public const sbyte EMobileChinamobile = (sbyte) 3;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.android.tpush.common']/class[@name='Constants']/field[@name='E_MOBILE_TELCOM']"
		[Register ("E_MOBILE_TELCOM")]
		public const sbyte EMobileTelcom = (sbyte) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.android.tpush.common']/class[@name='Constants']/field[@name='E_MOBILE_UNICOM']"
		[Register ("E_MOBILE_UNICOM")]
		public const sbyte EMobileUnicom = (sbyte) 2;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.android.tpush.common']/class[@name='Constants']/field[@name='E_MOBILE_UNKNOWN']"
		[Register ("E_MOBILE_UNKNOWN")]
		public const sbyte EMobileUnknown = (sbyte) 0;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.android.tpush.common']/class[@name='Constants']/field[@name='FEEDBACK_ERROR_CODE']"
		[Register ("FEEDBACK_ERROR_CODE")]
		public const string FeedbackErrorCode = (string) "TPUSH.ERRORCODE";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.android.tpush.common']/class[@name='Constants']/field[@name='FEEDBACK_NOTIFACTION_CLICKED']"
		[Register ("FEEDBACK_NOTIFACTION_CLICKED")]
		public const int FeedbackNotifactionClicked = (int) 4;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.android.tpush.common']/class[@name='Constants']/field[@name='FEEDBACK_NOTIFACTION_SHOWED']"
		[Register ("FEEDBACK_NOTIFACTION_SHOWED")]
		public const int FeedbackNotifactionShowed = (int) 5;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.android.tpush.common']/class[@name='Constants']/field[@name='FEEDBACK_REGISTER']"
		[Register ("FEEDBACK_REGISTER")]
		public const int FeedbackRegister = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.android.tpush.common']/class[@name='Constants']/field[@name='FEEDBACK_SET_DELETE_TAG']"
		[Register ("FEEDBACK_SET_DELETE_TAG")]
		public const int FeedbackSetDeleteTag = (int) 3;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.android.tpush.common']/class[@name='Constants']/field[@name='FEEDBACK_TAG']"
		[Register ("FEEDBACK_TAG")]
		public const string FeedbackTag = (string) "TPUSH.FEEDBACK";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.android.tpush.common']/class[@name='Constants']/field[@name='FEEDBACK_UNREGISTER']"
		[Register ("FEEDBACK_UNREGISTER")]
		public const int FeedbackUnregister = (int) 2;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.android.tpush.common']/class[@name='Constants']/field[@name='FLAG_ACCOUNT']"
		[Register ("FLAG_ACCOUNT")]
		public const string FlagAccount = (string) "account";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.android.tpush.common']/class[@name='Constants']/field[@name='FLAG_ACC_ID']"
		[Register ("FLAG_ACC_ID")]
		public const string FlagAccId = (string) "accId";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.android.tpush.common']/class[@name='Constants']/field[@name='FLAG_ACTION_CONFIRM']"
		[Register ("FLAG_ACTION_CONFIRM")]
		public const string FlagActionConfirm = (string) "action_confirm";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.android.tpush.common']/class[@name='Constants']/field[@name='FLAG_ACTION_TYPE']"
		[Register ("FLAG_ACTION_TYPE")]
		public const string FlagActionType = (string) "action_type";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.android.tpush.common']/class[@name='Constants']/field[@name='FLAG_ACTIVITY_NAME']"
		[Register ("FLAG_ACTIVITY_NAME")]
		public const string FlagActivityName = (string) "activity";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.android.tpush.common']/class[@name='Constants']/field[@name='FLAG_CLICK_DELETE_ACTION']"
		[Register ("FLAG_CLICK_DELETE_ACTION")]
		public const string FlagClickDeleteAction = (string) "action";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.android.tpush.common']/class[@name='Constants']/field[@name='FLAG_CLICK_TIME']"
		[Register ("FLAG_CLICK_TIME")]
		public const string FlagClickTime = (string) "clickTime";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.android.tpush.common']/class[@name='Constants']/field[@name='FLAG_DEVICE_ID']"
		[Register ("FLAG_DEVICE_ID")]
		public const string FlagDeviceId = (string) "deviceId";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.android.tpush.common']/class[@name='Constants']/field[@name='FLAG_NOTIFICATION_ACTION_TYPE']"
		[Register ("FLAG_NOTIFICATION_ACTION_TYPE")]
		public const string FlagNotificationActionType = (string) "notificationActionType";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.android.tpush.common']/class[@name='Constants']/field[@name='FLAG_OFFLINE']"
		[Register ("FLAG_OFFLINE")]
		public const int FlagOffline = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.android.tpush.common']/class[@name='Constants']/field[@name='FLAG_ONLINE']"
		[Register ("FLAG_ONLINE")]
		public const int FlagOnline = (int) 0;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.android.tpush.common']/class[@name='Constants']/field[@name='FLAG_PACKAGE_DOWNLOAD_URL']"
		[Register ("FLAG_PACKAGE_DOWNLOAD_URL")]
		public const string FlagPackageDownloadUrl = (string) "packageDownloadUrl";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.android.tpush.common']/class[@name='Constants']/field[@name='FLAG_PACKAGE_NAME']"
		[Register ("FLAG_PACKAGE_NAME")]
		public const string FlagPackageName = (string) "packageName";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.android.tpush.common']/class[@name='Constants']/field[@name='FLAG_PACK_NAME']"
		[Register ("FLAG_PACK_NAME")]
		public const string FlagPackName = (string) "packName";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.android.tpush.common']/class[@name='Constants']/field[@name='FLAG_TAG_NAME']"
		[Register ("FLAG_TAG_NAME")]
		public const string FlagTagName = (string) "tagName";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.android.tpush.common']/class[@name='Constants']/field[@name='FLAG_TAG_TYPE']"
		[Register ("FLAG_TAG_TYPE")]
		public const string FlagTagType = (string) "tagFlag";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.android.tpush.common']/class[@name='Constants']/field[@name='FLAG_TICKET']"
		[Register ("FLAG_TICKET")]
		public const string FlagTicket = (string) "ticket";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.android.tpush.common']/class[@name='Constants']/field[@name='FLAG_TICKET_TYPE']"
		[Register ("FLAG_TICKET_TYPE")]
		public const string FlagTicketType = (string) "ticketType";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.android.tpush.common']/class[@name='Constants']/field[@name='FLAG_TOKEN']"
		[Register ("FLAG_TOKEN")]
		public const string FlagToken = (string) "token";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.android.tpush.common']/class[@name='Constants']/field[@name='HorseLogTag']"
		[Register ("HorseLogTag")]
		public const string HorseLogTag = (string) "XGHorse";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.android.tpush.common']/class[@name='Constants']/field[@name='IS_CACHE_CLEAR']"
		[Register ("IS_CACHE_CLEAR")]
		public const string IsCacheClear = (string) "isClearCache.com.tencent.tpush.cache.redirect";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.android.tpush.common']/class[@name='Constants']/field[@name='IS_CLEAR_CACHE']"
		[Register ("IS_CLEAR_CACHE")]
		public const string IsClearCache = (string) "memeda3";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.android.tpush.common']/class[@name='Constants']/field[@name='LOCAL_MESSAGE_FLAG']"
		[Register ("LOCAL_MESSAGE_FLAG")]
		public const string LocalMessageFlag = (string) "tpush.local.msg.";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.android.tpush.common']/class[@name='Constants']/field[@name='LOC_REPORT_TIME']"
		[Register ("LOC_REPORT_TIME")]
		public const string LocReportTime = (string) "M_LAST_REPORT_LOC_TIME";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.android.tpush.common']/class[@name='Constants']/field[@name='LogTag']"
		[Register ("LogTag")]
		public const string LogTag = (string) "TPush";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.android.tpush.common']/class[@name='Constants']/field[@name='MAIN_VERSION_TAG']"
		[Register ("MAIN_VERSION_TAG")]
		public const string MainVersionTag = (string) "";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.android.tpush.common']/class[@name='Constants']/field[@name='MSDK_TAG']"
		[Register ("MSDK_TAG")]
		public const string MsdkTag = (string) "XG_MSDK";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.android.tpush.common']/class[@name='Constants']/field[@name='MSG_CUSTOM_CONTENT']"
		[Register ("MSG_CUSTOM_CONTENT")]
		public const string MsgCustomContent = (string) "custom_content";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.android.tpush.common']/class[@name='Constants']/field[@name='MTA_MSG_ARRIVE']"
		[Register ("MTA_MSG_ARRIVE")]
		public const string MtaMsgArrive = (string) "MTA_PUSH_R";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.android.tpush.common']/class[@name='Constants']/field[@name='MTA_MSG_OPEN']"
		[Register ("MTA_MSG_OPEN")]
		public const string MtaMsgOpen = (string) "MTA_PUSH_O";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.android.tpush.common']/class[@name='Constants']/field[@name='MTA_MSG_OPEN_TIME']"
		[Register ("MTA_MSG_OPEN_TIME")]
		public const string MtaMsgOpenTime = (string) "MTA_PUSH_T";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.android.tpush.common']/class[@name='Constants']/field[@name='NETWORK_RESTAT_DELAY_TIME']"
		[Register ("NETWORK_RESTAT_DELAY_TIME")]
		public const string NetworkRestatDelayTime = (string) "delay_time";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.android.tpush.common']/class[@name='Constants']/field[@name='NETWORK_TYPE_2G']"
		[Register ("NETWORK_TYPE_2G")]
		public const sbyte NetworkType2g = (sbyte) 2;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.android.tpush.common']/class[@name='Constants']/field[@name='NETWORK_TYPE_3G']"
		[Register ("NETWORK_TYPE_3G")]
		public const sbyte NetworkType3g = (sbyte) 3;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.android.tpush.common']/class[@name='Constants']/field[@name='NETWORK_TYPE_4G']"
		[Register ("NETWORK_TYPE_4G")]
		public const sbyte NetworkType4g = (sbyte) 4;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.android.tpush.common']/class[@name='Constants']/field[@name='NETWORK_TYPE_UNCONNECTED']"
		[Register ("NETWORK_TYPE_UNCONNECTED")]
		public const sbyte NetworkTypeUnconnected = (sbyte) -1;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.android.tpush.common']/class[@name='Constants']/field[@name='NETWORK_TYPE_UNKNOWN']"
		[Register ("NETWORK_TYPE_UNKNOWN")]
		public const sbyte NetworkTypeUnknown = (sbyte) 0;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.android.tpush.common']/class[@name='Constants']/field[@name='NETWORK_TYPE_WIFI']"
		[Register ("NETWORK_TYPE_WIFI")]
		public const sbyte NetworkTypeWifi = (sbyte) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.android.tpush.common']/class[@name='Constants']/field[@name='OTHER_PUSH_TAG']"
		[Register ("OTHER_PUSH_TAG")]
		public const string OtherPushTag = (string) "XGOtherPush";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.android.tpush.common']/class[@name='Constants']/field[@name='PARAM_NEED_CACHE']"
		[Register ("PARAM_NEED_CACHE")]
		public const string ParamNeedCache = (string) "needhttpcache";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.android.tpush.common']/class[@name='Constants']/field[@name='PROTOCOL_HTTP']"
		[Register ("PROTOCOL_HTTP")]
		public const short ProtocolHttp = (short) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.android.tpush.common']/class[@name='Constants']/field[@name='PROTOCOL_NONE']"
		[Register ("PROTOCOL_NONE")]
		public const short ProtocolNone = (short) -1;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.android.tpush.common']/class[@name='Constants']/field[@name='PROTOCOL_TCP']"
		[Register ("PROTOCOL_TCP")]
		public const short ProtocolTcp = (short) 0;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.android.tpush.common']/class[@name='Constants']/field[@name='PRO_LOG_TAG']"
		[Register ("PRO_LOG_TAG")]
		public const string ProLogTag = (string) "XGPro";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.android.tpush.common']/class[@name='Constants']/field[@name='PUSH_SDK_VERSION']"
		[Register ("PUSH_SDK_VERSION")]
		public const float PushSdkVersion = (float) 3.220000;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.android.tpush.common']/class[@name='Constants']/field[@name='PushMessageLogTag']"
		[Register ("PushMessageLogTag")]
		public const string PushMessageLogTag = (string) "XGPushMessage";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.android.tpush.common']/class[@name='Constants']/field[@name='REDIRECTED_NO']"
		[Register ("REDIRECTED_NO")]
		public const short RedirectedNo = (short) 0;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.android.tpush.common']/class[@name='Constants']/field[@name='REDIRECTED_YES']"
		[Register ("REDIRECTED_YES")]
		public const short RedirectedYes = (short) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.android.tpush.common']/class[@name='Constants']/field[@name='REGISTER_FAIL']"
		[Register ("REGISTER_FAIL")]
		public const int RegisterFail = (int) 3;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.android.tpush.common']/class[@name='Constants']/field[@name='REGISTER_INIT']"
		[Register ("REGISTER_INIT")]
		public const int RegisterInit = (int) 0;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.android.tpush.common']/class[@name='Constants']/field[@name='REGISTER_IN_PROGRESS']"
		[Register ("REGISTER_IN_PROGRESS")]
		public const int RegisterInProgress = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.android.tpush.common']/class[@name='Constants']/field[@name='REGISTER_OK']"
		[Register ("REGISTER_OK")]
		public const int RegisterOk = (int) 2;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.android.tpush.common']/class[@name='Constants']/field[@name='REPORT_LOG_TAG']"
		[Register ("REPORT_LOG_TAG")]
		public const string ReportLogTag = (string) "ReportLogTag";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.android.tpush.common']/class[@name='Constants']/field[@name='RPC_SUFFIX']"
		[Register ("RPC_SUFFIX")]
		public const string RpcSuffix = (string) ".PUSH_ACTION";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.android.tpush.common']/class[@name='Constants']/field[@name='SETTINGS_ENABLE_APPLIST']"
		[Register ("SETTINGS_ENABLE_APPLIST")]
		public const string SettingsEnableApplist = (string) "com.tencent.android.tpush.enable_applist";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.android.tpush.common']/class[@name='Constants']/field[@name='SETTINGS_ENABLE_DEBUG_NAME']"
		[Register ("SETTINGS_ENABLE_DEBUG_NAME")]
		public const string SettingsEnableDebugName = (string) "com.tencent.android.tpush.debug";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.android.tpush.common']/class[@name='Constants']/field[@name='SETTINGS_ENABLE_FCM']"
		[Register ("SETTINGS_ENABLE_FCM")]
		public const string SettingsEnableFcm = (string) "com.tencent.android.tpush.fcm";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.android.tpush.common']/class[@name='Constants']/field[@name='SETTINGS_ENABLE_FOREIGINPUSH']"
		[Register ("SETTINGS_ENABLE_FOREIGINPUSH")]
		public const string SettingsEnableForeiginpush = (string) "com.tencent.android.tpush.enable_FOREIGINPUSH";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.android.tpush.common']/class[@name='Constants']/field[@name='SETTINGS_ENABLE_LOCATION']"
		[Register ("SETTINGS_ENABLE_LOCATION")]
		public const string SettingsEnableLocation = (string) "com.tencent.android.tpush.enable_location";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.android.tpush.common']/class[@name='Constants']/field[@name='SETTINGS_ENABLE_NOTIFICATION']"
		[Register ("SETTINGS_ENABLE_NOTIFICATION")]
		public const string SettingsEnableNotification = (string) "com.tencent.android.tpush.enable_NOTIICATION";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.android.tpush.common']/class[@name='Constants']/field[@name='SETTINGS_ENABLE_OTHER_PUSH']"
		[Register ("SETTINGS_ENABLE_OTHER_PUSH")]
		public const string SettingsEnableOtherPush = (string) "com.tencent.android.tpush.other.push";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.android.tpush.common']/class[@name='Constants']/field[@name='SETTINGS_SERVICE_PACKAGE_NAME']"
		[Register ("SETTINGS_SERVICE_PACKAGE_NAME")]
		public const string SettingsServicePackageName = (string) "tpush.running.service.name";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.android.tpush.common']/class[@name='Constants']/field[@name='SETTINGS_SOCKET_NAME']"
		[Register ("SETTINGS_SOCKET_NAME")]
		public const string SettingsSocketName = (string) "com.tencent.android.tpush.socket.name";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.android.tpush.common']/class[@name='Constants']/field[@name='SETTINGS_UNREGISTER_INFO_NAME']"
		[Register ("SETTINGS_UNREGISTER_INFO_NAME")]
		public const string SettingsUnregisterInfoName = (string) "tpush.unrge.info";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.android.tpush.common']/class[@name='Constants']/field[@name='SHARED_PREFS_KEY_REGISTER']"
		[Register ("SHARED_PREFS_KEY_REGISTER")]
		public const string SharedPrefsKeyRegister = (string) "reg";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.android.tpush.common']/class[@name='Constants']/field[@name='SHARED_PREFS_NAME']"
		[Register ("SHARED_PREFS_NAME")]
		public const string SharedPrefsName = (string) ".tpush.local.setting.private";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.android.tpush.common']/class[@name='Constants']/field[@name='ServiceLogTag']"
		[Register ("ServiceLogTag")]
		public const string ServiceLogTag = (string) "XGService";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.android.tpush.common']/class[@name='Constants']/field[@name='TAG_TPUSH_MESSAGE']"
		[Register ("TAG_TPUSH_MESSAGE")]
		public const string TagTpushMessage = (string) "tag.tpush.MSG";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.android.tpush.common']/class[@name='Constants']/field[@name='TAG_TPUSH_NOTIFICATION']"
		[Register ("TAG_TPUSH_NOTIFICATION")]
		public const string TagTpushNotification = (string) "tag.tpush.NOTIFIC";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.android.tpush.common']/class[@name='Constants']/field[@name='TYPE_DELETE_KEY_VALUE_TAG']"
		[Register ("TYPE_DELETE_KEY_VALUE_TAG")]
		public const int TypeDeleteKeyValueTag = (int) 4;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.android.tpush.common']/class[@name='Constants']/field[@name='TYPE_DELETE_TAG']"
		[Register ("TYPE_DELETE_TAG")]
		public const int TypeDeleteTag = (int) 2;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.android.tpush.common']/class[@name='Constants']/field[@name='TYPE_SET_KEY_VALUE_TAG']"
		[Register ("TYPE_SET_KEY_VALUE_TAG")]
		public const int TypeSetKeyValueTag = (int) 3;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.android.tpush.common']/class[@name='Constants']/field[@name='TYPE_SET_TAG']"
		[Register ("TYPE_SET_TAG")]
		public const int TypeSetTag = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.android.tpush.common']/class[@name='Constants']/field[@name='TcpRecvPackLogTag']"
		[Register ("TcpRecvPackLogTag")]
		public const string TcpRecvPackLogTag = (string) "XGTcpRecvPacks";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.android.tpush.common']/class[@name='Constants']/field[@name='TcpSendPackLogTag']"
		[Register ("TcpSendPackLogTag")]
		public const string TcpSendPackLogTag = (string) "XGTcpSendPacks";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.android.tpush.common']/class[@name='Constants']/field[@name='UNREGISTER_FAIL']"
		[Register ("UNREGISTER_FAIL")]
		public const int UnregisterFail = (int) 7;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.android.tpush.common']/class[@name='Constants']/field[@name='UNREGISTER_INIT']"
		[Register ("UNREGISTER_INIT")]
		public const int UnregisterInit = (int) 4;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.android.tpush.common']/class[@name='Constants']/field[@name='UNREGISTER_IN_PROGRESS']"
		[Register ("UNREGISTER_IN_PROGRESS")]
		public const int UnregisterInProgress = (int) 5;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.android.tpush.common']/class[@name='Constants']/field[@name='UNREGISTER_OK']"
		[Register ("UNREGISTER_OK")]
		public const int UnregisterOk = (int) 6;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.android.tpush.common']/class[@name='Constants']/field[@name='UNSTALL_DOMAIN']"
		[Register ("UNSTALL_DOMAIN")]
		public const string UnstallDomain = (string) "pingma.qq.com";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.android.tpush.common']/class[@name='Constants']/field[@name='UNSTALL_PORT']"
		[Register ("UNSTALL_PORT")]
		public const string UnstallPort = (string) "80";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.android.tpush.common']/class[@name='Constants']/field[@name='UNSTALL_URL']"
		[Register ("UNSTALL_URL")]
		public const string UnstallUrl = (string) "/mstat/report";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.android.tpush.common']/class[@name='Constants']/field[@name='VIVO_STR']"
		[Register ("VIVO_STR")]
		public const string VivoStr = (string) "vivo X6";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.android.tpush.common']/class[@name='Constants']/field[@name='XG_SERVICE_CONN_COMPATIBLE_VERSION']"
		[Register ("XG_SERVICE_CONN_COMPATIBLE_VERSION")]
		public const int XgServiceConnCompatibleVersion = (int) 3;
		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/tencent/android/tpush/common/Constants", typeof (Constants));
		internal static new IntPtr class_ref {
			get {
				return _members.JniPeerType.PeerReference.Handle;
			}
		}

		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		protected override IntPtr ThresholdClass {
			get { return _members.JniPeerType.PeerReference.Handle; }
		}

		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		protected Constants (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.tencent.android.tpush.common']/class[@name='Constants']/constructor[@name='Constants' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe Constants ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "()V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), null);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.android.tpush.common']/class[@name='Constants']/method[@name='errCodeToMsg' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("errCodeToMsg", "(I)Ljava/lang/String;", "")]
		public static unsafe string ErrCodeToMsg (int p0)
		{
			const string __id = "errCodeToMsg.(I)Ljava/lang/String;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
