using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Tencent.Android.Tpush {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.tencent.android.tpush']/class[@name='XGPush4Msdk']"
	[global::Android.Runtime.Register ("com/tencent/android/tpush/XGPush4Msdk", DoNotGenerateAcw=true)]
	public partial class XGPush4Msdk : global::Java.Lang.Object {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/tencent/android/tpush/XGPush4Msdk", typeof (XGPush4Msdk));
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

		protected XGPush4Msdk (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.tencent.android.tpush']/class[@name='XGPush4Msdk']/constructor[@name='XGPush4Msdk' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe XGPush4Msdk ()
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.android.tpush']/class[@name='XGPush4Msdk']/method[@name='addLocalNotification' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='com.tencent.android.tpush.XGLocalMessage']]"
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.android.tpush']/class[@name='XGPush4Msdk']/method[@name='deleteTag' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String']]"
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.android.tpush']/class[@name='XGPush4Msdk']/method[@name='getDebugServerInfo' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("getDebugServerInfo", "(Landroid/content/Context;)Ljava/lang/String;", "")]
		public static unsafe string GetDebugServerInfo (global::Android.Content.Context p0)
		{
			const string __id = "getDebugServerInfo.(Landroid/content/Context;)Ljava/lang/String;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.android.tpush']/class[@name='XGPush4Msdk']/method[@name='getQQAccessId' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("getQQAccessId", "(Landroid/content/Context;)J", "")]
		public static unsafe long GetQQAccessId (global::Android.Content.Context p0)
		{
			const string __id = "getQQAccessId.(Landroid/content/Context;)J";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.StaticMethods.InvokeInt64Method (__id, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.android.tpush']/class[@name='XGPush4Msdk']/method[@name='getQQAppKey' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("getQQAppKey", "(Landroid/content/Context;)Ljava/lang/String;", "")]
		public static unsafe string GetQQAppKey (global::Android.Content.Context p0)
		{
			const string __id = "getQQAppKey.(Landroid/content/Context;)Ljava/lang/String;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.android.tpush']/class[@name='XGPush4Msdk']/method[@name='registerPush' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='com.tencent.android.tpush.XGIOperateCallback']]"
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.android.tpush']/class[@name='XGPush4Msdk']/method[@name='setDebugServerInfo' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='int']]"
		[Register ("setDebugServerInfo", "(Landroid/content/Context;Ljava/lang/String;I)V", "")]
		public static unsafe void SetDebugServerInfo (global::Android.Content.Context p0, string p1, int p2)
		{
			const string __id = "setDebugServerInfo.(Landroid/content/Context;Ljava/lang/String;I)V";
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (native_p1);
				__args [2] = new JniArgumentValue (p2);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.android.tpush']/class[@name='XGPush4Msdk']/method[@name='setQQAppId' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='long']]"
		[Register ("setQQAppId", "(Landroid/content/Context;J)V", "")]
		public static unsafe void SetQQAppId (global::Android.Content.Context p0, long p1)
		{
			const string __id = "setQQAppId.(Landroid/content/Context;J)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (p1);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.android.tpush']/class[@name='XGPush4Msdk']/method[@name='setQQAppKey' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String']]"
		[Register ("setQQAppKey", "(Landroid/content/Context;Ljava/lang/String;)V", "")]
		public static unsafe void SetQQAppKey (global::Android.Content.Context p0, string p1)
		{
			const string __id = "setQQAppKey.(Landroid/content/Context;Ljava/lang/String;)V";
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.android.tpush']/class[@name='XGPush4Msdk']/method[@name='setTag' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String']]"
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.android.tpush']/class[@name='XGPush4Msdk']/method[@name='unregisterPush' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='com.tencent.android.tpush.XGIOperateCallback']]"
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
