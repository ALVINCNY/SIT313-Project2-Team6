using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Tencent.Android.Tpush.Service {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.tencent.android.tpush.service']/class[@name='XGPushServiceV3']"
	[global::Android.Runtime.Register ("com/tencent/android/tpush/service/XGPushServiceV3", DoNotGenerateAcw=true)]
	public partial class XGPushServiceV3 : global::Android.App.Service {



		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.android.tpush.service']/class[@name='XGPushServiceV3']/field[@name='c']"
		[Register ("c")]
		public static global::Org.Json.JSONArray C {
			get {
				const string __id = "c.Lorg/json/JSONArray;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Org.Json.JSONArray> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "c.Lorg/json/JSONArray;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.StaticFields.SetValue (__id, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/tencent/android/tpush/service/XGPushServiceV3", typeof (XGPushServiceV3));
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

		protected XGPushServiceV3 (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.tencent.android.tpush.service']/class[@name='XGPushServiceV3']/constructor[@name='XGPushServiceV3' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe XGPushServiceV3 ()
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

		static Delegate cb_a;
#pragma warning disable 0169
		static Delegate GetAHandler ()
		{
			if (cb_a == null)
				cb_a = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_A);
			return cb_a;
		}

		static void n_A (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Tencent.Android.Tpush.Service.XGPushServiceV3 __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Android.Tpush.Service.XGPushServiceV3> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.A ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.android.tpush.service']/class[@name='XGPushServiceV3']/method[@name='a' and count(parameter)=0]"
		[Register ("a", "()V", "GetAHandler")]
		public virtual unsafe void A ()
		{
			const string __id = "a.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.android.tpush.service']/class[@name='XGPushServiceV3']/method[@name='b' and count(parameter)=0]"
		[Register ("b", "()Landroid/app/Service;", "")]
		public static unsafe global::Android.App.Service B ()
		{
			const string __id = "b.()Landroid/app/Service;";
			try {
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
				return global::Java.Lang.Object.GetObject<global::Android.App.Service> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_onBind_Landroid_content_Intent_;
#pragma warning disable 0169
		static Delegate GetOnBind_Landroid_content_Intent_Handler ()
		{
			if (cb_onBind_Landroid_content_Intent_ == null)
				cb_onBind_Landroid_content_Intent_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnBind_Landroid_content_Intent_);
			return cb_onBind_Landroid_content_Intent_;
		}

		static IntPtr n_OnBind_Landroid_content_Intent_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Tencent.Android.Tpush.Service.XGPushServiceV3 __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Android.Tpush.Service.XGPushServiceV3> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Intent p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Intent> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.OnBind (p0));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.android.tpush.service']/class[@name='XGPushServiceV3']/method[@name='onBind' and count(parameter)=1 and parameter[1][@type='android.content.Intent']]"
		[Register ("onBind", "(Landroid/content/Intent;)Landroid/os/IBinder;", "GetOnBind_Landroid_content_Intent_Handler")]
		public override unsafe global::Android.OS.IBinder OnBind (global::Android.Content.Intent p0)
		{
			const string __id = "onBind.(Landroid/content/Intent;)Landroid/os/IBinder;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Android.OS.IBinder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
