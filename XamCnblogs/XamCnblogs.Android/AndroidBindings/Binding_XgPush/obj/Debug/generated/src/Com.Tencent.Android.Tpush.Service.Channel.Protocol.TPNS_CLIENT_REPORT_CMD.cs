using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Tencent.Android.Tpush.Service.Channel.Protocol {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.tencent.android.tpush.service.channel.protocol']/class[@name='TPNS_CLIENT_REPORT_CMD']"
	[global::Android.Runtime.Register ("com/tencent/android/tpush/service/channel/protocol/TPNS_CLIENT_REPORT_CMD", DoNotGenerateAcw=true)]
	public sealed partial class TPNS_CLIENT_REPORT_CMD : global::Java.Lang.Object, global::Java.IO.ISerializable {



		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.android.tpush.service.channel.protocol']/class[@name='TPNS_CLIENT_REPORT_CMD']/field[@name='CMD_REPORT_SPEED']"
		[Register ("CMD_REPORT_SPEED")]
		public static global::Com.Tencent.Android.Tpush.Service.Channel.Protocol.TPNS_CLIENT_REPORT_CMD CmdReportSpeed {
			get {
				const string __id = "CMD_REPORT_SPEED.Lcom/tencent/android/tpush/service/channel/protocol/TPNS_CLIENT_REPORT_CMD;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Tencent.Android.Tpush.Service.Channel.Protocol.TPNS_CLIENT_REPORT_CMD> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}
		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/tencent/android/tpush/service/channel/protocol/TPNS_CLIENT_REPORT_CMD", typeof (TPNS_CLIENT_REPORT_CMD));
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

		internal TPNS_CLIENT_REPORT_CMD (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

	}
}
