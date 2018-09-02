using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Tencent.Android.Tpush {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.tencent.android.tpush']/interface[@name='XGIResult']"
	[Register ("com/tencent/android/tpush/XGIResult", "", "Com.Tencent.Android.Tpush.IXGIResultInvoker")]
	public partial interface IXGIResult : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.android.tpush']/interface[@name='XGIResult']/method[@name='parseIntent' and count(parameter)=1 and parameter[1][@type='android.content.Intent']]"
		[Register ("parseIntent", "(Landroid/content/Intent;)V", "GetParseIntent_Landroid_content_Intent_Handler:Com.Tencent.Android.Tpush.IXGIResultInvoker, XgPush.Android")]
		void ParseIntent (global::Android.Content.Intent p0);

	}

	[global::Android.Runtime.Register ("com/tencent/android/tpush/XGIResult", DoNotGenerateAcw=true)]
	internal class IXGIResultInvoker : global::Java.Lang.Object, IXGIResult {

		internal    new     static  readonly    JniPeerMembers  _members    = new JniPeerMembers ("com/tencent/android/tpush/XGIResult", typeof (IXGIResultInvoker));

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

		public static IXGIResult GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IXGIResult> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.tencent.android.tpush.XGIResult"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IXGIResultInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
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
			global::Com.Tencent.Android.Tpush.IXGIResult __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Android.Tpush.IXGIResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Intent p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Intent> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ParseIntent (p0);
		}
#pragma warning restore 0169

		IntPtr id_parseIntent_Landroid_content_Intent_;
		public unsafe void ParseIntent (global::Android.Content.Intent p0)
		{
			if (id_parseIntent_Landroid_content_Intent_ == IntPtr.Zero)
				id_parseIntent_Landroid_content_Intent_ = JNIEnv.GetMethodID (class_ref, "parseIntent", "(Landroid/content/Intent;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_parseIntent_Landroid_content_Intent_, __args);
		}

	}

}
