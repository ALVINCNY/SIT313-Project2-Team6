using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Tencent.Android.Tpush.Horse.Data {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.tencent.android.tpush.horse.data']/class[@name='ServerItem']"
	[global::Android.Runtime.Register ("com/tencent/android/tpush/horse/data/ServerItem", DoNotGenerateAcw=true)]
	public partial class ServerItem : global::Java.Lang.Object, global::Java.IO.ISerializable {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/tencent/android/tpush/horse/data/ServerItem", typeof (ServerItem));
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

		protected ServerItem (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.tencent.android.tpush.horse.data']/class[@name='ServerItem']/constructor[@name='ServerItem' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register (".ctor", "(Ljava/lang/String;II)V", "")]
		public unsafe ServerItem (string p0, int p1, int p2)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/lang/String;II)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (p1);
				__args [2] = new JniArgumentValue (p2);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.tencent.android.tpush.horse.data']/class[@name='ServerItem']/constructor[@name='ServerItem' and count(parameter)=3 and parameter[1][@type='long'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register (".ctor", "(JII)V", "")]
		public unsafe ServerItem (long p0, int p1, int p2)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(JII)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue (p1);
				__args [2] = new JniArgumentValue (p2);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_a;
#pragma warning disable 0169
		static Delegate GetAHandler ()
		{
			if (cb_a == null)
				cb_a = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_A);
			return cb_a;
		}

		static IntPtr n_A (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Tencent.Android.Tpush.Horse.Data.ServerItem __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Android.Tpush.Horse.Data.ServerItem> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.A ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.android.tpush.horse.data']/class[@name='ServerItem']/method[@name='a' and count(parameter)=0]"
		[Register ("a", "()Ljava/lang/String;", "GetAHandler")]
		public virtual unsafe string A ()
		{
			const string __id = "a.()Ljava/lang/String;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_b;
#pragma warning disable 0169
		static Delegate GetBHandler ()
		{
			if (cb_b == null)
				cb_b = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_B);
			return cb_b;
		}

		static int n_B (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Tencent.Android.Tpush.Horse.Data.ServerItem __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Android.Tpush.Horse.Data.ServerItem> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.B ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.android.tpush.horse.data']/class[@name='ServerItem']/method[@name='b' and count(parameter)=0]"
		[Register ("b", "()I", "GetBHandler")]
		public virtual unsafe int B ()
		{
			const string __id = "b.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_c;
#pragma warning disable 0169
		static Delegate GetCHandler ()
		{
			if (cb_c == null)
				cb_c = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_C);
			return cb_c;
		}

		static int n_C (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Tencent.Android.Tpush.Horse.Data.ServerItem __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Android.Tpush.Horse.Data.ServerItem> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.C ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.android.tpush.horse.data']/class[@name='ServerItem']/method[@name='c' and count(parameter)=0]"
		[Register ("c", "()I", "GetCHandler")]
		public virtual unsafe int C ()
		{
			const string __id = "c.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

	}
}
