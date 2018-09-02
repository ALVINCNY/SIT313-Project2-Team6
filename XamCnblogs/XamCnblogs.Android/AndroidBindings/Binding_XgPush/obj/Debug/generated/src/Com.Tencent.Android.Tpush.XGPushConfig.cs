using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Tencent.Android.Tpush {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.tencent.android.tpush']/class[@name='XGPushConfig']"
	[global::Android.Runtime.Register ("com/tencent/android/tpush/XGPushConfig", DoNotGenerateAcw=true)]
	public partial class XGPushConfig : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.android.tpush']/class[@name='XGPushConfig']/field[@name='TPUSH_ACCESS_ID']"
		[Register ("TPUSH_ACCESS_ID")]
		public const string TpushAccessId = (string) "XG_V2_ACCESS_ID";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.android.tpush']/class[@name='XGPushConfig']/field[@name='TPUSH_ACCESS_KEY']"
		[Register ("TPUSH_ACCESS_KEY")]
		public const string TpushAccessKey = (string) "XG_V2_ACCESS_KEY";


		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.android.tpush']/class[@name='XGPushConfig']/field[@name='_isHuaweiDebug']"
		[Register ("_isHuaweiDebug")]
		public static bool IsHuaweiDebug {
			get {
				const string __id = "_isHuaweiDebug.Z";

				var __v = _members.StaticFields.GetBooleanValue (__id);
				return __v;
			}
			set {
				const string __id = "_isHuaweiDebug.Z";

				try {
					_members.StaticFields.SetValue (__id, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.android.tpush']/class[@name='XGPushConfig']/field[@name='enableApplist']"
		[Register ("enableApplist")]
		public static global::Java.Lang.Boolean EnableApplist {
			get {
				const string __id = "enableApplist.Ljava/lang/Boolean;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Boolean> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "enableApplist.Ljava/lang/Boolean;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.StaticFields.SetValue (__id, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.android.tpush']/class[@name='XGPushConfig']/field[@name='enableLocation']"
		[Register ("enableLocation")]
		public static global::Java.Lang.Boolean EnableLocation {
			get {
				const string __id = "enableLocation.Ljava/lang/Boolean;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Boolean> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "enableLocation.Ljava/lang/Boolean;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.StaticFields.SetValue (__id, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.android.tpush']/class[@name='XGPushConfig']/field[@name='enableNotification']"
		[Register ("enableNotification")]
		public static global::Java.Lang.Boolean EnableNotification {
			get {
				const string __id = "enableNotification.Ljava/lang/Boolean;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Boolean> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "enableNotification.Ljava/lang/Boolean;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.StaticFields.SetValue (__id, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/tencent/android/tpush/XGPushConfig", typeof (XGPushConfig));
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

		protected XGPushConfig (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.tencent.android.tpush']/class[@name='XGPushConfig']/constructor[@name='XGPushConfig' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe XGPushConfig ()
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

		public static unsafe bool HuaweiDebug {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.android.tpush']/class[@name='XGPushConfig']/method[@name='isHuaweiDebug' and count(parameter)=0]"
			[Register ("isHuaweiDebug", "()Z", "GetIsHuaweiDebugHandler")]
			get {
				const string __id = "isHuaweiDebug.()Z";
				try {
					var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.android.tpush']/class[@name='XGPushConfig']/method[@name='setHuaweiDebug' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setHuaweiDebug", "(Z)V", "GetSetHuaweiDebug_ZHandler")]
			set {
				const string __id = "setHuaweiDebug.(Z)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.StaticMethods.InvokeVoidMethod (__id, __args);
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.android.tpush']/class[@name='XGPushConfig']/method[@name='enableDebug' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='boolean']]"
		[Register ("enableDebug", "(Landroid/content/Context;Z)V", "")]
		public static unsafe void EnableDebug (global::Android.Content.Context p0, bool p1)
		{
			const string __id = "enableDebug.(Landroid/content/Context;Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (p1);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.android.tpush']/class[@name='XGPushConfig']/method[@name='enableFcmPush' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='boolean']]"
		[Register ("enableFcmPush", "(Landroid/content/Context;Z)V", "")]
		public static unsafe void EnableFcmPush (global::Android.Content.Context p0, bool p1)
		{
			const string __id = "enableFcmPush.(Landroid/content/Context;Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (p1);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.android.tpush']/class[@name='XGPushConfig']/method[@name='enableOtherPush' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='boolean']]"
		[Register ("enableOtherPush", "(Landroid/content/Context;Z)V", "")]
		public static unsafe void EnableOtherPush (global::Android.Content.Context p0, bool p1)
		{
			const string __id = "enableOtherPush.(Landroid/content/Context;Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (p1);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.android.tpush']/class[@name='XGPushConfig']/method[@name='getAccessId' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("getAccessId", "(Landroid/content/Context;)J", "")]
		public static unsafe long GetAccessId (global::Android.Content.Context p0)
		{
			const string __id = "getAccessId.(Landroid/content/Context;)J";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.StaticMethods.InvokeInt64Method (__id, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.android.tpush']/class[@name='XGPushConfig']/method[@name='getAccessKey' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("getAccessKey", "(Landroid/content/Context;)Ljava/lang/String;", "")]
		public static unsafe string GetAccessKey (global::Android.Content.Context p0)
		{
			const string __id = "getAccessKey.(Landroid/content/Context;)Ljava/lang/String;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.android.tpush']/class[@name='XGPushConfig']/method[@name='getAccessidList' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("getAccessidList", "(Landroid/content/Context;)Ljava/util/List;", "")]
		public static unsafe global::System.Collections.IList GetAccessidList (global::Android.Content.Context p0)
		{
			const string __id = "getAccessidList.(Landroid/content/Context;)Ljava/util/List;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Android.Runtime.JavaList.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.android.tpush']/class[@name='XGPushConfig']/method[@name='getGameServer' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("getGameServer", "(Landroid/content/Context;)Ljava/lang/String;", "")]
		public static unsafe string GetGameServer (global::Android.Content.Context p0)
		{
			const string __id = "getGameServer.(Landroid/content/Context;)Ljava/lang/String;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.android.tpush']/class[@name='XGPushConfig']/method[@name='getInstallChannel' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("getInstallChannel", "(Landroid/content/Context;)Ljava/lang/String;", "")]
		public static unsafe string GetInstallChannel (global::Android.Content.Context p0)
		{
			const string __id = "getInstallChannel.(Landroid/content/Context;)Ljava/lang/String;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.android.tpush']/class[@name='XGPushConfig']/method[@name='getReportDebugMode' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("getReportDebugMode", "(Landroid/content/Context;)Z", "")]
		public static unsafe bool GetReportDebugMode (global::Android.Content.Context p0)
		{
			const string __id = "getReportDebugMode.(Landroid/content/Context;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.android.tpush']/class[@name='XGPushConfig']/method[@name='getToken' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("getToken", "(Landroid/content/Context;)Ljava/lang/String;", "")]
		public static unsafe string GetToken (global::Android.Content.Context p0)
		{
			const string __id = "getToken.(Landroid/content/Context;)Ljava/lang/String;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.android.tpush']/class[@name='XGPushConfig']/method[@name='isEnableDebug' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("isEnableDebug", "(Landroid/content/Context;)Z", "")]
		public static unsafe bool IsEnableDebug (global::Android.Content.Context p0)
		{
			const string __id = "isEnableDebug.(Landroid/content/Context;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.android.tpush']/class[@name='XGPushConfig']/method[@name='isForeiginPush' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("isForeiginPush", "(Landroid/content/Context;)Z", "")]
		public static unsafe bool IsForeiginPush (global::Android.Content.Context p0)
		{
			const string __id = "isForeiginPush.(Landroid/content/Context;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.android.tpush']/class[@name='XGPushConfig']/method[@name='isLocationEnable' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("isLocationEnable", "(Landroid/content/Context;)Z", "")]
		public static unsafe bool IsLocationEnable (global::Android.Content.Context p0)
		{
			const string __id = "isLocationEnable.(Landroid/content/Context;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.android.tpush']/class[@name='XGPushConfig']/method[@name='isReportApplistEnable' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("isReportApplistEnable", "(Landroid/content/Context;)Z", "")]
		public static unsafe bool IsReportApplistEnable (global::Android.Content.Context p0)
		{
			const string __id = "isReportApplistEnable.(Landroid/content/Context;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.android.tpush']/class[@name='XGPushConfig']/method[@name='isReportNotificationStatusEnable' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("isReportNotificationStatusEnable", "(Landroid/content/Context;)Z", "")]
		public static unsafe bool IsReportNotificationStatusEnable (global::Android.Content.Context p0)
		{
			const string __id = "isReportNotificationStatusEnable.(Landroid/content/Context;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.android.tpush']/class[@name='XGPushConfig']/method[@name='isUsedFcmPush' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("isUsedFcmPush", "(Landroid/content/Context;)Z", "")]
		public static unsafe bool IsUsedFcmPush (global::Android.Content.Context p0)
		{
			const string __id = "isUsedFcmPush.(Landroid/content/Context;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.android.tpush']/class[@name='XGPushConfig']/method[@name='isUsedOtherPush' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("isUsedOtherPush", "(Landroid/content/Context;)Z", "")]
		public static unsafe bool IsUsedOtherPush (global::Android.Content.Context p0)
		{
			const string __id = "isUsedOtherPush.(Landroid/content/Context;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.android.tpush']/class[@name='XGPushConfig']/method[@name='setAccessId' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='long']]"
		[Register ("setAccessId", "(Landroid/content/Context;J)V", "")]
		public static unsafe void SetAccessId (global::Android.Content.Context p0, long p1)
		{
			const string __id = "setAccessId.(Landroid/content/Context;J)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (p1);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.android.tpush']/class[@name='XGPushConfig']/method[@name='setAccessKey' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String']]"
		[Register ("setAccessKey", "(Landroid/content/Context;Ljava/lang/String;)V", "")]
		public static unsafe void SetAccessKey (global::Android.Content.Context p0, string p1)
		{
			const string __id = "setAccessKey.(Landroid/content/Context;Ljava/lang/String;)V";
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (native_p1);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.android.tpush']/class[@name='XGPushConfig']/method[@name='setForeiginPushEnable' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='boolean']]"
		[Register ("setForeiginPushEnable", "(Landroid/content/Context;Z)V", "")]
		public static unsafe void SetForeiginPushEnable (global::Android.Content.Context p0, bool p1)
		{
			const string __id = "setForeiginPushEnable.(Landroid/content/Context;Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (p1);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.android.tpush']/class[@name='XGPushConfig']/method[@name='setGameServer' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String']]"
		[Register ("setGameServer", "(Landroid/content/Context;Ljava/lang/String;)V", "")]
		public static unsafe void SetGameServer (global::Android.Content.Context p0, string p1)
		{
			const string __id = "setGameServer.(Landroid/content/Context;Ljava/lang/String;)V";
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (native_p1);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.android.tpush']/class[@name='XGPushConfig']/method[@name='setHeartbeatIntervalMs' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='int']]"
		[Register ("setHeartbeatIntervalMs", "(Landroid/content/Context;I)V", "")]
		public static unsafe void SetHeartbeatIntervalMs (global::Android.Content.Context p0, int p1)
		{
			const string __id = "setHeartbeatIntervalMs.(Landroid/content/Context;I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (p1);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.android.tpush']/class[@name='XGPushConfig']/method[@name='setInstallChannel' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String']]"
		[Register ("setInstallChannel", "(Landroid/content/Context;Ljava/lang/String;)V", "")]
		public static unsafe void SetInstallChannel (global::Android.Content.Context p0, string p1)
		{
			const string __id = "setInstallChannel.(Landroid/content/Context;Ljava/lang/String;)V";
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (native_p1);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.android.tpush']/class[@name='XGPushConfig']/method[@name='setLocationEnable' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='boolean']]"
		[Register ("setLocationEnable", "(Landroid/content/Context;Z)V", "")]
		public static unsafe void SetLocationEnable (global::Android.Content.Context p0, bool p1)
		{
			const string __id = "setLocationEnable.(Landroid/content/Context;Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (p1);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.android.tpush']/class[@name='XGPushConfig']/method[@name='setMiPushAppId' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String']]"
		[Register ("setMiPushAppId", "(Landroid/content/Context;Ljava/lang/String;)V", "")]
		public static unsafe void SetMiPushAppId (global::Android.Content.Context p0, string p1)
		{
			const string __id = "setMiPushAppId.(Landroid/content/Context;Ljava/lang/String;)V";
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (native_p1);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.android.tpush']/class[@name='XGPushConfig']/method[@name='setMiPushAppKey' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String']]"
		[Register ("setMiPushAppKey", "(Landroid/content/Context;Ljava/lang/String;)V", "")]
		public static unsafe void SetMiPushAppKey (global::Android.Content.Context p0, string p1)
		{
			const string __id = "setMiPushAppKey.(Landroid/content/Context;Ljava/lang/String;)V";
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (native_p1);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.android.tpush']/class[@name='XGPushConfig']/method[@name='setMzPushAppId' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String']]"
		[Register ("setMzPushAppId", "(Landroid/content/Context;Ljava/lang/String;)V", "")]
		public static unsafe void SetMzPushAppId (global::Android.Content.Context p0, string p1)
		{
			const string __id = "setMzPushAppId.(Landroid/content/Context;Ljava/lang/String;)V";
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (native_p1);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.android.tpush']/class[@name='XGPushConfig']/method[@name='setMzPushAppKey' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String']]"
		[Register ("setMzPushAppKey", "(Landroid/content/Context;Ljava/lang/String;)V", "")]
		public static unsafe void SetMzPushAppKey (global::Android.Content.Context p0, string p1)
		{
			const string __id = "setMzPushAppKey.(Landroid/content/Context;Ljava/lang/String;)V";
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (native_p1);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.android.tpush']/class[@name='XGPushConfig']/method[@name='setReportApplistEnable' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='boolean']]"
		[Register ("setReportApplistEnable", "(Landroid/content/Context;Z)V", "")]
		public static unsafe void SetReportApplistEnable (global::Android.Content.Context p0, bool p1)
		{
			const string __id = "setReportApplistEnable.(Landroid/content/Context;Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (p1);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.android.tpush']/class[@name='XGPushConfig']/method[@name='setReportDebugMode' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='boolean']]"
		[Register ("setReportDebugMode", "(Landroid/content/Context;Z)V", "")]
		public static unsafe void SetReportDebugMode (global::Android.Content.Context p0, bool p1)
		{
			const string __id = "setReportDebugMode.(Landroid/content/Context;Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (p1);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.android.tpush']/class[@name='XGPushConfig']/method[@name='setReportNotificationStatusEnable' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='boolean']]"
		[Register ("setReportNotificationStatusEnable", "(Landroid/content/Context;Z)V", "")]
		public static unsafe void SetReportNotificationStatusEnable (global::Android.Content.Context p0, bool p1)
		{
			const string __id = "setReportNotificationStatusEnable.(Landroid/content/Context;Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (p1);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.android.tpush']/class[@name='XGPushConfig']/method[@name='setfcmSenderId' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String']]"
		[Register ("setfcmSenderId", "(Landroid/content/Context;Ljava/lang/String;)V", "")]
		public static unsafe void SetfcmSenderId (global::Android.Content.Context p0, string p1)
		{
			const string __id = "setfcmSenderId.(Landroid/content/Context;Ljava/lang/String;)V";
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (native_p1);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

	}
}
