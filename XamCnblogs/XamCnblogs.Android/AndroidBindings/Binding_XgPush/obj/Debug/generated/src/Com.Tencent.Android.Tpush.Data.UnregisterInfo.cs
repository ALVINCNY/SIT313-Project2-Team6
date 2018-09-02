using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Tencent.Android.Tpush.Data {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.tencent.android.tpush.data']/class[@name='UnregisterInfo']"
	[global::Android.Runtime.Register ("com/tencent/android/tpush/data/UnregisterInfo", DoNotGenerateAcw=true)]
	public partial class UnregisterInfo : global::Java.Lang.Object, global::Java.IO.ISerializable {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.android.tpush.data']/class[@name='UnregisterInfo']/field[@name='TYPE_UNINSTALL']"
		[Register ("TYPE_UNINSTALL")]
		public const sbyte TypeUninstall = (sbyte) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.android.tpush.data']/class[@name='UnregisterInfo']/field[@name='TYPE_UNREGISTER']"
		[Register ("TYPE_UNREGISTER")]
		public const sbyte TypeUnregister = (sbyte) 0;


		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.android.tpush.data']/class[@name='UnregisterInfo']/field[@name='accessId']"
		[Register ("accessId")]
		public long AccessId {
			get {
				const string __id = "accessId.J";

				var __v = _members.InstanceFields.GetInt64Value (__id, this);
				return __v;
			}
			set {
				const string __id = "accessId.J";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.android.tpush.data']/class[@name='UnregisterInfo']/field[@name='accessKey']"
		[Register ("accessKey")]
		public string AccessKey {
			get {
				const string __id = "accessKey.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "accessKey.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.android.tpush.data']/class[@name='UnregisterInfo']/field[@name='appCert']"
		[Register ("appCert")]
		public string AppCert {
			get {
				const string __id = "appCert.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "appCert.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.android.tpush.data']/class[@name='UnregisterInfo']/field[@name='isUninstall']"
		[Register ("isUninstall")]
		public sbyte IsUninstall {
			get {
				const string __id = "isUninstall.B";

				var __v = _members.InstanceFields.GetSByteValue (__id, this);
				return __v;
			}
			set {
				const string __id = "isUninstall.B";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.android.tpush.data']/class[@name='UnregisterInfo']/field[@name='option']"
		[Register ("option")]
		public string Option {
			get {
				const string __id = "option.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "option.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.android.tpush.data']/class[@name='UnregisterInfo']/field[@name='packName']"
		[Register ("packName")]
		public string PackName {
			get {
				const string __id = "packName.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "packName.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.android.tpush.data']/class[@name='UnregisterInfo']/field[@name='timestamp']"
		[Register ("timestamp")]
		public long Timestamp {
			get {
				const string __id = "timestamp.J";

				var __v = _members.InstanceFields.GetInt64Value (__id, this);
				return __v;
			}
			set {
				const string __id = "timestamp.J";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.android.tpush.data']/class[@name='UnregisterInfo']/field[@name='token']"
		[Register ("token")]
		public string Token {
			get {
				const string __id = "token.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "token.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/tencent/android/tpush/data/UnregisterInfo", typeof (UnregisterInfo));
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

		protected UnregisterInfo (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.tencent.android.tpush.data']/class[@name='UnregisterInfo']/constructor[@name='UnregisterInfo' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe UnregisterInfo ()
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

	}
}
