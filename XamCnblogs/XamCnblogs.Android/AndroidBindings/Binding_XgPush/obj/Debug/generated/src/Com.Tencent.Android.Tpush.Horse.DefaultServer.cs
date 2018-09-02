using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Tencent.Android.Tpush.Horse {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.tencent.android.tpush.horse']/class[@name='DefaultServer']"
	[global::Android.Runtime.Register ("com/tencent/android/tpush/horse/DefaultServer", DoNotGenerateAcw=true)]
	public partial class DefaultServer : global::Java.Lang.Object {



		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.android.tpush.horse']/class[@name='DefaultServer']/field[@name='c']"
		[Register ("c")]
		public static IList<string> C {
			get {
				const string __id = "c.[Ljava/lang/String;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Android.Runtime.JavaArray<string>.FromJniHandle (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "c.[Ljava/lang/String;";

				IntPtr native_value = global::Android.Runtime.JavaArray<string>.ToLocalJniHandle (value);
				try {
					_members.StaticFields.SetValue (__id, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.android.tpush.horse']/class[@name='DefaultServer']/field[@name='d']"
		[Register ("d")]
		public static IList<string> D {
			get {
				const string __id = "d.[Ljava/lang/String;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Android.Runtime.JavaArray<string>.FromJniHandle (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "d.[Ljava/lang/String;";

				IntPtr native_value = global::Android.Runtime.JavaArray<string>.ToLocalJniHandle (value);
				try {
					_members.StaticFields.SetValue (__id, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.android.tpush.horse']/class[@name='DefaultServer']/field[@name='e']"
		[Register ("e")]
		public static IList<string> E {
			get {
				const string __id = "e.[Ljava/lang/String;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Android.Runtime.JavaArray<string>.FromJniHandle (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "e.[Ljava/lang/String;";

				IntPtr native_value = global::Android.Runtime.JavaArray<string>.ToLocalJniHandle (value);
				try {
					_members.StaticFields.SetValue (__id, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.android.tpush.horse']/class[@name='DefaultServer']/field[@name='f']"
		[Register ("f")]
		public static global::Com.Tencent.Android.Tpush.Horse.DefaultServer.ENV F {
			get {
				const string __id = "f.Lcom/tencent/android/tpush/horse/DefaultServer$ENV;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Tencent.Android.Tpush.Horse.DefaultServer.ENV> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.android.tpush.horse']/class[@name='DefaultServer']/field[@name='g']"
		[Register ("g")]
		public static global::System.Collections.IList G {
			get {
				const string __id = "g.Ljava/util/ArrayList;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Android.Runtime.JavaList.FromJniHandle (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}
		// Metadata.xml XPath class reference: path="/api/package[@name='com.tencent.android.tpush.horse']/class[@name='DefaultServer.ENV']"
		[global::Android.Runtime.Register ("com/tencent/android/tpush/horse/DefaultServer$ENV", DoNotGenerateAcw=true)]
		public sealed partial class ENV : global::Java.Lang.Enum {



			// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.android.tpush.horse']/class[@name='DefaultServer.ENV']/field[@name='RELEASE']"
			[Register ("RELEASE")]
			public static global::Com.Tencent.Android.Tpush.Horse.DefaultServer.ENV Release {
				get {
					const string __id = "RELEASE.Lcom/tencent/android/tpush/horse/DefaultServer$ENV;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Tencent.Android.Tpush.Horse.DefaultServer.ENV> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/tencent/android/tpush/horse/DefaultServer$ENV", typeof (ENV));
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

			internal ENV (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.android.tpush.horse']/class[@name='DefaultServer.ENV']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/tencent/android/tpush/horse/DefaultServer$ENV;", "")]
			public static unsafe global::Com.Tencent.Android.Tpush.Horse.DefaultServer.ENV ValueOf (string p0)
			{
				const string __id = "valueOf.(Ljava/lang/String;)Lcom/tencent/android/tpush/horse/DefaultServer$ENV;";
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_p0);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Tencent.Android.Tpush.Horse.DefaultServer.ENV> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.android.tpush.horse']/class[@name='DefaultServer.ENV']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/tencent/android/tpush/horse/DefaultServer$ENV;", "")]
			public static unsafe global::Com.Tencent.Android.Tpush.Horse.DefaultServer.ENV[] Values ()
			{
				const string __id = "values.()[Lcom/tencent/android/tpush/horse/DefaultServer$ENV;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return (global::Com.Tencent.Android.Tpush.Horse.DefaultServer.ENV[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Com.Tencent.Android.Tpush.Horse.DefaultServer.ENV));
				} finally {
				}
			}

		}

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/tencent/android/tpush/horse/DefaultServer", typeof (DefaultServer));
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

		protected DefaultServer (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.android.tpush.horse']/class[@name='DefaultServer']/method[@name='a' and count(parameter)=0]"
		[Register ("a", "()I", "")]
		public static unsafe int A ()
		{
			const string __id = "a.()I";
			try {
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.android.tpush.horse']/class[@name='DefaultServer']/method[@name='a' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("a", "(Ljava/lang/String;)Ljava/util/ArrayList;", "")]
		public static unsafe global::System.Collections.IList A (string p0)
		{
			const string __id = "a.(Ljava/lang/String;)Ljava/util/ArrayList;";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Android.Runtime.JavaList.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.android.tpush.horse']/class[@name='DefaultServer']/method[@name='b' and count(parameter)=0]"
		[Register ("b", "()Ljava/util/ArrayList;", "")]
		public static unsafe global::System.Collections.IList B ()
		{
			const string __id = "b.()Ljava/util/ArrayList;";
			try {
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
				return global::Android.Runtime.JavaList.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
