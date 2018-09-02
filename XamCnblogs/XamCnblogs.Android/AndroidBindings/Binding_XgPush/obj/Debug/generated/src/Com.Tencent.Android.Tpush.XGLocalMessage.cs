using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Tencent.Android.Tpush {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.tencent.android.tpush']/class[@name='XGLocalMessage']"
	[global::Android.Runtime.Register ("com/tencent/android/tpush/XGLocalMessage", DoNotGenerateAcw=true)]
	public partial class XGLocalMessage : global::Java.Lang.Object {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/tencent/android/tpush/XGLocalMessage", typeof (XGLocalMessage));
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

		protected XGLocalMessage (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.tencent.android.tpush']/class[@name='XGLocalMessage']/constructor[@name='XGLocalMessage' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe XGLocalMessage ()
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

		static Delegate cb_getAction_type;
#pragma warning disable 0169
		static Delegate GetGetAction_typeHandler ()
		{
			if (cb_getAction_type == null)
				cb_getAction_type = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetAction_type);
			return cb_getAction_type;
		}

		static int n_GetAction_type (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Tencent.Android.Tpush.XGLocalMessage __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Android.Tpush.XGLocalMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Action_type;
		}
#pragma warning restore 0169

		static Delegate cb_setAction_type_I;
#pragma warning disable 0169
		static Delegate GetSetAction_type_IHandler ()
		{
			if (cb_setAction_type_I == null)
				cb_setAction_type_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetAction_type_I);
			return cb_setAction_type_I;
		}

		static void n_SetAction_type_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Tencent.Android.Tpush.XGLocalMessage __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Android.Tpush.XGLocalMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Action_type = p0;
		}
#pragma warning restore 0169

		public virtual unsafe int Action_type {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.android.tpush']/class[@name='XGLocalMessage']/method[@name='getAction_type' and count(parameter)=0]"
			[Register ("getAction_type", "()I", "GetGetAction_typeHandler")]
			get {
				const string __id = "getAction_type.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.android.tpush']/class[@name='XGLocalMessage']/method[@name='setAction_type' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setAction_type", "(I)V", "GetSetAction_type_IHandler")]
			set {
				const string __id = "setAction_type.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
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
			global::Com.Tencent.Android.Tpush.XGLocalMessage __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Android.Tpush.XGLocalMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Activity);
		}
#pragma warning restore 0169

		static Delegate cb_setActivity_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetActivity_Ljava_lang_String_Handler ()
		{
			if (cb_setActivity_Ljava_lang_String_ == null)
				cb_setActivity_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetActivity_Ljava_lang_String_);
			return cb_setActivity_Ljava_lang_String_;
		}

		static void n_SetActivity_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Tencent.Android.Tpush.XGLocalMessage __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Android.Tpush.XGLocalMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Activity = p0;
		}
#pragma warning restore 0169

		public virtual unsafe string Activity {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.android.tpush']/class[@name='XGLocalMessage']/method[@name='getActivity' and count(parameter)=0]"
			[Register ("getActivity", "()Ljava/lang/String;", "GetGetActivityHandler")]
			get {
				const string __id = "getActivity.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.android.tpush']/class[@name='XGLocalMessage']/method[@name='setActivity' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setActivity", "(Ljava/lang/String;)V", "GetSetActivity_Ljava_lang_String_Handler")]
			set {
				const string __id = "setActivity.(Ljava/lang/String;)V";
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getBuilderId;
#pragma warning disable 0169
		static Delegate GetGetBuilderIdHandler ()
		{
			if (cb_getBuilderId == null)
				cb_getBuilderId = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetBuilderId);
			return cb_getBuilderId;
		}

		static long n_GetBuilderId (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Tencent.Android.Tpush.XGLocalMessage __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Android.Tpush.XGLocalMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.BuilderId;
		}
#pragma warning restore 0169

		static Delegate cb_setBuilderId_J;
#pragma warning disable 0169
		static Delegate GetSetBuilderId_JHandler ()
		{
			if (cb_setBuilderId_J == null)
				cb_setBuilderId_J = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, long>) n_SetBuilderId_J);
			return cb_setBuilderId_J;
		}

		static void n_SetBuilderId_J (IntPtr jnienv, IntPtr native__this, long p0)
		{
			global::Com.Tencent.Android.Tpush.XGLocalMessage __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Android.Tpush.XGLocalMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.BuilderId = p0;
		}
#pragma warning restore 0169

		public virtual unsafe long BuilderId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.android.tpush']/class[@name='XGLocalMessage']/method[@name='getBuilderId' and count(parameter)=0]"
			[Register ("getBuilderId", "()J", "GetGetBuilderIdHandler")]
			get {
				const string __id = "getBuilderId.()J";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt64Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.android.tpush']/class[@name='XGLocalMessage']/method[@name='setBuilderId' and count(parameter)=1 and parameter[1][@type='long']]"
			[Register ("setBuilderId", "(J)V", "GetSetBuilderId_JHandler")]
			set {
				const string __id = "setBuilderId.(J)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getBusiMsgId;
#pragma warning disable 0169
		static Delegate GetGetBusiMsgIdHandler ()
		{
			if (cb_getBusiMsgId == null)
				cb_getBusiMsgId = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetBusiMsgId);
			return cb_getBusiMsgId;
		}

		static long n_GetBusiMsgId (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Tencent.Android.Tpush.XGLocalMessage __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Android.Tpush.XGLocalMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.BusiMsgId;
		}
#pragma warning restore 0169

		static Delegate cb_setBusiMsgId_J;
#pragma warning disable 0169
		static Delegate GetSetBusiMsgId_JHandler ()
		{
			if (cb_setBusiMsgId_J == null)
				cb_setBusiMsgId_J = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, long>) n_SetBusiMsgId_J);
			return cb_setBusiMsgId_J;
		}

		static void n_SetBusiMsgId_J (IntPtr jnienv, IntPtr native__this, long p0)
		{
			global::Com.Tencent.Android.Tpush.XGLocalMessage __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Android.Tpush.XGLocalMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.BusiMsgId = p0;
		}
#pragma warning restore 0169

		public virtual unsafe long BusiMsgId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.android.tpush']/class[@name='XGLocalMessage']/method[@name='getBusiMsgId' and count(parameter)=0]"
			[Register ("getBusiMsgId", "()J", "GetGetBusiMsgIdHandler")]
			get {
				const string __id = "getBusiMsgId.()J";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt64Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.android.tpush']/class[@name='XGLocalMessage']/method[@name='setBusiMsgId' and count(parameter)=1 and parameter[1][@type='long']]"
			[Register ("setBusiMsgId", "(J)V", "GetSetBusiMsgId_JHandler")]
			set {
				const string __id = "setBusiMsgId.(J)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
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
			global::Com.Tencent.Android.Tpush.XGLocalMessage __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Android.Tpush.XGLocalMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Content);
		}
#pragma warning restore 0169

		static Delegate cb_setContent_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetContent_Ljava_lang_String_Handler ()
		{
			if (cb_setContent_Ljava_lang_String_ == null)
				cb_setContent_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetContent_Ljava_lang_String_);
			return cb_setContent_Ljava_lang_String_;
		}

		static void n_SetContent_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Tencent.Android.Tpush.XGLocalMessage __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Android.Tpush.XGLocalMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Content = p0;
		}
#pragma warning restore 0169

		public virtual unsafe string Content {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.android.tpush']/class[@name='XGLocalMessage']/method[@name='getContent' and count(parameter)=0]"
			[Register ("getContent", "()Ljava/lang/String;", "GetGetContentHandler")]
			get {
				const string __id = "getContent.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.android.tpush']/class[@name='XGLocalMessage']/method[@name='setContent' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setContent", "(Ljava/lang/String;)V", "GetSetContent_Ljava_lang_String_Handler")]
			set {
				const string __id = "setContent.(Ljava/lang/String;)V";
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getCustom_content;
#pragma warning disable 0169
		static Delegate GetGetCustom_contentHandler ()
		{
			if (cb_getCustom_content == null)
				cb_getCustom_content = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCustom_content);
			return cb_getCustom_content;
		}

		static IntPtr n_GetCustom_content (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Tencent.Android.Tpush.XGLocalMessage __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Android.Tpush.XGLocalMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Custom_content);
		}
#pragma warning restore 0169

		public virtual unsafe string Custom_content {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.android.tpush']/class[@name='XGLocalMessage']/method[@name='getCustom_content' and count(parameter)=0]"
			[Register ("getCustom_content", "()Ljava/lang/String;", "GetGetCustom_contentHandler")]
			get {
				const string __id = "getCustom_content.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getDate;
#pragma warning disable 0169
		static Delegate GetGetDateHandler ()
		{
			if (cb_getDate == null)
				cb_getDate = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetDate);
			return cb_getDate;
		}

		static IntPtr n_GetDate (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Tencent.Android.Tpush.XGLocalMessage __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Android.Tpush.XGLocalMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Date);
		}
#pragma warning restore 0169

		static Delegate cb_setDate_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetDate_Ljava_lang_String_Handler ()
		{
			if (cb_setDate_Ljava_lang_String_ == null)
				cb_setDate_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetDate_Ljava_lang_String_);
			return cb_setDate_Ljava_lang_String_;
		}

		static void n_SetDate_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Tencent.Android.Tpush.XGLocalMessage __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Android.Tpush.XGLocalMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Date = p0;
		}
#pragma warning restore 0169

		public virtual unsafe string Date {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.android.tpush']/class[@name='XGLocalMessage']/method[@name='getDate' and count(parameter)=0]"
			[Register ("getDate", "()Ljava/lang/String;", "GetGetDateHandler")]
			get {
				const string __id = "getDate.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.android.tpush']/class[@name='XGLocalMessage']/method[@name='setDate' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setDate", "(Ljava/lang/String;)V", "GetSetDate_Ljava_lang_String_Handler")]
			set {
				const string __id = "setDate.(Ljava/lang/String;)V";
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getExpirationTimeMs;
#pragma warning disable 0169
		static Delegate GetGetExpirationTimeMsHandler ()
		{
			if (cb_getExpirationTimeMs == null)
				cb_getExpirationTimeMs = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetExpirationTimeMs);
			return cb_getExpirationTimeMs;
		}

		static long n_GetExpirationTimeMs (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Tencent.Android.Tpush.XGLocalMessage __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Android.Tpush.XGLocalMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ExpirationTimeMs;
		}
#pragma warning restore 0169

		static Delegate cb_setExpirationTimeMs_J;
#pragma warning disable 0169
		static Delegate GetSetExpirationTimeMs_JHandler ()
		{
			if (cb_setExpirationTimeMs_J == null)
				cb_setExpirationTimeMs_J = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, long>) n_SetExpirationTimeMs_J);
			return cb_setExpirationTimeMs_J;
		}

		static void n_SetExpirationTimeMs_J (IntPtr jnienv, IntPtr native__this, long p0)
		{
			global::Com.Tencent.Android.Tpush.XGLocalMessage __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Android.Tpush.XGLocalMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ExpirationTimeMs = p0;
		}
#pragma warning restore 0169

		public virtual unsafe long ExpirationTimeMs {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.android.tpush']/class[@name='XGLocalMessage']/method[@name='getExpirationTimeMs' and count(parameter)=0]"
			[Register ("getExpirationTimeMs", "()J", "GetGetExpirationTimeMsHandler")]
			get {
				const string __id = "getExpirationTimeMs.()J";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt64Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.android.tpush']/class[@name='XGLocalMessage']/method[@name='setExpirationTimeMs' and count(parameter)=1 and parameter[1][@type='long']]"
			[Register ("setExpirationTimeMs", "(J)V", "GetSetExpirationTimeMs_JHandler")]
			set {
				const string __id = "setExpirationTimeMs.(J)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getHour;
#pragma warning disable 0169
		static Delegate GetGetHourHandler ()
		{
			if (cb_getHour == null)
				cb_getHour = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetHour);
			return cb_getHour;
		}

		static IntPtr n_GetHour (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Tencent.Android.Tpush.XGLocalMessage __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Android.Tpush.XGLocalMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Hour);
		}
#pragma warning restore 0169

		static Delegate cb_setHour_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetHour_Ljava_lang_String_Handler ()
		{
			if (cb_setHour_Ljava_lang_String_ == null)
				cb_setHour_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetHour_Ljava_lang_String_);
			return cb_setHour_Ljava_lang_String_;
		}

		static void n_SetHour_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Tencent.Android.Tpush.XGLocalMessage __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Android.Tpush.XGLocalMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Hour = p0;
		}
#pragma warning restore 0169

		public virtual unsafe string Hour {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.android.tpush']/class[@name='XGLocalMessage']/method[@name='getHour' and count(parameter)=0]"
			[Register ("getHour", "()Ljava/lang/String;", "GetGetHourHandler")]
			get {
				const string __id = "getHour.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.android.tpush']/class[@name='XGLocalMessage']/method[@name='setHour' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setHour", "(Ljava/lang/String;)V", "GetSetHour_Ljava_lang_String_Handler")]
			set {
				const string __id = "setHour.(Ljava/lang/String;)V";
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getIcon_res;
#pragma warning disable 0169
		static Delegate GetGetIcon_resHandler ()
		{
			if (cb_getIcon_res == null)
				cb_getIcon_res = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetIcon_res);
			return cb_getIcon_res;
		}

		static IntPtr n_GetIcon_res (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Tencent.Android.Tpush.XGLocalMessage __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Android.Tpush.XGLocalMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Icon_res);
		}
#pragma warning restore 0169

		static Delegate cb_setIcon_res_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetIcon_res_Ljava_lang_String_Handler ()
		{
			if (cb_setIcon_res_Ljava_lang_String_ == null)
				cb_setIcon_res_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetIcon_res_Ljava_lang_String_);
			return cb_setIcon_res_Ljava_lang_String_;
		}

		static void n_SetIcon_res_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Tencent.Android.Tpush.XGLocalMessage __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Android.Tpush.XGLocalMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Icon_res = p0;
		}
#pragma warning restore 0169

		public virtual unsafe string Icon_res {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.android.tpush']/class[@name='XGLocalMessage']/method[@name='getIcon_res' and count(parameter)=0]"
			[Register ("getIcon_res", "()Ljava/lang/String;", "GetGetIcon_resHandler")]
			get {
				const string __id = "getIcon_res.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.android.tpush']/class[@name='XGLocalMessage']/method[@name='setIcon_res' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setIcon_res", "(Ljava/lang/String;)V", "GetSetIcon_res_Ljava_lang_String_Handler")]
			set {
				const string __id = "setIcon_res.(Ljava/lang/String;)V";
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getIcon_type;
#pragma warning disable 0169
		static Delegate GetGetIcon_typeHandler ()
		{
			if (cb_getIcon_type == null)
				cb_getIcon_type = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetIcon_type);
			return cb_getIcon_type;
		}

		static int n_GetIcon_type (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Tencent.Android.Tpush.XGLocalMessage __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Android.Tpush.XGLocalMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Icon_type;
		}
#pragma warning restore 0169

		static Delegate cb_setIcon_type_I;
#pragma warning disable 0169
		static Delegate GetSetIcon_type_IHandler ()
		{
			if (cb_setIcon_type_I == null)
				cb_setIcon_type_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetIcon_type_I);
			return cb_setIcon_type_I;
		}

		static void n_SetIcon_type_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Tencent.Android.Tpush.XGLocalMessage __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Android.Tpush.XGLocalMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Icon_type = p0;
		}
#pragma warning restore 0169

		public virtual unsafe int Icon_type {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.android.tpush']/class[@name='XGLocalMessage']/method[@name='getIcon_type' and count(parameter)=0]"
			[Register ("getIcon_type", "()I", "GetGetIcon_typeHandler")]
			get {
				const string __id = "getIcon_type.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.android.tpush']/class[@name='XGLocalMessage']/method[@name='setIcon_type' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setIcon_type", "(I)V", "GetSetIcon_type_IHandler")]
			set {
				const string __id = "setIcon_type.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getIntent;
#pragma warning disable 0169
		static Delegate GetGetIntentHandler ()
		{
			if (cb_getIntent == null)
				cb_getIntent = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetIntent);
			return cb_getIntent;
		}

		static IntPtr n_GetIntent (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Tencent.Android.Tpush.XGLocalMessage __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Android.Tpush.XGLocalMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Intent);
		}
#pragma warning restore 0169

		static Delegate cb_setIntent_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetIntent_Ljava_lang_String_Handler ()
		{
			if (cb_setIntent_Ljava_lang_String_ == null)
				cb_setIntent_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetIntent_Ljava_lang_String_);
			return cb_setIntent_Ljava_lang_String_;
		}

		static void n_SetIntent_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Tencent.Android.Tpush.XGLocalMessage __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Android.Tpush.XGLocalMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Intent = p0;
		}
#pragma warning restore 0169

		public virtual unsafe string Intent {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.android.tpush']/class[@name='XGLocalMessage']/method[@name='getIntent' and count(parameter)=0]"
			[Register ("getIntent", "()Ljava/lang/String;", "GetGetIntentHandler")]
			get {
				const string __id = "getIntent.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.android.tpush']/class[@name='XGLocalMessage']/method[@name='setIntent' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setIntent", "(Ljava/lang/String;)V", "GetSetIntent_Ljava_lang_String_Handler")]
			set {
				const string __id = "setIntent.(Ljava/lang/String;)V";
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getLights;
#pragma warning disable 0169
		static Delegate GetGetLightsHandler ()
		{
			if (cb_getLights == null)
				cb_getLights = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetLights);
			return cb_getLights;
		}

		static int n_GetLights (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Tencent.Android.Tpush.XGLocalMessage __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Android.Tpush.XGLocalMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Lights;
		}
#pragma warning restore 0169

		static Delegate cb_setLights_I;
#pragma warning disable 0169
		static Delegate GetSetLights_IHandler ()
		{
			if (cb_setLights_I == null)
				cb_setLights_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetLights_I);
			return cb_setLights_I;
		}

		static void n_SetLights_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Tencent.Android.Tpush.XGLocalMessage __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Android.Tpush.XGLocalMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Lights = p0;
		}
#pragma warning restore 0169

		public virtual unsafe int Lights {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.android.tpush']/class[@name='XGLocalMessage']/method[@name='getLights' and count(parameter)=0]"
			[Register ("getLights", "()I", "GetGetLightsHandler")]
			get {
				const string __id = "getLights.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.android.tpush']/class[@name='XGLocalMessage']/method[@name='setLights' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setLights", "(I)V", "GetSetLights_IHandler")]
			set {
				const string __id = "setLights.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getMin;
#pragma warning disable 0169
		static Delegate GetGetMinHandler ()
		{
			if (cb_getMin == null)
				cb_getMin = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetMin);
			return cb_getMin;
		}

		static IntPtr n_GetMin (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Tencent.Android.Tpush.XGLocalMessage __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Android.Tpush.XGLocalMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Min);
		}
#pragma warning restore 0169

		static Delegate cb_setMin_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetMin_Ljava_lang_String_Handler ()
		{
			if (cb_setMin_Ljava_lang_String_ == null)
				cb_setMin_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetMin_Ljava_lang_String_);
			return cb_setMin_Ljava_lang_String_;
		}

		static void n_SetMin_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Tencent.Android.Tpush.XGLocalMessage __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Android.Tpush.XGLocalMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Min = p0;
		}
#pragma warning restore 0169

		public virtual unsafe string Min {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.android.tpush']/class[@name='XGLocalMessage']/method[@name='getMin' and count(parameter)=0]"
			[Register ("getMin", "()Ljava/lang/String;", "GetGetMinHandler")]
			get {
				const string __id = "getMin.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.android.tpush']/class[@name='XGLocalMessage']/method[@name='setMin' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setMin", "(Ljava/lang/String;)V", "GetSetMin_Ljava_lang_String_Handler")]
			set {
				const string __id = "setMin.(Ljava/lang/String;)V";
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
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
			global::Com.Tencent.Android.Tpush.XGLocalMessage __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Android.Tpush.XGLocalMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.MsgId;
		}
#pragma warning restore 0169

		static Delegate cb_setMsgId_J;
#pragma warning disable 0169
		static Delegate GetSetMsgId_JHandler ()
		{
			if (cb_setMsgId_J == null)
				cb_setMsgId_J = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, long>) n_SetMsgId_J);
			return cb_setMsgId_J;
		}

		static void n_SetMsgId_J (IntPtr jnienv, IntPtr native__this, long p0)
		{
			global::Com.Tencent.Android.Tpush.XGLocalMessage __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Android.Tpush.XGLocalMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.MsgId = p0;
		}
#pragma warning restore 0169

		public virtual unsafe long MsgId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.android.tpush']/class[@name='XGLocalMessage']/method[@name='getMsgId' and count(parameter)=0]"
			[Register ("getMsgId", "()J", "GetGetMsgIdHandler")]
			get {
				const string __id = "getMsgId.()J";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt64Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.android.tpush']/class[@name='XGLocalMessage']/method[@name='setMsgId' and count(parameter)=1 and parameter[1][@type='long']]"
			[Register ("setMsgId", "(J)V", "GetSetMsgId_JHandler")]
			set {
				const string __id = "setMsgId.(J)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getNotificationId;
#pragma warning disable 0169
		static Delegate GetGetNotificationIdHandler ()
		{
			if (cb_getNotificationId == null)
				cb_getNotificationId = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetNotificationId);
			return cb_getNotificationId;
		}

		static int n_GetNotificationId (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Tencent.Android.Tpush.XGLocalMessage __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Android.Tpush.XGLocalMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.NotificationId;
		}
#pragma warning restore 0169

		static Delegate cb_setNotificationId_I;
#pragma warning disable 0169
		static Delegate GetSetNotificationId_IHandler ()
		{
			if (cb_setNotificationId_I == null)
				cb_setNotificationId_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetNotificationId_I);
			return cb_setNotificationId_I;
		}

		static void n_SetNotificationId_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Tencent.Android.Tpush.XGLocalMessage __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Android.Tpush.XGLocalMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.NotificationId = p0;
		}
#pragma warning restore 0169

		public virtual unsafe int NotificationId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.android.tpush']/class[@name='XGLocalMessage']/method[@name='getNotificationId' and count(parameter)=0]"
			[Register ("getNotificationId", "()I", "GetGetNotificationIdHandler")]
			get {
				const string __id = "getNotificationId.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.android.tpush']/class[@name='XGLocalMessage']/method[@name='setNotificationId' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setNotificationId", "(I)V", "GetSetNotificationId_IHandler")]
			set {
				const string __id = "setNotificationId.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getPackageDownloadUrl;
#pragma warning disable 0169
		static Delegate GetGetPackageDownloadUrlHandler ()
		{
			if (cb_getPackageDownloadUrl == null)
				cb_getPackageDownloadUrl = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetPackageDownloadUrl);
			return cb_getPackageDownloadUrl;
		}

		static IntPtr n_GetPackageDownloadUrl (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Tencent.Android.Tpush.XGLocalMessage __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Android.Tpush.XGLocalMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.PackageDownloadUrl);
		}
#pragma warning restore 0169

		static Delegate cb_setPackageDownloadUrl_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetPackageDownloadUrl_Ljava_lang_String_Handler ()
		{
			if (cb_setPackageDownloadUrl_Ljava_lang_String_ == null)
				cb_setPackageDownloadUrl_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetPackageDownloadUrl_Ljava_lang_String_);
			return cb_setPackageDownloadUrl_Ljava_lang_String_;
		}

		static void n_SetPackageDownloadUrl_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Tencent.Android.Tpush.XGLocalMessage __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Android.Tpush.XGLocalMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.PackageDownloadUrl = p0;
		}
#pragma warning restore 0169

		public virtual unsafe string PackageDownloadUrl {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.android.tpush']/class[@name='XGLocalMessage']/method[@name='getPackageDownloadUrl' and count(parameter)=0]"
			[Register ("getPackageDownloadUrl", "()Ljava/lang/String;", "GetGetPackageDownloadUrlHandler")]
			get {
				const string __id = "getPackageDownloadUrl.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.android.tpush']/class[@name='XGLocalMessage']/method[@name='setPackageDownloadUrl' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setPackageDownloadUrl", "(Ljava/lang/String;)V", "GetSetPackageDownloadUrl_Ljava_lang_String_Handler")]
			set {
				const string __id = "setPackageDownloadUrl.(Ljava/lang/String;)V";
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getPackageName;
#pragma warning disable 0169
		static Delegate GetGetPackageNameHandler ()
		{
			if (cb_getPackageName == null)
				cb_getPackageName = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetPackageName);
			return cb_getPackageName;
		}

		static IntPtr n_GetPackageName (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Tencent.Android.Tpush.XGLocalMessage __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Android.Tpush.XGLocalMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.PackageName);
		}
#pragma warning restore 0169

		static Delegate cb_setPackageName_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetPackageName_Ljava_lang_String_Handler ()
		{
			if (cb_setPackageName_Ljava_lang_String_ == null)
				cb_setPackageName_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetPackageName_Ljava_lang_String_);
			return cb_setPackageName_Ljava_lang_String_;
		}

		static void n_SetPackageName_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Tencent.Android.Tpush.XGLocalMessage __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Android.Tpush.XGLocalMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.PackageName = p0;
		}
#pragma warning restore 0169

		public virtual unsafe string PackageName {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.android.tpush']/class[@name='XGLocalMessage']/method[@name='getPackageName' and count(parameter)=0]"
			[Register ("getPackageName", "()Ljava/lang/String;", "GetGetPackageNameHandler")]
			get {
				const string __id = "getPackageName.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.android.tpush']/class[@name='XGLocalMessage']/method[@name='setPackageName' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setPackageName", "(Ljava/lang/String;)V", "GetSetPackageName_Ljava_lang_String_Handler")]
			set {
				const string __id = "setPackageName.(Ljava/lang/String;)V";
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getRing;
#pragma warning disable 0169
		static Delegate GetGetRingHandler ()
		{
			if (cb_getRing == null)
				cb_getRing = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetRing);
			return cb_getRing;
		}

		static int n_GetRing (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Tencent.Android.Tpush.XGLocalMessage __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Android.Tpush.XGLocalMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Ring;
		}
#pragma warning restore 0169

		static Delegate cb_setRing_I;
#pragma warning disable 0169
		static Delegate GetSetRing_IHandler ()
		{
			if (cb_setRing_I == null)
				cb_setRing_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetRing_I);
			return cb_setRing_I;
		}

		static void n_SetRing_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Tencent.Android.Tpush.XGLocalMessage __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Android.Tpush.XGLocalMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Ring = p0;
		}
#pragma warning restore 0169

		public virtual unsafe int Ring {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.android.tpush']/class[@name='XGLocalMessage']/method[@name='getRing' and count(parameter)=0]"
			[Register ("getRing", "()I", "GetGetRingHandler")]
			get {
				const string __id = "getRing.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.android.tpush']/class[@name='XGLocalMessage']/method[@name='setRing' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setRing", "(I)V", "GetSetRing_IHandler")]
			set {
				const string __id = "setRing.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getRing_raw;
#pragma warning disable 0169
		static Delegate GetGetRing_rawHandler ()
		{
			if (cb_getRing_raw == null)
				cb_getRing_raw = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetRing_raw);
			return cb_getRing_raw;
		}

		static IntPtr n_GetRing_raw (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Tencent.Android.Tpush.XGLocalMessage __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Android.Tpush.XGLocalMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Ring_raw);
		}
#pragma warning restore 0169

		static Delegate cb_setRing_raw_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetRing_raw_Ljava_lang_String_Handler ()
		{
			if (cb_setRing_raw_Ljava_lang_String_ == null)
				cb_setRing_raw_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetRing_raw_Ljava_lang_String_);
			return cb_setRing_raw_Ljava_lang_String_;
		}

		static void n_SetRing_raw_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Tencent.Android.Tpush.XGLocalMessage __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Android.Tpush.XGLocalMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Ring_raw = p0;
		}
#pragma warning restore 0169

		public virtual unsafe string Ring_raw {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.android.tpush']/class[@name='XGLocalMessage']/method[@name='getRing_raw' and count(parameter)=0]"
			[Register ("getRing_raw", "()Ljava/lang/String;", "GetGetRing_rawHandler")]
			get {
				const string __id = "getRing_raw.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.android.tpush']/class[@name='XGLocalMessage']/method[@name='setRing_raw' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setRing_raw", "(Ljava/lang/String;)V", "GetSetRing_raw_Ljava_lang_String_Handler")]
			set {
				const string __id = "setRing_raw.(Ljava/lang/String;)V";
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getSmall_icon;
#pragma warning disable 0169
		static Delegate GetGetSmall_iconHandler ()
		{
			if (cb_getSmall_icon == null)
				cb_getSmall_icon = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetSmall_icon);
			return cb_getSmall_icon;
		}

		static IntPtr n_GetSmall_icon (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Tencent.Android.Tpush.XGLocalMessage __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Android.Tpush.XGLocalMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Small_icon);
		}
#pragma warning restore 0169

		static Delegate cb_setSmall_icon_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetSmall_icon_Ljava_lang_String_Handler ()
		{
			if (cb_setSmall_icon_Ljava_lang_String_ == null)
				cb_setSmall_icon_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetSmall_icon_Ljava_lang_String_);
			return cb_setSmall_icon_Ljava_lang_String_;
		}

		static void n_SetSmall_icon_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Tencent.Android.Tpush.XGLocalMessage __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Android.Tpush.XGLocalMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Small_icon = p0;
		}
#pragma warning restore 0169

		public virtual unsafe string Small_icon {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.android.tpush']/class[@name='XGLocalMessage']/method[@name='getSmall_icon' and count(parameter)=0]"
			[Register ("getSmall_icon", "()Ljava/lang/String;", "GetGetSmall_iconHandler")]
			get {
				const string __id = "getSmall_icon.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.android.tpush']/class[@name='XGLocalMessage']/method[@name='setSmall_icon' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setSmall_icon", "(Ljava/lang/String;)V", "GetSetSmall_icon_Ljava_lang_String_Handler")]
			set {
				const string __id = "setSmall_icon.(Ljava/lang/String;)V";
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getStyle_id;
#pragma warning disable 0169
		static Delegate GetGetStyle_idHandler ()
		{
			if (cb_getStyle_id == null)
				cb_getStyle_id = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetStyle_id);
			return cb_getStyle_id;
		}

		static int n_GetStyle_id (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Tencent.Android.Tpush.XGLocalMessage __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Android.Tpush.XGLocalMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Style_id;
		}
#pragma warning restore 0169

		static Delegate cb_setStyle_id_I;
#pragma warning disable 0169
		static Delegate GetSetStyle_id_IHandler ()
		{
			if (cb_setStyle_id_I == null)
				cb_setStyle_id_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetStyle_id_I);
			return cb_setStyle_id_I;
		}

		static void n_SetStyle_id_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Tencent.Android.Tpush.XGLocalMessage __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Android.Tpush.XGLocalMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Style_id = p0;
		}
#pragma warning restore 0169

		public virtual unsafe int Style_id {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.android.tpush']/class[@name='XGLocalMessage']/method[@name='getStyle_id' and count(parameter)=0]"
			[Register ("getStyle_id", "()I", "GetGetStyle_idHandler")]
			get {
				const string __id = "getStyle_id.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.android.tpush']/class[@name='XGLocalMessage']/method[@name='setStyle_id' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setStyle_id", "(I)V", "GetSetStyle_id_IHandler")]
			set {
				const string __id = "setStyle_id.(I)V";
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
			global::Com.Tencent.Android.Tpush.XGLocalMessage __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Android.Tpush.XGLocalMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Title);
		}
#pragma warning restore 0169

		static Delegate cb_setTitle_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetTitle_Ljava_lang_String_Handler ()
		{
			if (cb_setTitle_Ljava_lang_String_ == null)
				cb_setTitle_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetTitle_Ljava_lang_String_);
			return cb_setTitle_Ljava_lang_String_;
		}

		static void n_SetTitle_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Tencent.Android.Tpush.XGLocalMessage __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Android.Tpush.XGLocalMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Title = p0;
		}
#pragma warning restore 0169

		public virtual unsafe string Title {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.android.tpush']/class[@name='XGLocalMessage']/method[@name='getTitle' and count(parameter)=0]"
			[Register ("getTitle", "()Ljava/lang/String;", "GetGetTitleHandler")]
			get {
				const string __id = "getTitle.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.android.tpush']/class[@name='XGLocalMessage']/method[@name='setTitle' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setTitle", "(Ljava/lang/String;)V", "GetSetTitle_Ljava_lang_String_Handler")]
			set {
				const string __id = "setTitle.(Ljava/lang/String;)V";
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getTtl;
#pragma warning disable 0169
		static Delegate GetGetTtlHandler ()
		{
			if (cb_getTtl == null)
				cb_getTtl = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetTtl);
			return cb_getTtl;
		}

		static int n_GetTtl (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Tencent.Android.Tpush.XGLocalMessage __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Android.Tpush.XGLocalMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Ttl;
		}
#pragma warning restore 0169

		public virtual unsafe int Ttl {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.android.tpush']/class[@name='XGLocalMessage']/method[@name='getTtl' and count(parameter)=0]"
			[Register ("getTtl", "()I", "GetGetTtlHandler")]
			get {
				const string __id = "getTtl.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getType;
#pragma warning disable 0169
		static Delegate GetGetTypeHandler ()
		{
			if (cb_getType == null)
				cb_getType = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetType);
			return cb_getType;
		}

		static int n_GetType (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Tencent.Android.Tpush.XGLocalMessage __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Android.Tpush.XGLocalMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Type;
		}
#pragma warning restore 0169

		static Delegate cb_setType_I;
#pragma warning disable 0169
		static Delegate GetSetType_IHandler ()
		{
			if (cb_setType_I == null)
				cb_setType_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetType_I);
			return cb_setType_I;
		}

		static void n_SetType_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Tencent.Android.Tpush.XGLocalMessage __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Android.Tpush.XGLocalMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Type = p0;
		}
#pragma warning restore 0169

		public virtual unsafe int Type {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.android.tpush']/class[@name='XGLocalMessage']/method[@name='getType' and count(parameter)=0]"
			[Register ("getType", "()I", "GetGetTypeHandler")]
			get {
				const string __id = "getType.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.android.tpush']/class[@name='XGLocalMessage']/method[@name='setType' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setType", "(I)V", "GetSetType_IHandler")]
			set {
				const string __id = "setType.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getUrl;
#pragma warning disable 0169
		static Delegate GetGetUrlHandler ()
		{
			if (cb_getUrl == null)
				cb_getUrl = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetUrl);
			return cb_getUrl;
		}

		static IntPtr n_GetUrl (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Tencent.Android.Tpush.XGLocalMessage __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Android.Tpush.XGLocalMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Url);
		}
#pragma warning restore 0169

		static Delegate cb_setUrl_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetUrl_Ljava_lang_String_Handler ()
		{
			if (cb_setUrl_Ljava_lang_String_ == null)
				cb_setUrl_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetUrl_Ljava_lang_String_);
			return cb_setUrl_Ljava_lang_String_;
		}

		static void n_SetUrl_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Tencent.Android.Tpush.XGLocalMessage __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Android.Tpush.XGLocalMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Url = p0;
		}
#pragma warning restore 0169

		public virtual unsafe string Url {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.android.tpush']/class[@name='XGLocalMessage']/method[@name='getUrl' and count(parameter)=0]"
			[Register ("getUrl", "()Ljava/lang/String;", "GetGetUrlHandler")]
			get {
				const string __id = "getUrl.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.android.tpush']/class[@name='XGLocalMessage']/method[@name='setUrl' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setUrl", "(Ljava/lang/String;)V", "GetSetUrl_Ljava_lang_String_Handler")]
			set {
				const string __id = "setUrl.(Ljava/lang/String;)V";
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getVibrate;
#pragma warning disable 0169
		static Delegate GetGetVibrateHandler ()
		{
			if (cb_getVibrate == null)
				cb_getVibrate = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetVibrate);
			return cb_getVibrate;
		}

		static int n_GetVibrate (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Tencent.Android.Tpush.XGLocalMessage __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Android.Tpush.XGLocalMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Vibrate;
		}
#pragma warning restore 0169

		static Delegate cb_setVibrate_I;
#pragma warning disable 0169
		static Delegate GetSetVibrate_IHandler ()
		{
			if (cb_setVibrate_I == null)
				cb_setVibrate_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetVibrate_I);
			return cb_setVibrate_I;
		}

		static void n_SetVibrate_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Tencent.Android.Tpush.XGLocalMessage __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Android.Tpush.XGLocalMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Vibrate = p0;
		}
#pragma warning restore 0169

		public virtual unsafe int Vibrate {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.android.tpush']/class[@name='XGLocalMessage']/method[@name='getVibrate' and count(parameter)=0]"
			[Register ("getVibrate", "()I", "GetGetVibrateHandler")]
			get {
				const string __id = "getVibrate.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.android.tpush']/class[@name='XGLocalMessage']/method[@name='setVibrate' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setVibrate", "(I)V", "GetSetVibrate_IHandler")]
			set {
				const string __id = "setVibrate.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_setCustomContent_Ljava_util_HashMap_;
#pragma warning disable 0169
		static Delegate GetSetCustomContent_Ljava_util_HashMap_Handler ()
		{
			if (cb_setCustomContent_Ljava_util_HashMap_ == null)
				cb_setCustomContent_Ljava_util_HashMap_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetCustomContent_Ljava_util_HashMap_);
			return cb_setCustomContent_Ljava_util_HashMap_;
		}

		static void n_SetCustomContent_Ljava_util_HashMap_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Tencent.Android.Tpush.XGLocalMessage __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Android.Tpush.XGLocalMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Android.Runtime.JavaDictionary.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetCustomContent (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.android.tpush']/class[@name='XGLocalMessage']/method[@name='setCustomContent' and count(parameter)=1 and parameter[1][@type='java.util.HashMap']]"
		[Register ("setCustomContent", "(Ljava/util/HashMap;)V", "GetSetCustomContent_Ljava_util_HashMap_Handler")]
		public virtual unsafe void SetCustomContent (global::System.Collections.IDictionary p0)
		{
			const string __id = "setCustomContent.(Ljava/util/HashMap;)V";
			IntPtr native_p0 = global::Android.Runtime.JavaDictionary.ToLocalJniHandle (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

	}
}
