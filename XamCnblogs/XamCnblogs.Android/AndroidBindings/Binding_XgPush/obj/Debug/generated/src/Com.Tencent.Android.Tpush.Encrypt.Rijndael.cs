using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Tencent.Android.Tpush.Encrypt {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.tencent.android.tpush.encrypt']/class[@name='Rijndael']"
	[global::Android.Runtime.Register ("com/tencent/android/tpush/encrypt/Rijndael", DoNotGenerateAcw=true)]
	public partial class Rijndael : global::Java.Lang.Object {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/tencent/android/tpush/encrypt/Rijndael", typeof (Rijndael));
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

		protected Rijndael (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.tencent.android.tpush.encrypt']/class[@name='Rijndael']/constructor[@name='Rijndael' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe Rijndael ()
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.android.tpush.encrypt']/class[@name='Rijndael']/method[@name='decrypt' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("decrypt", "(Ljava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string Decrypt (string p0)
		{
			const string __id = "decrypt.(Ljava/lang/String;)Ljava/lang/String;";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.android.tpush.encrypt']/class[@name='Rijndael']/method[@name='encrypt' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("encrypt", "(Ljava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string Encrypt (string p0)
		{
			const string __id = "encrypt.(Ljava/lang/String;)Ljava/lang/String;";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

	}
}
