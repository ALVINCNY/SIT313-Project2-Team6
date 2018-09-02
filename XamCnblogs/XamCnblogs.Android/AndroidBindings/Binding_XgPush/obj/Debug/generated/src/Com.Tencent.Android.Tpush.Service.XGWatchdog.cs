using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Tencent.Android.Tpush.Service {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.tencent.android.tpush.service']/class[@name='XGWatchdog']"
	[global::Android.Runtime.Register ("com/tencent/android/tpush/service/XGWatchdog", DoNotGenerateAcw=true)]
	public partial class XGWatchdog : global::Java.Lang.Object {



		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.android.tpush.service']/class[@name='XGWatchdog']/field[@name='CURRENT_WD_VERSION']"
		[Register ("CURRENT_WD_VERSION")]
		public static global::Java.Lang.Integer CurrentWdVersion {
			get {
				const string __id = "CURRENT_WD_VERSION.Ljava/lang/Integer;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "CURRENT_WD_VERSION.Ljava/lang/Integer;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.StaticFields.SetValue (__id, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.android.tpush.service']/class[@name='XGWatchdog']/field[@name='TAG']"
		[Register ("TAG")]
		public const string Tag = (string) "xguardian";
		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/tencent/android/tpush/service/XGWatchdog", typeof (XGWatchdog));
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

		protected XGWatchdog (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static Delegate cb_getLocalXGApps;
#pragma warning disable 0169
		static Delegate GetGetLocalXGAppsHandler ()
		{
			if (cb_getLocalXGApps == null)
				cb_getLocalXGApps = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetLocalXGApps);
			return cb_getLocalXGApps;
		}

		static IntPtr n_GetLocalXGApps (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Tencent.Android.Tpush.Service.XGWatchdog __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Android.Tpush.Service.XGWatchdog> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.LocalXGApps);
		}
#pragma warning restore 0169

		public virtual unsafe string LocalXGApps {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.android.tpush.service']/class[@name='XGWatchdog']/method[@name='getLocalXGApps' and count(parameter)=0]"
			[Register ("getLocalXGApps", "()Ljava/lang/String;", "GetGetLocalXGAppsHandler")]
			get {
				const string __id = "getLocalXGApps.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public static unsafe int RandomPort {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.android.tpush.service']/class[@name='XGWatchdog']/method[@name='getRandomPort' and count(parameter)=0]"
			[Register ("getRandomPort", "()I", "GetGetRandomPortHandler")]
			get {
				const string __id = "getRandomPort.()I";
				try {
					var __rm = _members.StaticMethods.InvokeInt32Method (__id, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getWatchdogPort;
#pragma warning disable 0169
		static Delegate GetGetWatchdogPortHandler ()
		{
			if (cb_getWatchdogPort == null)
				cb_getWatchdogPort = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetWatchdogPort);
			return cb_getWatchdogPort;
		}

		static int n_GetWatchdogPort (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Tencent.Android.Tpush.Service.XGWatchdog __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Android.Tpush.Service.XGWatchdog> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.WatchdogPort;
		}
#pragma warning restore 0169

		public virtual unsafe int WatchdogPort {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.android.tpush.service']/class[@name='XGWatchdog']/method[@name='getWatchdogPort' and count(parameter)=0]"
			[Register ("getWatchdogPort", "()I", "GetGetWatchdogPortHandler")]
			get {
				const string __id = "getWatchdogPort.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.android.tpush.service']/class[@name='XGWatchdog']/method[@name='getInstance' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("getInstance", "(Landroid/content/Context;)Lcom/tencent/android/tpush/service/XGWatchdog;", "")]
		public static unsafe global::Com.Tencent.Android.Tpush.Service.XGWatchdog GetInstance (global::Android.Content.Context p0)
		{
			const string __id = "getInstance.(Landroid/content/Context;)Lcom/tencent/android/tpush/service/XGWatchdog;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Tencent.Android.Tpush.Service.XGWatchdog> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.android.tpush.service']/class[@name='XGWatchdog']/method[@name='getRandomInt' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getRandomInt", "(I)I", "")]
		public static unsafe int GetRandomInt (int p0)
		{
			const string __id = "getRandomInt.(I)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_sendAllLocalXGAppList;
#pragma warning disable 0169
		static Delegate GetSendAllLocalXGAppListHandler ()
		{
			if (cb_sendAllLocalXGAppList == null)
				cb_sendAllLocalXGAppList = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_SendAllLocalXGAppList);
			return cb_sendAllLocalXGAppList;
		}

		static void n_SendAllLocalXGAppList (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Tencent.Android.Tpush.Service.XGWatchdog __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Android.Tpush.Service.XGWatchdog> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SendAllLocalXGAppList ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.android.tpush.service']/class[@name='XGWatchdog']/method[@name='sendAllLocalXGAppList' and count(parameter)=0]"
		[Register ("sendAllLocalXGAppList", "()V", "GetSendAllLocalXGAppListHandler")]
		public virtual unsafe void SendAllLocalXGAppList ()
		{
			const string __id = "sendAllLocalXGAppList.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_sendDebugMode_Z;
#pragma warning disable 0169
		static Delegate GetSendDebugMode_ZHandler ()
		{
			if (cb_sendDebugMode_Z == null)
				cb_sendDebugMode_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SendDebugMode_Z);
			return cb_sendDebugMode_Z;
		}

		static void n_SendDebugMode_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Tencent.Android.Tpush.Service.XGWatchdog __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Android.Tpush.Service.XGWatchdog> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SendDebugMode (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.android.tpush.service']/class[@name='XGWatchdog']/method[@name='sendDebugMode' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("sendDebugMode", "(Z)V", "GetSendDebugMode_ZHandler")]
		public virtual unsafe void SendDebugMode (bool p0)
		{
			const string __id = "sendDebugMode.(Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_sendHeartbeat2Watchdog_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSendHeartbeat2Watchdog_Ljava_lang_String_Handler ()
		{
			if (cb_sendHeartbeat2Watchdog_Ljava_lang_String_ == null)
				cb_sendHeartbeat2Watchdog_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SendHeartbeat2Watchdog_Ljava_lang_String_);
			return cb_sendHeartbeat2Watchdog_Ljava_lang_String_;
		}

		static void n_SendHeartbeat2Watchdog_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Tencent.Android.Tpush.Service.XGWatchdog __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Android.Tpush.Service.XGWatchdog> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SendHeartbeat2Watchdog (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.android.tpush.service']/class[@name='XGWatchdog']/method[@name='sendHeartbeat2Watchdog' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("sendHeartbeat2Watchdog", "(Ljava/lang/String;)V", "GetSendHeartbeat2Watchdog_Ljava_lang_String_Handler")]
		public virtual unsafe void SendHeartbeat2Watchdog (string p0)
		{
			const string __id = "sendHeartbeat2Watchdog.(Ljava/lang/String;)V";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_sendXGApp_Ljava_lang_String_J;
#pragma warning disable 0169
		static Delegate GetSendXGApp_Ljava_lang_String_JHandler ()
		{
			if (cb_sendXGApp_Ljava_lang_String_J == null)
				cb_sendXGApp_Ljava_lang_String_J = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, long>) n_SendXGApp_Ljava_lang_String_J);
			return cb_sendXGApp_Ljava_lang_String_J;
		}

		static void n_SendXGApp_Ljava_lang_String_J (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, long p1)
		{
			global::Com.Tencent.Android.Tpush.Service.XGWatchdog __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Android.Tpush.Service.XGWatchdog> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SendXGApp (p0, p1);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.android.tpush.service']/class[@name='XGWatchdog']/method[@name='sendXGApp' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='long']]"
		[Register ("sendXGApp", "(Ljava/lang/String;J)V", "GetSendXGApp_Ljava_lang_String_JHandler")]
		public virtual unsafe void SendXGApp (string p0, long p1)
		{
			const string __id = "sendXGApp.(Ljava/lang/String;J)V";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (p1);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_startWatchdog;
#pragma warning disable 0169
		static Delegate GetStartWatchdogHandler ()
		{
			if (cb_startWatchdog == null)
				cb_startWatchdog = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_StartWatchdog);
			return cb_startWatchdog;
		}

		static void n_StartWatchdog (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Tencent.Android.Tpush.Service.XGWatchdog __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Android.Tpush.Service.XGWatchdog> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.StartWatchdog ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.android.tpush.service']/class[@name='XGWatchdog']/method[@name='startWatchdog' and count(parameter)=0]"
		[Register ("startWatchdog", "()V", "GetStartWatchdogHandler")]
		public virtual unsafe void StartWatchdog ()
		{
			const string __id = "startWatchdog.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

	}
}
