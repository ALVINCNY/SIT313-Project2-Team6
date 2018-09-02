using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Tencent.Android.Tpush.Service.Channel.Exception {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.tencent.android.tpush.service.channel.exception']/class[@name='SecurityException']"
	[global::Android.Runtime.Register ("com/tencent/android/tpush/service/channel/exception/SecurityException", DoNotGenerateAcw=true)]
	public partial class SecurityException : global::Java.Lang.Throwable {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/tencent/android/tpush/service/channel/exception/SecurityException", typeof (SecurityException));
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

		protected SecurityException (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

	}
}
