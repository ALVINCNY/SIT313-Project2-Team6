using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Tencent.Android.Tpush {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.tencent.android.tpush']/interface[@name='XGPushNotifactionCallback']"
	[Register ("com/tencent/android/tpush/XGPushNotifactionCallback", "", "Com.Tencent.Android.Tpush.IXGPushNotifactionCallbackInvoker")]
	public partial interface IXGPushNotifactionCallback : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.android.tpush']/interface[@name='XGPushNotifactionCallback']/method[@name='handleNotify' and count(parameter)=1 and parameter[1][@type='com.tencent.android.tpush.XGNotifaction']]"
		[Register ("handleNotify", "(Lcom/tencent/android/tpush/XGNotifaction;)V", "GetHandleNotify_Lcom_tencent_android_tpush_XGNotifaction_Handler:Com.Tencent.Android.Tpush.IXGPushNotifactionCallbackInvoker, XgPush.Android")]
		void HandleNotify (global::Com.Tencent.Android.Tpush.XGNotifaction p0);

	}

	[global::Android.Runtime.Register ("com/tencent/android/tpush/XGPushNotifactionCallback", DoNotGenerateAcw=true)]
	internal class IXGPushNotifactionCallbackInvoker : global::Java.Lang.Object, IXGPushNotifactionCallback {

		internal    new     static  readonly    JniPeerMembers  _members    = new JniPeerMembers ("com/tencent/android/tpush/XGPushNotifactionCallback", typeof (IXGPushNotifactionCallbackInvoker));

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

		public static IXGPushNotifactionCallback GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IXGPushNotifactionCallback> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.tencent.android.tpush.XGPushNotifactionCallback"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IXGPushNotifactionCallbackInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_handleNotify_Lcom_tencent_android_tpush_XGNotifaction_;
#pragma warning disable 0169
		static Delegate GetHandleNotify_Lcom_tencent_android_tpush_XGNotifaction_Handler ()
		{
			if (cb_handleNotify_Lcom_tencent_android_tpush_XGNotifaction_ == null)
				cb_handleNotify_Lcom_tencent_android_tpush_XGNotifaction_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_HandleNotify_Lcom_tencent_android_tpush_XGNotifaction_);
			return cb_handleNotify_Lcom_tencent_android_tpush_XGNotifaction_;
		}

		static void n_HandleNotify_Lcom_tencent_android_tpush_XGNotifaction_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Tencent.Android.Tpush.IXGPushNotifactionCallback __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Android.Tpush.IXGPushNotifactionCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Tencent.Android.Tpush.XGNotifaction p0 = global::Java.Lang.Object.GetObject<global::Com.Tencent.Android.Tpush.XGNotifaction> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.HandleNotify (p0);
		}
#pragma warning restore 0169

		IntPtr id_handleNotify_Lcom_tencent_android_tpush_XGNotifaction_;
		public unsafe void HandleNotify (global::Com.Tencent.Android.Tpush.XGNotifaction p0)
		{
			if (id_handleNotify_Lcom_tencent_android_tpush_XGNotifaction_ == IntPtr.Zero)
				id_handleNotify_Lcom_tencent_android_tpush_XGNotifaction_ = JNIEnv.GetMethodID (class_ref, "handleNotify", "(Lcom/tencent/android/tpush/XGNotifaction;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_handleNotify_Lcom_tencent_android_tpush_XGNotifaction_, __args);
		}

	}

}
