using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Tencent.Android.Tpush.Stat {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.tencent.android.tpush.stat']/class[@name='StatReportStrategy']"
	[global::Android.Runtime.Register ("com/tencent/android/tpush/stat/StatReportStrategy", DoNotGenerateAcw=true)]
	public sealed partial class StatReportStrategy : global::Java.Lang.Enum {



		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.android.tpush.stat']/class[@name='StatReportStrategy']/field[@name='APP_LAUNCH']"
		[Register ("APP_LAUNCH")]
		public static global::Com.Tencent.Android.Tpush.Stat.StatReportStrategy AppLaunch {
			get {
				const string __id = "APP_LAUNCH.Lcom/tencent/android/tpush/stat/StatReportStrategy;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Tencent.Android.Tpush.Stat.StatReportStrategy> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.android.tpush.stat']/class[@name='StatReportStrategy']/field[@name='BATCH']"
		[Register ("BATCH")]
		public static global::Com.Tencent.Android.Tpush.Stat.StatReportStrategy Batch {
			get {
				const string __id = "BATCH.Lcom/tencent/android/tpush/stat/StatReportStrategy;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Tencent.Android.Tpush.Stat.StatReportStrategy> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.android.tpush.stat']/class[@name='StatReportStrategy']/field[@name='DEVELOPER']"
		[Register ("DEVELOPER")]
		public static global::Com.Tencent.Android.Tpush.Stat.StatReportStrategy Developer {
			get {
				const string __id = "DEVELOPER.Lcom/tencent/android/tpush/stat/StatReportStrategy;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Tencent.Android.Tpush.Stat.StatReportStrategy> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.android.tpush.stat']/class[@name='StatReportStrategy']/field[@name='INSTANT']"
		[Register ("INSTANT")]
		public static global::Com.Tencent.Android.Tpush.Stat.StatReportStrategy Instant {
			get {
				const string __id = "INSTANT.Lcom/tencent/android/tpush/stat/StatReportStrategy;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Tencent.Android.Tpush.Stat.StatReportStrategy> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.android.tpush.stat']/class[@name='StatReportStrategy']/field[@name='ONLY_WIFI']"
		[Register ("ONLY_WIFI")]
		public static global::Com.Tencent.Android.Tpush.Stat.StatReportStrategy OnlyWifi {
			get {
				const string __id = "ONLY_WIFI.Lcom/tencent/android/tpush/stat/StatReportStrategy;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Tencent.Android.Tpush.Stat.StatReportStrategy> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.android.tpush.stat']/class[@name='StatReportStrategy']/field[@name='ONLY_WIFI_NO_CACHE']"
		[Register ("ONLY_WIFI_NO_CACHE")]
		public static global::Com.Tencent.Android.Tpush.Stat.StatReportStrategy OnlyWifiNoCache {
			get {
				const string __id = "ONLY_WIFI_NO_CACHE.Lcom/tencent/android/tpush/stat/StatReportStrategy;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Tencent.Android.Tpush.Stat.StatReportStrategy> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.android.tpush.stat']/class[@name='StatReportStrategy']/field[@name='PERIOD']"
		[Register ("PERIOD")]
		public static global::Com.Tencent.Android.Tpush.Stat.StatReportStrategy Period {
			get {
				const string __id = "PERIOD.Lcom/tencent/android/tpush/stat/StatReportStrategy;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Tencent.Android.Tpush.Stat.StatReportStrategy> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}
		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/tencent/android/tpush/stat/StatReportStrategy", typeof (StatReportStrategy));
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

		internal StatReportStrategy (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.android.tpush.stat']/class[@name='StatReportStrategy']/method[@name='a' and count(parameter)=0]"
		[Register ("a", "()I", "")]
		public unsafe int A ()
		{
			const string __id = "a.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.android.tpush.stat']/class[@name='StatReportStrategy']/method[@name='a' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("a", "(I)Lcom/tencent/android/tpush/stat/StatReportStrategy;", "")]
		public static unsafe global::Com.Tencent.Android.Tpush.Stat.StatReportStrategy A (int p0)
		{
			const string __id = "a.(I)Lcom/tencent/android/tpush/stat/StatReportStrategy;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Tencent.Android.Tpush.Stat.StatReportStrategy> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.android.tpush.stat']/class[@name='StatReportStrategy']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lcom/tencent/android/tpush/stat/StatReportStrategy;", "")]
		public static unsafe global::Com.Tencent.Android.Tpush.Stat.StatReportStrategy ValueOf (string p0)
		{
			const string __id = "valueOf.(Ljava/lang/String;)Lcom/tencent/android/tpush/stat/StatReportStrategy;";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Tencent.Android.Tpush.Stat.StatReportStrategy> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.android.tpush.stat']/class[@name='StatReportStrategy']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lcom/tencent/android/tpush/stat/StatReportStrategy;", "")]
		public static unsafe global::Com.Tencent.Android.Tpush.Stat.StatReportStrategy[] Values ()
		{
			const string __id = "values.()[Lcom/tencent/android/tpush/stat/StatReportStrategy;";
			try {
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
				return (global::Com.Tencent.Android.Tpush.Stat.StatReportStrategy[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Com.Tencent.Android.Tpush.Stat.StatReportStrategy));
			} finally {
			}
		}

	}
}
