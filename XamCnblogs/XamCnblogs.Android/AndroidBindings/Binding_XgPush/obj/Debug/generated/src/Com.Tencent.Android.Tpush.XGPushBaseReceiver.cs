using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Tencent.Android.Tpush {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.tencent.android.tpush']/class[@name='XGPushBaseReceiver']"
	[global::Android.Runtime.Register ("com/tencent/android/tpush/XGPushBaseReceiver", DoNotGenerateAcw=true)]
	public abstract partial class XGPushBaseReceiver : global::Android.Content.BroadcastReceiver {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.android.tpush']/class[@name='XGPushBaseReceiver']/field[@name='SUCCESS']"
		[Register ("SUCCESS")]
		public const int Success = (int) 0;
		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/tencent/android/tpush/XGPushBaseReceiver", typeof (XGPushBaseReceiver));
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

		protected XGPushBaseReceiver (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.tencent.android.tpush']/class[@name='XGPushBaseReceiver']/constructor[@name='XGPushBaseReceiver' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe XGPushBaseReceiver ()
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

		static Delegate cb_onDeleteTagResult_Landroid_content_Context_ILjava_lang_String_;
#pragma warning disable 0169
		static Delegate GetOnDeleteTagResult_Landroid_content_Context_ILjava_lang_String_Handler ()
		{
			if (cb_onDeleteTagResult_Landroid_content_Context_ILjava_lang_String_ == null)
				cb_onDeleteTagResult_Landroid_content_Context_ILjava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int, IntPtr>) n_OnDeleteTagResult_Landroid_content_Context_ILjava_lang_String_);
			return cb_onDeleteTagResult_Landroid_content_Context_ILjava_lang_String_;
		}

		static void n_OnDeleteTagResult_Landroid_content_Context_ILjava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, IntPtr native_p2)
		{
			global::Com.Tencent.Android.Tpush.XGPushBaseReceiver __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Android.Tpush.XGPushBaseReceiver> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.OnDeleteTagResult (p0, p1, p2);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.android.tpush']/class[@name='XGPushBaseReceiver']/method[@name='onDeleteTagResult' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='int'] and parameter[3][@type='java.lang.String']]"
		[Register ("onDeleteTagResult", "(Landroid/content/Context;ILjava/lang/String;)V", "GetOnDeleteTagResult_Landroid_content_Context_ILjava_lang_String_Handler")]
		public abstract void OnDeleteTagResult (global::Android.Content.Context p0, int p1, string p2);

		static Delegate cb_onNotifactionClickedResult_Landroid_content_Context_Lcom_tencent_android_tpush_XGPushClickedResult_;
#pragma warning disable 0169
		static Delegate GetOnNotifactionClickedResult_Landroid_content_Context_Lcom_tencent_android_tpush_XGPushClickedResult_Handler ()
		{
			if (cb_onNotifactionClickedResult_Landroid_content_Context_Lcom_tencent_android_tpush_XGPushClickedResult_ == null)
				cb_onNotifactionClickedResult_Landroid_content_Context_Lcom_tencent_android_tpush_XGPushClickedResult_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnNotifactionClickedResult_Landroid_content_Context_Lcom_tencent_android_tpush_XGPushClickedResult_);
			return cb_onNotifactionClickedResult_Landroid_content_Context_Lcom_tencent_android_tpush_XGPushClickedResult_;
		}

		static void n_OnNotifactionClickedResult_Landroid_content_Context_Lcom_tencent_android_tpush_XGPushClickedResult_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Tencent.Android.Tpush.XGPushBaseReceiver __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Android.Tpush.XGPushBaseReceiver> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Tencent.Android.Tpush.XGPushClickedResult p1 = global::Java.Lang.Object.GetObject<global::Com.Tencent.Android.Tpush.XGPushClickedResult> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.OnNotifactionClickedResult (p0, p1);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.android.tpush']/class[@name='XGPushBaseReceiver']/method[@name='onNotifactionClickedResult' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='com.tencent.android.tpush.XGPushClickedResult']]"
		[Register ("onNotifactionClickedResult", "(Landroid/content/Context;Lcom/tencent/android/tpush/XGPushClickedResult;)V", "GetOnNotifactionClickedResult_Landroid_content_Context_Lcom_tencent_android_tpush_XGPushClickedResult_Handler")]
		public abstract void OnNotifactionClickedResult (global::Android.Content.Context p0, global::Com.Tencent.Android.Tpush.XGPushClickedResult p1);

		static Delegate cb_onNotifactionShowedResult_Landroid_content_Context_Lcom_tencent_android_tpush_XGPushShowedResult_;
#pragma warning disable 0169
		static Delegate GetOnNotifactionShowedResult_Landroid_content_Context_Lcom_tencent_android_tpush_XGPushShowedResult_Handler ()
		{
			if (cb_onNotifactionShowedResult_Landroid_content_Context_Lcom_tencent_android_tpush_XGPushShowedResult_ == null)
				cb_onNotifactionShowedResult_Landroid_content_Context_Lcom_tencent_android_tpush_XGPushShowedResult_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnNotifactionShowedResult_Landroid_content_Context_Lcom_tencent_android_tpush_XGPushShowedResult_);
			return cb_onNotifactionShowedResult_Landroid_content_Context_Lcom_tencent_android_tpush_XGPushShowedResult_;
		}

		static void n_OnNotifactionShowedResult_Landroid_content_Context_Lcom_tencent_android_tpush_XGPushShowedResult_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Tencent.Android.Tpush.XGPushBaseReceiver __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Android.Tpush.XGPushBaseReceiver> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Tencent.Android.Tpush.XGPushShowedResult p1 = global::Java.Lang.Object.GetObject<global::Com.Tencent.Android.Tpush.XGPushShowedResult> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.OnNotifactionShowedResult (p0, p1);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.android.tpush']/class[@name='XGPushBaseReceiver']/method[@name='onNotifactionShowedResult' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='com.tencent.android.tpush.XGPushShowedResult']]"
		[Register ("onNotifactionShowedResult", "(Landroid/content/Context;Lcom/tencent/android/tpush/XGPushShowedResult;)V", "GetOnNotifactionShowedResult_Landroid_content_Context_Lcom_tencent_android_tpush_XGPushShowedResult_Handler")]
		public abstract void OnNotifactionShowedResult (global::Android.Content.Context p0, global::Com.Tencent.Android.Tpush.XGPushShowedResult p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.android.tpush']/class[@name='XGPushBaseReceiver']/method[@name='onReceive' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.content.Intent']]"
		[Register ("onReceive", "(Landroid/content/Context;Landroid/content/Intent;)V", "")]
		public override sealed unsafe void OnReceive (global::Android.Content.Context p0, global::Android.Content.Intent p1)
		{
			const string __id = "onReceive.(Landroid/content/Context;Landroid/content/Intent;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_onRegisterResult_Landroid_content_Context_ILcom_tencent_android_tpush_XGPushRegisterResult_;
#pragma warning disable 0169
		static Delegate GetOnRegisterResult_Landroid_content_Context_ILcom_tencent_android_tpush_XGPushRegisterResult_Handler ()
		{
			if (cb_onRegisterResult_Landroid_content_Context_ILcom_tencent_android_tpush_XGPushRegisterResult_ == null)
				cb_onRegisterResult_Landroid_content_Context_ILcom_tencent_android_tpush_XGPushRegisterResult_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int, IntPtr>) n_OnRegisterResult_Landroid_content_Context_ILcom_tencent_android_tpush_XGPushRegisterResult_);
			return cb_onRegisterResult_Landroid_content_Context_ILcom_tencent_android_tpush_XGPushRegisterResult_;
		}

		static void n_OnRegisterResult_Landroid_content_Context_ILcom_tencent_android_tpush_XGPushRegisterResult_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, IntPtr native_p2)
		{
			global::Com.Tencent.Android.Tpush.XGPushBaseReceiver __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Android.Tpush.XGPushBaseReceiver> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Tencent.Android.Tpush.XGPushRegisterResult p2 = global::Java.Lang.Object.GetObject<global::Com.Tencent.Android.Tpush.XGPushRegisterResult> (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.OnRegisterResult (p0, p1, p2);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.android.tpush']/class[@name='XGPushBaseReceiver']/method[@name='onRegisterResult' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='int'] and parameter[3][@type='com.tencent.android.tpush.XGPushRegisterResult']]"
		[Register ("onRegisterResult", "(Landroid/content/Context;ILcom/tencent/android/tpush/XGPushRegisterResult;)V", "GetOnRegisterResult_Landroid_content_Context_ILcom_tencent_android_tpush_XGPushRegisterResult_Handler")]
		public abstract void OnRegisterResult (global::Android.Content.Context p0, int p1, global::Com.Tencent.Android.Tpush.XGPushRegisterResult p2);

		static Delegate cb_onSetTagResult_Landroid_content_Context_ILjava_lang_String_;
#pragma warning disable 0169
		static Delegate GetOnSetTagResult_Landroid_content_Context_ILjava_lang_String_Handler ()
		{
			if (cb_onSetTagResult_Landroid_content_Context_ILjava_lang_String_ == null)
				cb_onSetTagResult_Landroid_content_Context_ILjava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int, IntPtr>) n_OnSetTagResult_Landroid_content_Context_ILjava_lang_String_);
			return cb_onSetTagResult_Landroid_content_Context_ILjava_lang_String_;
		}

		static void n_OnSetTagResult_Landroid_content_Context_ILjava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, IntPtr native_p2)
		{
			global::Com.Tencent.Android.Tpush.XGPushBaseReceiver __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Android.Tpush.XGPushBaseReceiver> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.OnSetTagResult (p0, p1, p2);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.android.tpush']/class[@name='XGPushBaseReceiver']/method[@name='onSetTagResult' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='int'] and parameter[3][@type='java.lang.String']]"
		[Register ("onSetTagResult", "(Landroid/content/Context;ILjava/lang/String;)V", "GetOnSetTagResult_Landroid_content_Context_ILjava_lang_String_Handler")]
		public abstract void OnSetTagResult (global::Android.Content.Context p0, int p1, string p2);

		static Delegate cb_onTextMessage_Landroid_content_Context_Lcom_tencent_android_tpush_XGPushTextMessage_;
#pragma warning disable 0169
		static Delegate GetOnTextMessage_Landroid_content_Context_Lcom_tencent_android_tpush_XGPushTextMessage_Handler ()
		{
			if (cb_onTextMessage_Landroid_content_Context_Lcom_tencent_android_tpush_XGPushTextMessage_ == null)
				cb_onTextMessage_Landroid_content_Context_Lcom_tencent_android_tpush_XGPushTextMessage_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnTextMessage_Landroid_content_Context_Lcom_tencent_android_tpush_XGPushTextMessage_);
			return cb_onTextMessage_Landroid_content_Context_Lcom_tencent_android_tpush_XGPushTextMessage_;
		}

		static void n_OnTextMessage_Landroid_content_Context_Lcom_tencent_android_tpush_XGPushTextMessage_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Tencent.Android.Tpush.XGPushBaseReceiver __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Android.Tpush.XGPushBaseReceiver> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Tencent.Android.Tpush.XGPushTextMessage p1 = global::Java.Lang.Object.GetObject<global::Com.Tencent.Android.Tpush.XGPushTextMessage> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.OnTextMessage (p0, p1);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.android.tpush']/class[@name='XGPushBaseReceiver']/method[@name='onTextMessage' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='com.tencent.android.tpush.XGPushTextMessage']]"
		[Register ("onTextMessage", "(Landroid/content/Context;Lcom/tencent/android/tpush/XGPushTextMessage;)V", "GetOnTextMessage_Landroid_content_Context_Lcom_tencent_android_tpush_XGPushTextMessage_Handler")]
		public abstract void OnTextMessage (global::Android.Content.Context p0, global::Com.Tencent.Android.Tpush.XGPushTextMessage p1);

		static Delegate cb_onUnregisterResult_Landroid_content_Context_I;
#pragma warning disable 0169
		static Delegate GetOnUnregisterResult_Landroid_content_Context_IHandler ()
		{
			if (cb_onUnregisterResult_Landroid_content_Context_I == null)
				cb_onUnregisterResult_Landroid_content_Context_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int>) n_OnUnregisterResult_Landroid_content_Context_I);
			return cb_onUnregisterResult_Landroid_content_Context_I;
		}

		static void n_OnUnregisterResult_Landroid_content_Context_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1)
		{
			global::Com.Tencent.Android.Tpush.XGPushBaseReceiver __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Android.Tpush.XGPushBaseReceiver> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnUnregisterResult (p0, p1);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.android.tpush']/class[@name='XGPushBaseReceiver']/method[@name='onUnregisterResult' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='int']]"
		[Register ("onUnregisterResult", "(Landroid/content/Context;I)V", "GetOnUnregisterResult_Landroid_content_Context_IHandler")]
		public abstract void OnUnregisterResult (global::Android.Content.Context p0, int p1);

	}

	[global::Android.Runtime.Register ("com/tencent/android/tpush/XGPushBaseReceiver", DoNotGenerateAcw=true)]
	internal partial class XGPushBaseReceiverInvoker : XGPushBaseReceiver {

		public XGPushBaseReceiverInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		internal    new     static  readonly    JniPeerMembers  _members    = new JniPeerMembers ("com/tencent/android/tpush/XGPushBaseReceiver", typeof (XGPushBaseReceiverInvoker));

		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.android.tpush']/class[@name='XGPushBaseReceiver']/method[@name='onDeleteTagResult' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='int'] and parameter[3][@type='java.lang.String']]"
		[Register ("onDeleteTagResult", "(Landroid/content/Context;ILjava/lang/String;)V", "GetOnDeleteTagResult_Landroid_content_Context_ILjava_lang_String_Handler")]
		public override unsafe void OnDeleteTagResult (global::Android.Content.Context p0, int p1, string p2)
		{
			const string __id = "onDeleteTagResult.(Landroid/content/Context;ILjava/lang/String;)V";
			IntPtr native_p2 = JNIEnv.NewString (p2);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (p1);
				__args [2] = new JniArgumentValue (native_p2);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.android.tpush']/class[@name='XGPushBaseReceiver']/method[@name='onNotifactionClickedResult' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='com.tencent.android.tpush.XGPushClickedResult']]"
		[Register ("onNotifactionClickedResult", "(Landroid/content/Context;Lcom/tencent/android/tpush/XGPushClickedResult;)V", "GetOnNotifactionClickedResult_Landroid_content_Context_Lcom_tencent_android_tpush_XGPushClickedResult_Handler")]
		public override unsafe void OnNotifactionClickedResult (global::Android.Content.Context p0, global::Com.Tencent.Android.Tpush.XGPushClickedResult p1)
		{
			const string __id = "onNotifactionClickedResult.(Landroid/content/Context;Lcom/tencent/android/tpush/XGPushClickedResult;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.android.tpush']/class[@name='XGPushBaseReceiver']/method[@name='onNotifactionShowedResult' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='com.tencent.android.tpush.XGPushShowedResult']]"
		[Register ("onNotifactionShowedResult", "(Landroid/content/Context;Lcom/tencent/android/tpush/XGPushShowedResult;)V", "GetOnNotifactionShowedResult_Landroid_content_Context_Lcom_tencent_android_tpush_XGPushShowedResult_Handler")]
		public override unsafe void OnNotifactionShowedResult (global::Android.Content.Context p0, global::Com.Tencent.Android.Tpush.XGPushShowedResult p1)
		{
			const string __id = "onNotifactionShowedResult.(Landroid/content/Context;Lcom/tencent/android/tpush/XGPushShowedResult;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.android.tpush']/class[@name='XGPushBaseReceiver']/method[@name='onRegisterResult' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='int'] and parameter[3][@type='com.tencent.android.tpush.XGPushRegisterResult']]"
		[Register ("onRegisterResult", "(Landroid/content/Context;ILcom/tencent/android/tpush/XGPushRegisterResult;)V", "GetOnRegisterResult_Landroid_content_Context_ILcom_tencent_android_tpush_XGPushRegisterResult_Handler")]
		public override unsafe void OnRegisterResult (global::Android.Content.Context p0, int p1, global::Com.Tencent.Android.Tpush.XGPushRegisterResult p2)
		{
			const string __id = "onRegisterResult.(Landroid/content/Context;ILcom/tencent/android/tpush/XGPushRegisterResult;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (p1);
				__args [2] = new JniArgumentValue ((p2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p2).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.android.tpush']/class[@name='XGPushBaseReceiver']/method[@name='onSetTagResult' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='int'] and parameter[3][@type='java.lang.String']]"
		[Register ("onSetTagResult", "(Landroid/content/Context;ILjava/lang/String;)V", "GetOnSetTagResult_Landroid_content_Context_ILjava_lang_String_Handler")]
		public override unsafe void OnSetTagResult (global::Android.Content.Context p0, int p1, string p2)
		{
			const string __id = "onSetTagResult.(Landroid/content/Context;ILjava/lang/String;)V";
			IntPtr native_p2 = JNIEnv.NewString (p2);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (p1);
				__args [2] = new JniArgumentValue (native_p2);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.android.tpush']/class[@name='XGPushBaseReceiver']/method[@name='onTextMessage' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='com.tencent.android.tpush.XGPushTextMessage']]"
		[Register ("onTextMessage", "(Landroid/content/Context;Lcom/tencent/android/tpush/XGPushTextMessage;)V", "GetOnTextMessage_Landroid_content_Context_Lcom_tencent_android_tpush_XGPushTextMessage_Handler")]
		public override unsafe void OnTextMessage (global::Android.Content.Context p0, global::Com.Tencent.Android.Tpush.XGPushTextMessage p1)
		{
			const string __id = "onTextMessage.(Landroid/content/Context;Lcom/tencent/android/tpush/XGPushTextMessage;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.android.tpush']/class[@name='XGPushBaseReceiver']/method[@name='onUnregisterResult' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='int']]"
		[Register ("onUnregisterResult", "(Landroid/content/Context;I)V", "GetOnUnregisterResult_Landroid_content_Context_IHandler")]
		public override unsafe void OnUnregisterResult (global::Android.Content.Context p0, int p1)
		{
			const string __id = "onUnregisterResult.(Landroid/content/Context;I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (p1);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
			}
		}

	}

}
