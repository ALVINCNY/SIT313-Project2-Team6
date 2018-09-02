using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Tencent.Android.Tpush {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.tencent.android.tpush']/interface[@name='XGIOperateCallback']"
	[Register ("com/tencent/android/tpush/XGIOperateCallback", "", "Com.Tencent.Android.Tpush.IXGIOperateCallbackInvoker")]
	public partial interface IXGIOperateCallback : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.android.tpush']/interface[@name='XGIOperateCallback']/method[@name='onFail' and count(parameter)=3 and parameter[1][@type='java.lang.Object'] and parameter[2][@type='int'] and parameter[3][@type='java.lang.String']]"
		[Register ("onFail", "(Ljava/lang/Object;ILjava/lang/String;)V", "GetOnFail_Ljava_lang_Object_ILjava_lang_String_Handler:Com.Tencent.Android.Tpush.IXGIOperateCallbackInvoker, XgPush.Android")]
		void OnFail (global::Java.Lang.Object p0, int p1, string p2);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.android.tpush']/interface[@name='XGIOperateCallback']/method[@name='onSuccess' and count(parameter)=2 and parameter[1][@type='java.lang.Object'] and parameter[2][@type='int']]"
		[Register ("onSuccess", "(Ljava/lang/Object;I)V", "GetOnSuccess_Ljava_lang_Object_IHandler:Com.Tencent.Android.Tpush.IXGIOperateCallbackInvoker, XgPush.Android")]
		void OnSuccess (global::Java.Lang.Object p0, int p1);

	}

	[global::Android.Runtime.Register ("com/tencent/android/tpush/XGIOperateCallback", DoNotGenerateAcw=true)]
	internal class IXGIOperateCallbackInvoker : global::Java.Lang.Object, IXGIOperateCallback {

		internal    new     static  readonly    JniPeerMembers  _members    = new JniPeerMembers ("com/tencent/android/tpush/XGIOperateCallback", typeof (IXGIOperateCallbackInvoker));

		static IntPtr java_class_ref {
			get { return _members.JniPeerType.PeerReference.Handle; }
		}

		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		IntPtr class_ref;

		public static IXGIOperateCallback GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IXGIOperateCallback> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.tencent.android.tpush.XGIOperateCallback"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IXGIOperateCallbackInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onFail_Ljava_lang_Object_ILjava_lang_String_;
#pragma warning disable 0169
		static Delegate GetOnFail_Ljava_lang_Object_ILjava_lang_String_Handler ()
		{
			if (cb_onFail_Ljava_lang_Object_ILjava_lang_String_ == null)
				cb_onFail_Ljava_lang_Object_ILjava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int, IntPtr>) n_OnFail_Ljava_lang_Object_ILjava_lang_String_);
			return cb_onFail_Ljava_lang_Object_ILjava_lang_String_;
		}

		static void n_OnFail_Ljava_lang_Object_ILjava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, IntPtr native_p2)
		{
			global::Com.Tencent.Android.Tpush.IXGIOperateCallback __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Android.Tpush.IXGIOperateCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.OnFail (p0, p1, p2);
		}
#pragma warning restore 0169

		IntPtr id_onFail_Ljava_lang_Object_ILjava_lang_String_;
		public unsafe void OnFail (global::Java.Lang.Object p0, int p1, string p2)
		{
			if (id_onFail_Ljava_lang_Object_ILjava_lang_String_ == IntPtr.Zero)
				id_onFail_Ljava_lang_Object_ILjava_lang_String_ = JNIEnv.GetMethodID (class_ref, "onFail", "(Ljava/lang/Object;ILjava/lang/String;)V");
			IntPtr native_p2 = JNIEnv.NewString (p2);
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			__args [1] = new JValue (p1);
			__args [2] = new JValue (native_p2);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onFail_Ljava_lang_Object_ILjava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p2);
		}

		static Delegate cb_onSuccess_Ljava_lang_Object_I;
#pragma warning disable 0169
		static Delegate GetOnSuccess_Ljava_lang_Object_IHandler ()
		{
			if (cb_onSuccess_Ljava_lang_Object_I == null)
				cb_onSuccess_Ljava_lang_Object_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int>) n_OnSuccess_Ljava_lang_Object_I);
			return cb_onSuccess_Ljava_lang_Object_I;
		}

		static void n_OnSuccess_Ljava_lang_Object_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1)
		{
			global::Com.Tencent.Android.Tpush.IXGIOperateCallback __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Android.Tpush.IXGIOperateCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnSuccess (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_onSuccess_Ljava_lang_Object_I;
		public unsafe void OnSuccess (global::Java.Lang.Object p0, int p1)
		{
			if (id_onSuccess_Ljava_lang_Object_I == IntPtr.Zero)
				id_onSuccess_Ljava_lang_Object_I = JNIEnv.GetMethodID (class_ref, "onSuccess", "(Ljava/lang/Object;I)V");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			__args [1] = new JValue (p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onSuccess_Ljava_lang_Object_I, __args);
		}

	}

}
