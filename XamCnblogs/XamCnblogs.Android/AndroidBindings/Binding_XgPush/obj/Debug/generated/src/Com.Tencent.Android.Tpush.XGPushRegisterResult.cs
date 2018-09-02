using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Tencent.Android.Tpush {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.tencent.android.tpush']/class[@name='XGPushRegisterResult']"
	[global::Android.Runtime.Register ("com/tencent/android/tpush/XGPushRegisterResult", DoNotGenerateAcw=true)]
	public partial class XGPushRegisterResult : global::Java.Lang.Object, global::Com.Tencent.Android.Tpush.IXGIResult {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/tencent/android/tpush/XGPushRegisterResult", typeof (XGPushRegisterResult));
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

		protected XGPushRegisterResult (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static Delegate cb_getAccessId;
#pragma warning disable 0169
		static Delegate GetGetAccessIdHandler ()
		{
			if (cb_getAccessId == null)
				cb_getAccessId = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetAccessId);
			return cb_getAccessId;
		}

		static long n_GetAccessId (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Tencent.Android.Tpush.XGPushRegisterResult __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Android.Tpush.XGPushRegisterResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.AccessId;
		}
#pragma warning restore 0169

		public virtual unsafe long AccessId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.android.tpush']/class[@name='XGPushRegisterResult']/method[@name='getAccessId' and count(parameter)=0]"
			[Register ("getAccessId", "()J", "GetGetAccessIdHandler")]
			get {
				const string __id = "getAccessId.()J";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt64Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getAccount;
#pragma warning disable 0169
		static Delegate GetGetAccountHandler ()
		{
			if (cb_getAccount == null)
				cb_getAccount = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAccount);
			return cb_getAccount;
		}

		static IntPtr n_GetAccount (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Tencent.Android.Tpush.XGPushRegisterResult __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Android.Tpush.XGPushRegisterResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Account);
		}
#pragma warning restore 0169

		public virtual unsafe string Account {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.android.tpush']/class[@name='XGPushRegisterResult']/method[@name='getAccount' and count(parameter)=0]"
			[Register ("getAccount", "()Ljava/lang/String;", "GetGetAccountHandler")]
			get {
				const string __id = "getAccount.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getDeviceId;
#pragma warning disable 0169
		static Delegate GetGetDeviceIdHandler ()
		{
			if (cb_getDeviceId == null)
				cb_getDeviceId = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetDeviceId);
			return cb_getDeviceId;
		}

		static IntPtr n_GetDeviceId (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Tencent.Android.Tpush.XGPushRegisterResult __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Android.Tpush.XGPushRegisterResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.DeviceId);
		}
#pragma warning restore 0169

		public virtual unsafe string DeviceId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.android.tpush']/class[@name='XGPushRegisterResult']/method[@name='getDeviceId' and count(parameter)=0]"
			[Register ("getDeviceId", "()Ljava/lang/String;", "GetGetDeviceIdHandler")]
			get {
				const string __id = "getDeviceId.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getTicket;
#pragma warning disable 0169
		static Delegate GetGetTicketHandler ()
		{
			if (cb_getTicket == null)
				cb_getTicket = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetTicket);
			return cb_getTicket;
		}

		static IntPtr n_GetTicket (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Tencent.Android.Tpush.XGPushRegisterResult __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Android.Tpush.XGPushRegisterResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Ticket);
		}
#pragma warning restore 0169

		public virtual unsafe string Ticket {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.android.tpush']/class[@name='XGPushRegisterResult']/method[@name='getTicket' and count(parameter)=0]"
			[Register ("getTicket", "()Ljava/lang/String;", "GetGetTicketHandler")]
			get {
				const string __id = "getTicket.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getTicketType;
#pragma warning disable 0169
		static Delegate GetGetTicketTypeHandler ()
		{
			if (cb_getTicketType == null)
				cb_getTicketType = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, short>) n_GetTicketType);
			return cb_getTicketType;
		}

		static short n_GetTicketType (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Tencent.Android.Tpush.XGPushRegisterResult __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Android.Tpush.XGPushRegisterResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.TicketType;
		}
#pragma warning restore 0169

		public virtual unsafe short TicketType {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.android.tpush']/class[@name='XGPushRegisterResult']/method[@name='getTicketType' and count(parameter)=0]"
			[Register ("getTicketType", "()S", "GetGetTicketTypeHandler")]
			get {
				const string __id = "getTicketType.()S";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt16Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getToken;
#pragma warning disable 0169
		static Delegate GetGetTokenHandler ()
		{
			if (cb_getToken == null)
				cb_getToken = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetToken);
			return cb_getToken;
		}

		static IntPtr n_GetToken (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Tencent.Android.Tpush.XGPushRegisterResult __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Android.Tpush.XGPushRegisterResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Token);
		}
#pragma warning restore 0169

		public virtual unsafe string Token {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.android.tpush']/class[@name='XGPushRegisterResult']/method[@name='getToken' and count(parameter)=0]"
			[Register ("getToken", "()Ljava/lang/String;", "GetGetTokenHandler")]
			get {
				const string __id = "getToken.()Ljava/lang/String;";
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
			global::Com.Tencent.Android.Tpush.XGPushRegisterResult __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Android.Tpush.XGPushRegisterResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Intent p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Intent> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ParseIntent (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.android.tpush']/class[@name='XGPushRegisterResult']/method[@name='parseIntent' and count(parameter)=1 and parameter[1][@type='android.content.Intent']]"
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

		static Delegate cb_toJson;
#pragma warning disable 0169
		static Delegate GetToJsonHandler ()
		{
			if (cb_toJson == null)
				cb_toJson = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_ToJson);
			return cb_toJson;
		}

		static IntPtr n_ToJson (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Tencent.Android.Tpush.XGPushRegisterResult __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Android.Tpush.XGPushRegisterResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ToJson ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.android.tpush']/class[@name='XGPushRegisterResult']/method[@name='toJson' and count(parameter)=0]"
		[Register ("toJson", "()Lorg/json/JSONObject;", "GetToJsonHandler")]
		public virtual unsafe global::Org.Json.JSONObject ToJson ()
		{
			const string __id = "toJson.()Lorg/json/JSONObject;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Org.Json.JSONObject> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
