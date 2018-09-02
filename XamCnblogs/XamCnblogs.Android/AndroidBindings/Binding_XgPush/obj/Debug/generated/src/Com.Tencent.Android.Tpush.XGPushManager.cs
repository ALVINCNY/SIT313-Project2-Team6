using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Tencent.Android.Tpush {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.tencent.android.tpush']/class[@name='XGPushManager']"
	[global::Android.Runtime.Register ("com/tencent/android/tpush/XGPushManager", DoNotGenerateAcw=true)]
	public partial class XGPushManager : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.android.tpush']/class[@name='XGPushManager']/field[@name='ENABLE_SERVICE_SUFFIX']"
		[Register ("ENABLE_SERVICE_SUFFIX")]
		public const string EnableServiceSuffix = (string) ".enableService";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.android.tpush']/class[@name='XGPushManager']/field[@name='OPERATION_FAIL']"
		[Register ("OPERATION_FAIL")]
		public const int OperationFail = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.android.tpush']/class[@name='XGPushManager']/field[@name='OPERATION_REQ_REGISTER']"
		[Register ("OPERATION_REQ_REGISTER")]
		public const int OperationReqRegister = (int) 100;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.android.tpush']/class[@name='XGPushManager']/field[@name='OPERATION_REQ_UNREGISTER']"
		[Register ("OPERATION_REQ_UNREGISTER")]
		public const int OperationReqUnregister = (int) 101;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.android.tpush']/class[@name='XGPushManager']/field[@name='OPERATION_SUCCESS']"
		[Register ("OPERATION_SUCCESS")]
		public const int OperationSuccess = (int) 0;


		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.android.tpush']/class[@name='XGPushManager']/field[@name='lastSuccessRegisterMap']"
		[Register ("lastSuccessRegisterMap")]
		public static global::System.Collections.IDictionary LastSuccessRegisterMap {
			get {
				const string __id = "lastSuccessRegisterMap.Ljava/util/Map;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Android.Runtime.JavaDictionary.FromJniHandle (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "lastSuccessRegisterMap.Ljava/util/Map;";

				IntPtr native_value = global::Android.Runtime.JavaDictionary.ToLocalJniHandle (value);
				try {
					_members.StaticFields.SetValue (__id, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/tencent/android/tpush/XGPushManager", typeof (XGPushManager));
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

		protected XGPushManager (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		public static unsafe global::Android.Content.Context Context {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.android.tpush']/class[@name='XGPushManager']/method[@name='getContext' and count(parameter)=0]"
			[Register ("getContext", "()Landroid/content/Context;", "GetGetContextHandler")]
			get {
				const string __id = "getContext.()Landroid/content/Context;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return global::Java.Lang.Object.GetObject<global::Android.Content.Context> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.android.tpush']/class[@name='XGPushManager']/method[@name='setContext' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
			[Register ("setContext", "(Landroid/content/Context;)V", "GetSetContext_Landroid_content_Context_Handler")]
			set {
				const string __id = "setContext.(Landroid/content/Context;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.StaticMethods.InvokeVoidMethod (__id, __args);
				} finally {
				}
			}
		}

		public static unsafe global::Com.Tencent.Android.Tpush.IXGPushNotifactionCallback NotifactionCallback {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.android.tpush']/class[@name='XGPushManager']/method[@name='getNotifactionCallback' and count(parameter)=0]"
			[Register ("getNotifactionCallback", "()Lcom/tencent/android/tpush/XGPushNotifactionCallback;", "GetGetNotifactionCallbackHandler")]
			get {
				const string __id = "getNotifactionCallback.()Lcom/tencent/android/tpush/XGPushNotifactionCallback;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return global::Java.Lang.Object.GetObject<global::Com.Tencent.Android.Tpush.IXGPushNotifactionCallback> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.android.tpush']/class[@name='XGPushManager']/method[@name='setNotifactionCallback' and count(parameter)=1 and parameter[1][@type='com.tencent.android.tpush.XGPushNotifactionCallback']]"
			[Register ("setNotifactionCallback", "(Lcom/tencent/android/tpush/XGPushNotifactionCallback;)V", "GetSetNotifactionCallback_Lcom_tencent_android_tpush_XGPushNotifactionCallback_Handler")]
			set {
				const string __id = "setNotifactionCallback.(Lcom/tencent/android/tpush/XGPushNotifactionCallback;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.StaticMethods.InvokeVoidMethod (__id, __args);
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.android.tpush']/class[@name='XGPushManager']/method[@name='addLocalNotification' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='com.tencent.android.tpush.XGLocalMessage']]"
		[Register ("addLocalNotification", "(Landroid/content/Context;Lcom/tencent/android/tpush/XGLocalMessage;)J", "")]
		public static unsafe long AddLocalNotification (global::Android.Content.Context p0, global::Com.Tencent.Android.Tpush.XGLocalMessage p1)
		{
			const string __id = "addLocalNotification.(Landroid/content/Context;Lcom/tencent/android/tpush/XGLocalMessage;)J";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				var __rm = _members.StaticMethods.InvokeInt64Method (__id, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.android.tpush']/class[@name='XGPushManager']/method[@name='appendAccount' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String']]"
		[Register ("appendAccount", "(Landroid/content/Context;Ljava/lang/String;)V", "")]
		public static unsafe void AppendAccount (global::Android.Content.Context p0, string p1)
		{
			const string __id = "appendAccount.(Landroid/content/Context;Ljava/lang/String;)V";
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.android.tpush']/class[@name='XGPushManager']/method[@name='appendAccount' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='com.tencent.android.tpush.XGIOperateCallback']]"
		[Register ("appendAccount", "(Landroid/content/Context;Ljava/lang/String;Lcom/tencent/android/tpush/XGIOperateCallback;)V", "")]
		public static unsafe void AppendAccount (global::Android.Content.Context p0, string p1, global::Com.Tencent.Android.Tpush.IXGIOperateCallback p2)
		{
			const string __id = "appendAccount.(Landroid/content/Context;Ljava/lang/String;Lcom/tencent/android/tpush/XGIOperateCallback;)V";
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (native_p1);
				__args [2] = new JniArgumentValue ((p2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p2).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.android.tpush']/class[@name='XGPushManager']/method[@name='bindAccount' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String']]"
		[Register ("bindAccount", "(Landroid/content/Context;Ljava/lang/String;)V", "")]
		public static unsafe void BindAccount (global::Android.Content.Context p0, string p1)
		{
			const string __id = "bindAccount.(Landroid/content/Context;Ljava/lang/String;)V";
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.android.tpush']/class[@name='XGPushManager']/method[@name='bindAccount' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='com.tencent.android.tpush.XGIOperateCallback']]"
		[Register ("bindAccount", "(Landroid/content/Context;Ljava/lang/String;Lcom/tencent/android/tpush/XGIOperateCallback;)V", "")]
		public static unsafe void BindAccount (global::Android.Content.Context p0, string p1, global::Com.Tencent.Android.Tpush.IXGIOperateCallback p2)
		{
			const string __id = "bindAccount.(Landroid/content/Context;Ljava/lang/String;Lcom/tencent/android/tpush/XGIOperateCallback;)V";
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (native_p1);
				__args [2] = new JniArgumentValue ((p2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p2).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.android.tpush']/class[@name='XGPushManager']/method[@name='cancelAllNotifaction' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("cancelAllNotifaction", "(Landroid/content/Context;)V", "")]
		public static unsafe void CancelAllNotifaction (global::Android.Content.Context p0)
		{
			const string __id = "cancelAllNotifaction.(Landroid/content/Context;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.android.tpush']/class[@name='XGPushManager']/method[@name='cancelNotifaction' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='int']]"
		[Register ("cancelNotifaction", "(Landroid/content/Context;I)V", "")]
		public static unsafe void CancelNotifaction (global::Android.Content.Context p0, int p1)
		{
			const string __id = "cancelNotifaction.(Landroid/content/Context;I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (p1);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.android.tpush']/class[@name='XGPushManager']/method[@name='clearLocalNotifications' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("clearLocalNotifications", "(Landroid/content/Context;)V", "")]
		public static unsafe void ClearLocalNotifications (global::Android.Content.Context p0)
		{
			const string __id = "clearLocalNotifications.(Landroid/content/Context;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.android.tpush']/class[@name='XGPushManager']/method[@name='delAccount' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String']]"
		[Register ("delAccount", "(Landroid/content/Context;Ljava/lang/String;)V", "")]
		public static unsafe void DelAccount (global::Android.Content.Context p0, string p1)
		{
			const string __id = "delAccount.(Landroid/content/Context;Ljava/lang/String;)V";
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.android.tpush']/class[@name='XGPushManager']/method[@name='delAccount' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='com.tencent.android.tpush.XGIOperateCallback']]"
		[Register ("delAccount", "(Landroid/content/Context;Ljava/lang/String;Lcom/tencent/android/tpush/XGIOperateCallback;)V", "")]
		public static unsafe void DelAccount (global::Android.Content.Context p0, string p1, global::Com.Tencent.Android.Tpush.IXGIOperateCallback p2)
		{
			const string __id = "delAccount.(Landroid/content/Context;Ljava/lang/String;Lcom/tencent/android/tpush/XGIOperateCallback;)V";
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (native_p1);
				__args [2] = new JniArgumentValue ((p2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p2).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.android.tpush']/class[@name='XGPushManager']/method[@name='delAllAccount' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("delAllAccount", "(Landroid/content/Context;)V", "")]
		public static unsafe void DelAllAccount (global::Android.Content.Context p0)
		{
			const string __id = "delAllAccount.(Landroid/content/Context;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.android.tpush']/class[@name='XGPushManager']/method[@name='delAllAccount' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='com.tencent.android.tpush.XGIOperateCallback']]"
		[Register ("delAllAccount", "(Landroid/content/Context;Lcom/tencent/android/tpush/XGIOperateCallback;)V", "")]
		public static unsafe void DelAllAccount (global::Android.Content.Context p0, global::Com.Tencent.Android.Tpush.IXGIOperateCallback p1)
		{
			const string __id = "delAllAccount.(Landroid/content/Context;Lcom/tencent/android/tpush/XGIOperateCallback;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.android.tpush']/class[@name='XGPushManager']/method[@name='deleteKeyValueTag' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
		[Register ("deleteKeyValueTag", "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;)V", "")]
		public static unsafe void DeleteKeyValueTag (global::Android.Content.Context p0, string p1, string p2)
		{
			const string __id = "deleteKeyValueTag.(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;)V";
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (native_p1);
				__args [2] = new JniArgumentValue (native_p2);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.android.tpush']/class[@name='XGPushManager']/method[@name='deleteTag' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String']]"
		[Register ("deleteTag", "(Landroid/content/Context;Ljava/lang/String;)V", "")]
		public static unsafe void DeleteTag (global::Android.Content.Context p0, string p1)
		{
			const string __id = "deleteTag.(Landroid/content/Context;Ljava/lang/String;)V";
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.android.tpush']/class[@name='XGPushManager']/method[@name='enableService' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='boolean']]"
		[Register ("enableService", "(Landroid/content/Context;Z)V", "")]
		public static unsafe void EnableService (global::Android.Content.Context p0, bool p1)
		{
			const string __id = "enableService.(Landroid/content/Context;Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (p1);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.android.tpush']/class[@name='XGPushManager']/method[@name='getServiceStatus' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("getServiceStatus", "(Landroid/content/Context;)I", "")]
		public static unsafe int GetServiceStatus (global::Android.Content.Context p0)
		{
			const string __id = "getServiceStatus.(Landroid/content/Context;)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.android.tpush']/class[@name='XGPushManager']/method[@name='getServiceTag' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("getServiceTag", "(Landroid/content/Context;)Ljava/lang/String;", "")]
		public static unsafe string GetServiceTag (global::Android.Content.Context p0)
		{
			const string __id = "getServiceTag.(Landroid/content/Context;)Ljava/lang/String;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.android.tpush']/class[@name='XGPushManager']/method[@name='isNotificationOpened' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("isNotificationOpened", "(Landroid/content/Context;)Z", "")]
		public static unsafe bool IsNotificationOpened (global::Android.Content.Context p0)
		{
			const string __id = "isNotificationOpened.(Landroid/content/Context;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.android.tpush']/class[@name='XGPushManager']/method[@name='onActivityStarted' and count(parameter)=1 and parameter[1][@type='android.app.Activity']]"
		[Register ("onActivityStarted", "(Landroid/app/Activity;)Lcom/tencent/android/tpush/XGPushClickedResult;", "")]
		public static unsafe global::Com.Tencent.Android.Tpush.XGPushClickedResult OnActivityStarted (global::Android.App.Activity p0)
		{
			const string __id = "onActivityStarted.(Landroid/app/Activity;)Lcom/tencent/android/tpush/XGPushClickedResult;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Tencent.Android.Tpush.XGPushClickedResult> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.android.tpush']/class[@name='XGPushManager']/method[@name='onActivityStoped' and count(parameter)=1 and parameter[1][@type='android.app.Activity']]"
		[Register ("onActivityStoped", "(Landroid/app/Activity;)V", "")]
		public static unsafe void OnActivityStoped (global::Android.App.Activity p0)
		{
			const string __id = "onActivityStoped.(Landroid/app/Activity;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.android.tpush']/class[@name='XGPushManager']/method[@name='onMessageCleared' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='com.tencent.android.tpush.XGPushTextMessage']]"
		[Register ("onMessageCleared", "(Landroid/content/Context;Lcom/tencent/android/tpush/XGPushTextMessage;)V", "")]
		public static unsafe void OnMessageCleared (global::Android.Content.Context p0, global::Com.Tencent.Android.Tpush.XGPushTextMessage p1)
		{
			const string __id = "onMessageCleared.(Landroid/content/Context;Lcom/tencent/android/tpush/XGPushTextMessage;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.android.tpush']/class[@name='XGPushManager']/method[@name='onMessageClicked' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='com.tencent.android.tpush.XGPushTextMessage']]"
		[Register ("onMessageClicked", "(Landroid/content/Context;Lcom/tencent/android/tpush/XGPushTextMessage;)V", "")]
		public static unsafe void OnMessageClicked (global::Android.Content.Context p0, global::Com.Tencent.Android.Tpush.XGPushTextMessage p1)
		{
			const string __id = "onMessageClicked.(Landroid/content/Context;Lcom/tencent/android/tpush/XGPushTextMessage;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.android.tpush']/class[@name='XGPushManager']/method[@name='openNotification' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("openNotification", "(Landroid/content/Context;)V", "")]
		public static unsafe void OpenNotification (global::Android.Content.Context p0)
		{
			const string __id = "openNotification.(Landroid/content/Context;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.android.tpush']/class[@name='XGPushManager']/method[@name='openNotificationSettings' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("openNotificationSettings", "(Landroid/content/Context;)V", "")]
		public static unsafe void OpenNotificationSettings (global::Android.Content.Context p0)
		{
			const string __id = "openNotificationSettings.(Landroid/content/Context;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.android.tpush']/class[@name='XGPushManager']/method[@name='registerPush' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("registerPush", "(Landroid/content/Context;)V", "")]
		public static unsafe void RegisterPush (global::Android.Content.Context p0)
		{
			const string __id = "registerPush.(Landroid/content/Context;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.android.tpush']/class[@name='XGPushManager']/method[@name='registerPush' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='com.tencent.android.tpush.XGIOperateCallback']]"
		[Register ("registerPush", "(Landroid/content/Context;Lcom/tencent/android/tpush/XGIOperateCallback;)V", "")]
		public static unsafe void RegisterPush (global::Android.Content.Context p0, global::Com.Tencent.Android.Tpush.IXGIOperateCallback p1)
		{
			const string __id = "registerPush.(Landroid/content/Context;Lcom/tencent/android/tpush/XGIOperateCallback;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.android.tpush']/class[@name='XGPushManager']/method[@name='registerPush' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String']]"
		[Register ("registerPush", "(Landroid/content/Context;Ljava/lang/String;)V", "")]
		public static unsafe void RegisterPush (global::Android.Content.Context p0, string p1)
		{
			const string __id = "registerPush.(Landroid/content/Context;Ljava/lang/String;)V";
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.android.tpush']/class[@name='XGPushManager']/method[@name='registerPush' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='com.tencent.android.tpush.XGIOperateCallback']]"
		[Register ("registerPush", "(Landroid/content/Context;Ljava/lang/String;Lcom/tencent/android/tpush/XGIOperateCallback;)V", "")]
		public static unsafe void RegisterPush (global::Android.Content.Context p0, string p1, global::Com.Tencent.Android.Tpush.IXGIOperateCallback p2)
		{
			const string __id = "registerPush.(Landroid/content/Context;Ljava/lang/String;Lcom/tencent/android/tpush/XGIOperateCallback;)V";
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (native_p1);
				__args [2] = new JniArgumentValue ((p2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p2).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.android.tpush']/class[@name='XGPushManager']/method[@name='registerPush' and count(parameter)=6 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='int'] and parameter[5][@type='java.lang.String'] and parameter[6][@type='com.tencent.android.tpush.XGIOperateCallback']]"
		[Register ("registerPush", "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;ILjava/lang/String;Lcom/tencent/android/tpush/XGIOperateCallback;)V", "")]
		public static unsafe void RegisterPush (global::Android.Content.Context p0, string p1, string p2, int p3, string p4, global::Com.Tencent.Android.Tpush.IXGIOperateCallback p5)
		{
			const string __id = "registerPush.(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;ILjava/lang/String;Lcom/tencent/android/tpush/XGIOperateCallback;)V";
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			IntPtr native_p4 = JNIEnv.NewString (p4);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [6];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (native_p1);
				__args [2] = new JniArgumentValue (native_p2);
				__args [3] = new JniArgumentValue (p3);
				__args [4] = new JniArgumentValue (native_p4);
				__args [5] = new JniArgumentValue ((p5 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p5).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
				JNIEnv.DeleteLocalRef (native_p4);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.android.tpush']/class[@name='XGPushManager']/method[@name='sendCommReport2Service' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
		[Register ("sendCommReport2Service", "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;)V", "")]
		public static unsafe void SendCommReport2Service (global::Android.Content.Context p0, string p1, string p2)
		{
			const string __id = "sendCommReport2Service.(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;)V";
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (native_p1);
				__args [2] = new JniArgumentValue (native_p2);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.android.tpush']/class[@name='XGPushManager']/method[@name='setKeyValueTag' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
		[Register ("setKeyValueTag", "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;)V", "")]
		public static unsafe void SetKeyValueTag (global::Android.Content.Context p0, string p1, string p2)
		{
			const string __id = "setKeyValueTag.(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;)V";
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (native_p1);
				__args [2] = new JniArgumentValue (native_p2);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.android.tpush']/class[@name='XGPushManager']/method[@name='setTag' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String']]"
		[Register ("setTag", "(Landroid/content/Context;Ljava/lang/String;)V", "")]
		public static unsafe void SetTag (global::Android.Content.Context p0, string p1)
		{
			const string __id = "setTag.(Landroid/content/Context;Ljava/lang/String;)V";
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.android.tpush']/class[@name='XGPushManager']/method[@name='startPushService' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("startPushService", "(Landroid/content/Context;)V", "")]
		public static unsafe void StartPushService (global::Android.Content.Context p0)
		{
			const string __id = "startPushService.(Landroid/content/Context;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.android.tpush']/class[@name='XGPushManager']/method[@name='unregisterPush' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("unregisterPush", "(Landroid/content/Context;)V", "")]
		public static unsafe void UnregisterPush (global::Android.Content.Context p0)
		{
			const string __id = "unregisterPush.(Landroid/content/Context;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.android.tpush']/class[@name='XGPushManager']/method[@name='unregisterPush' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='com.tencent.android.tpush.XGIOperateCallback']]"
		[Register ("unregisterPush", "(Landroid/content/Context;Lcom/tencent/android/tpush/XGIOperateCallback;)V", "")]
		public static unsafe void UnregisterPush (global::Android.Content.Context p0, global::Com.Tencent.Android.Tpush.IXGIOperateCallback p1)
		{
			const string __id = "unregisterPush.(Landroid/content/Context;Lcom/tencent/android/tpush/XGIOperateCallback;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
			}
		}

	}
}
