using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Tencent.Android.Tpush {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.tencent.android.tpush']/class[@name='XGPushTextMessage']"
	[global::Android.Runtime.Register ("com/tencent/android/tpush/XGPushTextMessage", DoNotGenerateAcw=true)]
	public partial class XGPushTextMessage : global::Java.Lang.Object, global::Java.IO.ISerializable {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/tencent/android/tpush/XGPushTextMessage", typeof (XGPushTextMessage));
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

		protected XGPushTextMessage (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.tencent.android.tpush']/class[@name='XGPushTextMessage']/constructor[@name='XGPushTextMessage' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe XGPushTextMessage ()
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
			global::Com.Tencent.Android.Tpush.XGPushTextMessage __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Android.Tpush.XGPushTextMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Content);
		}
#pragma warning restore 0169

		public virtual unsafe string Content {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.android.tpush']/class[@name='XGPushTextMessage']/method[@name='getContent' and count(parameter)=0]"
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
			global::Com.Tencent.Android.Tpush.XGPushTextMessage __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Android.Tpush.XGPushTextMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.CustomContent);
		}
#pragma warning restore 0169

		public virtual unsafe string CustomContent {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.android.tpush']/class[@name='XGPushTextMessage']/method[@name='getCustomContent' and count(parameter)=0]"
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
			global::Com.Tencent.Android.Tpush.XGPushTextMessage __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Android.Tpush.XGPushTextMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Title);
		}
#pragma warning restore 0169

		public virtual unsafe string Title {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.android.tpush']/class[@name='XGPushTextMessage']/method[@name='getTitle' and count(parameter)=0]"
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

	}
}
