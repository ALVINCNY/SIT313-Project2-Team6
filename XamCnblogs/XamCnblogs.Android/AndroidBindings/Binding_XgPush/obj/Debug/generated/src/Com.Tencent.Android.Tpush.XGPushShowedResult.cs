using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Tencent.Android.Tpush {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.tencent.android.tpush']/class[@name='XGPushShowedResult']"
	[global::Android.Runtime.Register ("com/tencent/android/tpush/XGPushShowedResult", DoNotGenerateAcw=true)]
	public partial class XGPushShowedResult : global::Java.Lang.Object, global::Com.Tencent.Android.Tpush.IXGIResult {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.android.tpush']/class[@name='XGPushShowedResult']/field[@name='NOTIFICATION_ACTION_ACTIVITY']"
		[Register ("NOTIFICATION_ACTION_ACTIVITY")]
		public const int NotificationActionActivity = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.android.tpush']/class[@name='XGPushShowedResult']/field[@name='NOTIFICATION_ACTION_INTENT']"
		[Register ("NOTIFICATION_ACTION_INTENT")]
		public const int NotificationActionIntent = (int) 3;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.android.tpush']/class[@name='XGPushShowedResult']/field[@name='NOTIFICATION_ACTION_PACKAGE']"
		[Register ("NOTIFICATION_ACTION_PACKAGE")]
		public const int NotificationActionPackage = (int) 4;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.android.tpush']/class[@name='XGPushShowedResult']/field[@name='NOTIFICATION_ACTION_URL']"
		[Register ("NOTIFICATION_ACTION_URL")]
		public const int NotificationActionUrl = (int) 2;
		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/tencent/android/tpush/XGPushShowedResult", typeof (XGPushShowedResult));
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

		protected XGPushShowedResult (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.tencent.android.tpush']/class[@name='XGPushShowedResult']/constructor[@name='XGPushShowedResult' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe XGPushShowedResult ()
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

		static Delegate cb_getActivity;
#pragma warning disable 0169
		static Delegate GetGetActivityHandler ()
		{
			if (cb_getActivity == null)
				cb_getActivity = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetActivity);
			return cb_getActivity;
		}

		static IntPtr n_GetActivity (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Tencent.Android.Tpush.XGPushShowedResult __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Android.Tpush.XGPushShowedResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Activity);
		}
#pragma warning restore 0169

		public virtual unsafe string Activity {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.android.tpush']/class[@name='XGPushShowedResult']/method[@name='getActivity' and count(parameter)=0]"
			[Register ("getActivity", "()Ljava/lang/String;", "GetGetActivityHandler")]
			get {
				const string __id = "getActivity.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getContent;
#pragma warning disable 0169
		static Delegate GetGetContentHandler ()
		{
			if (cb_getContent == null)
				cb_getContent = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetContent);
			return cb_getContent;
		}

		static IntPtr n_GetContent (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Tencent.Android.Tpush.XGPushShowedResult __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Android.Tpush.XGPushShowedResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Content);
		}
#pragma warning restore 0169

		public virtual unsafe string Content {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.android.tpush']/class[@name='XGPushShowedResult']/method[@name='getContent' and count(parameter)=0]"
			[Register ("getContent", "()Ljava/lang/String;", "GetGetContentHandler")]
			get {
				const string __id = "getContent.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getCustomContent;
#pragma warning disable 0169
		static Delegate GetGetCustomContentHandler ()
		{
			if (cb_getCustomContent == null)
				cb_getCustomContent = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCustomContent);
			return cb_getCustomContent;
		}

		static IntPtr n_GetCustomContent (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Tencent.Android.Tpush.XGPushShowedResult __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Android.Tpush.XGPushShowedResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.CustomContent);
		}
#pragma warning restore 0169

		public virtual unsafe string CustomContent {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.android.tpush']/class[@name='XGPushShowedResult']/method[@name='getCustomContent' and count(parameter)=0]"
			[Register ("getCustomContent", "()Ljava/lang/String;", "GetGetCustomContentHandler")]
			get {
				const string __id = "getCustomContent.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getMsgId;
#pragma warning disable 0169
		static Delegate GetGetMsgIdHandler ()
		{
			if (cb_getMsgId == null)
				cb_getMsgId = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetMsgId);
			return cb_getMsgId;
		}

		static long n_GetMsgId (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Tencent.Android.Tpush.XGPushShowedResult __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Android.Tpush.XGPushShowedResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.MsgId;
		}
#pragma warning restore 0169

		public virtual unsafe long MsgId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.android.tpush']/class[@name='XGPushShowedResult']/method[@name='getMsgId' and count(parameter)=0]"
			[Register ("getMsgId", "()J", "GetGetMsgIdHandler")]
			get {
				const string __id = "getMsgId.()J";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt64Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getNotifactionId;
#pragma warning disable 0169
		static Delegate GetGetNotifactionIdHandler ()
		{
			if (cb_getNotifactionId == null)
				cb_getNotifactionId = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetNotifactionId);
			return cb_getNotifactionId;
		}

		static int n_GetNotifactionId (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Tencent.Android.Tpush.XGPushShowedResult __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Android.Tpush.XGPushShowedResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.NotifactionId;
		}
#pragma warning restore 0169

		public virtual unsafe int NotifactionId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.android.tpush']/class[@name='XGPushShowedResult']/method[@name='getNotifactionId' and count(parameter)=0]"
			[Register ("getNotifactionId", "()I", "GetGetNotifactionIdHandler")]
			get {
				const string __id = "getNotifactionId.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getNotificationActionType;
#pragma warning disable 0169
		static Delegate GetGetNotificationActionTypeHandler ()
		{
			if (cb_getNotificationActionType == null)
				cb_getNotificationActionType = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetNotificationActionType);
			return cb_getNotificationActionType;
		}

		static int n_GetNotificationActionType (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Tencent.Android.Tpush.XGPushShowedResult __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Android.Tpush.XGPushShowedResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.NotificationActionType;
		}
#pragma warning restore 0169

		public virtual unsafe int NotificationActionType {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.android.tpush']/class[@name='XGPushShowedResult']/method[@name='getNotificationActionType' and count(parameter)=0]"
			[Register ("getNotificationActionType", "()I", "GetGetNotificationActionTypeHandler")]
			get {
				const string __id = "getNotificationActionType.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getTitle;
#pragma warning disable 0169
		static Delegate GetGetTitleHandler ()
		{
			if (cb_getTitle == null)
				cb_getTitle = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetTitle);
			return cb_getTitle;
		}

		static IntPtr n_GetTitle (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Tencent.Android.Tpush.XGPushShowedResult __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Android.Tpush.XGPushShowedResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Title);
		}
#pragma warning restore 0169

		public virtual unsafe string Title {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.android.tpush']/class[@name='XGPushShowedResult']/method[@name='getTitle' and count(parameter)=0]"
			[Register ("getTitle", "()Ljava/lang/String;", "GetGetTitleHandler")]
			get {
				const string __id = "getTitle.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_parseIntent_Landroid_content_Intent_;
#pragma warning disable 0169
		static Delegate GetParseIntent_Landroid_content_Intent_Handler ()
		{
			if (cb_parseIntent_Landroid_content_Intent_ == null)
				cb_parseIntent_Landroid_content_Intent_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_ParseIntent_Landroid_content_Intent_);
			return cb_parseIntent_Landroid_content_Intent_;
		}

		static void n_ParseIntent_Landroid_content_Intent_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Tencent.Android.Tpush.XGPushShowedResult __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Android.Tpush.XGPushShowedResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Intent p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Intent> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ParseIntent (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.android.tpush']/class[@name='XGPushShowedResult']/method[@name='parseIntent' and count(parameter)=1 and parameter[1][@type='android.content.Intent']]"
		[Register ("parseIntent", "(Landroid/content/Intent;)V", "GetParseIntent_Landroid_content_Intent_Handler")]
		public virtual unsafe void ParseIntent (global::Android.Content.Intent p0)
		{
			const string __id = "parseIntent.(Landroid/content/Intent;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

	}
}
