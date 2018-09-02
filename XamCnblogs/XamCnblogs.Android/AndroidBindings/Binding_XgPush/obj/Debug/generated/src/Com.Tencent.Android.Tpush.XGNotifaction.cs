using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Tencent.Android.Tpush {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.tencent.android.tpush']/class[@name='XGNotifaction']"
	[global::Android.Runtime.Register ("com/tencent/android/tpush/XGNotifaction", DoNotGenerateAcw=true)]
	public partial class XGNotifaction : global::Java.Lang.Object {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/tencent/android/tpush/XGNotifaction", typeof (XGNotifaction));
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

		protected XGNotifaction (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

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
			global::Com.Tencent.Android.Tpush.XGNotifaction __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Android.Tpush.XGNotifaction> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Content);
		}
#pragma warning restore 0169

		public virtual unsafe string Content {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.android.tpush']/class[@name='XGNotifaction']/method[@name='getContent' and count(parameter)=0]"
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
			global::Com.Tencent.Android.Tpush.XGNotifaction __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Android.Tpush.XGNotifaction> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.CustomContent);
		}
#pragma warning restore 0169

		public virtual unsafe string CustomContent {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.android.tpush']/class[@name='XGNotifaction']/method[@name='getCustomContent' and count(parameter)=0]"
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

		static Delegate cb_getNotifaction;
#pragma warning disable 0169
		static Delegate GetGetNotifactionHandler ()
		{
			if (cb_getNotifaction == null)
				cb_getNotifaction = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetNotifaction);
			return cb_getNotifaction;
		}

		static IntPtr n_GetNotifaction (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Tencent.Android.Tpush.XGNotifaction __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Android.Tpush.XGNotifaction> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Notifaction);
		}
#pragma warning restore 0169

		public virtual unsafe global::Android.App.Notification Notifaction {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.android.tpush']/class[@name='XGNotifaction']/method[@name='getNotifaction' and count(parameter)=0]"
			[Register ("getNotifaction", "()Landroid/app/Notification;", "GetGetNotifactionHandler")]
			get {
				const string __id = "getNotifaction.()Landroid/app/Notification;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Android.App.Notification> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getNotifyId;
#pragma warning disable 0169
		static Delegate GetGetNotifyIdHandler ()
		{
			if (cb_getNotifyId == null)
				cb_getNotifyId = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetNotifyId);
			return cb_getNotifyId;
		}

		static int n_GetNotifyId (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Tencent.Android.Tpush.XGNotifaction __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Android.Tpush.XGNotifaction> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.NotifyId;
		}
#pragma warning restore 0169

		static Delegate cb_setNotifyId_I;
#pragma warning disable 0169
		static Delegate GetSetNotifyId_IHandler ()
		{
			if (cb_setNotifyId_I == null)
				cb_setNotifyId_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetNotifyId_I);
			return cb_setNotifyId_I;
		}

		static void n_SetNotifyId_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Tencent.Android.Tpush.XGNotifaction __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Android.Tpush.XGNotifaction> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.NotifyId = p0;
		}
#pragma warning restore 0169

		public virtual unsafe int NotifyId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.android.tpush']/class[@name='XGNotifaction']/method[@name='getNotifyId' and count(parameter)=0]"
			[Register ("getNotifyId", "()I", "GetGetNotifyIdHandler")]
			get {
				const string __id = "getNotifyId.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.android.tpush']/class[@name='XGNotifaction']/method[@name='setNotifyId' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setNotifyId", "(I)V", "GetSetNotifyId_IHandler")]
			set {
				const string __id = "setNotifyId.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
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
			global::Com.Tencent.Android.Tpush.XGNotifaction __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Android.Tpush.XGNotifaction> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Title);
		}
#pragma warning restore 0169

		public virtual unsafe string Title {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.android.tpush']/class[@name='XGNotifaction']/method[@name='getTitle' and count(parameter)=0]"
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

		static Delegate cb_doNotify;
#pragma warning disable 0169
		static Delegate GetDoNotifyHandler ()
		{
			if (cb_doNotify == null)
				cb_doNotify = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_DoNotify);
			return cb_doNotify;
		}

		static bool n_DoNotify (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Tencent.Android.Tpush.XGNotifaction __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Android.Tpush.XGNotifaction> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DoNotify ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.android.tpush']/class[@name='XGNotifaction']/method[@name='doNotify' and count(parameter)=0]"
		[Register ("doNotify", "()Z", "GetDoNotifyHandler")]
		public virtual unsafe bool DoNotify ()
		{
			const string __id = "doNotify.()Z";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
				return __rm;
			} finally {
			}
		}

	}
}
