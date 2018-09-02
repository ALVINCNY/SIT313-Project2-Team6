using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Tencent.Android.Tpush.Data {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.tencent.android.tpush.data']/class[@name='RegisterEntity']"
	[global::Android.Runtime.Register ("com/tencent/android/tpush/data/RegisterEntity", DoNotGenerateAcw=true)]
	public partial class RegisterEntity : global::Java.Lang.Object, global::Java.IO.ISerializable {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.android.tpush.data']/class[@name='RegisterEntity']/field[@name='TYPE_REGISTER']"
		[Register ("TYPE_REGISTER")]
		public const sbyte TypeRegister = (sbyte) 0;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.android.tpush.data']/class[@name='RegisterEntity']/field[@name='TYPE_REMOTE_UNINSTALL']"
		[Register ("TYPE_REMOTE_UNINSTALL")]
		public const sbyte TypeRemoteUninstall = (sbyte) 4;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.android.tpush.data']/class[@name='RegisterEntity']/field[@name='TYPE_REMOTE_UNREGISTER']"
		[Register ("TYPE_REMOTE_UNREGISTER")]
		public const sbyte TypeRemoteUnregister = (sbyte) 3;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.android.tpush.data']/class[@name='RegisterEntity']/field[@name='TYPE_UNINSTALL']"
		[Register ("TYPE_UNINSTALL")]
		public const sbyte TypeUninstall = (sbyte) 2;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.android.tpush.data']/class[@name='RegisterEntity']/field[@name='TYPE_UNREGISTER']"
		[Register ("TYPE_UNREGISTER")]
		public const sbyte TypeUnregister = (sbyte) 1;


		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.android.tpush.data']/class[@name='RegisterEntity']/field[@name='accessId']"
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


		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.android.tpush.data']/class[@name='RegisterEntity']/field[@name='accessKey']"
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


		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.android.tpush.data']/class[@name='RegisterEntity']/field[@name='appVersion']"
		[Register ("appVersion")]
		public string AppVersion {
			get {
				const string __id = "appVersion.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "appVersion.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.android.tpush.data']/class[@name='RegisterEntity']/field[@name='guid']"
		[Register ("guid")]
		public long Guid {
			get {
				const string __id = "guid.J";

				var __v = _members.InstanceFields.GetInt64Value (__id, this);
				return __v;
			}
			set {
				const string __id = "guid.J";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.android.tpush.data']/class[@name='RegisterEntity']/field[@name='packageName']"
		[Register ("packageName")]
		public string PackageName {
			get {
				const string __id = "packageName.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "packageName.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.android.tpush.data']/class[@name='RegisterEntity']/field[@name='state']"
		[Register ("state")]
		public int State {
			get {
				const string __id = "state.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "state.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.android.tpush.data']/class[@name='RegisterEntity']/field[@name='timestamp']"
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


		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.android.tpush.data']/class[@name='RegisterEntity']/field[@name='token']"
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


		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.android.tpush.data']/class[@name='RegisterEntity']/field[@name='xgSDKVersion']"
		[Register ("xgSDKVersion")]
		public float XgSDKVersion {
			get {
				const string __id = "xgSDKVersion.F";

				var __v = _members.InstanceFields.GetSingleValue (__id, this);
				return __v;
			}
			set {
				const string __id = "xgSDKVersion.F";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}
		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/tencent/android/tpush/data/RegisterEntity", typeof (RegisterEntity));
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

		protected RegisterEntity (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.tencent.android.tpush.data']/class[@name='RegisterEntity']/constructor[@name='RegisterEntity' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe RegisterEntity ()
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
				cb_a = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_A);
			return cb_a;
		}

		static bool n_A (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Tencent.Android.Tpush.Data.RegisterEntity __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Android.Tpush.Data.RegisterEntity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.A ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.android.tpush.data']/class[@name='RegisterEntity']/method[@name='a' and count(parameter)=0]"
		[Register ("a", "()Z", "GetAHandler")]
		public virtual unsafe bool A ()
		{
			const string __id = "a.()Z";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.android.tpush.data']/class[@name='RegisterEntity']/method[@name='a' and count(parameter)=1 and parameter[1][@type='com.tencent.android.tpush.data.RegisterEntity']]"
		[Register ("a", "(Lcom/tencent/android/tpush/data/RegisterEntity;)Ljava/lang/String;", "")]
		public static unsafe string A (global::Com.Tencent.Android.Tpush.Data.RegisterEntity p0)
		{
			const string __id = "a.(Lcom/tencent/android/tpush/data/RegisterEntity;)Ljava/lang/String;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.android.tpush.data']/class[@name='RegisterEntity']/method[@name='a' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("a", "(Ljava/lang/String;)Lcom/tencent/android/tpush/data/RegisterEntity;", "")]
		public static unsafe global::Com.Tencent.Android.Tpush.Data.RegisterEntity A (string p0)
		{
			const string __id = "a.(Ljava/lang/String;)Lcom/tencent/android/tpush/data/RegisterEntity;";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Tencent.Android.Tpush.Data.RegisterEntity> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_b;
#pragma warning disable 0169
		static Delegate GetBHandler ()
		{
			if (cb_b == null)
				cb_b = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_B);
			return cb_b;
		}

		static bool n_B (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Tencent.Android.Tpush.Data.RegisterEntity __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Android.Tpush.Data.RegisterEntity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.B ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.android.tpush.data']/class[@name='RegisterEntity']/method[@name='b' and count(parameter)=0]"
		[Register ("b", "()Z", "GetBHandler")]
		public virtual unsafe bool B ()
		{
			const string __id = "b.()Z";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_c;
#pragma warning disable 0169
		static Delegate GetCHandler ()
		{
			if (cb_c == null)
				cb_c = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_C);
			return cb_c;
		}

		static bool n_C (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Tencent.Android.Tpush.Data.RegisterEntity __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Android.Tpush.Data.RegisterEntity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.C ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.android.tpush.data']/class[@name='RegisterEntity']/method[@name='c' and count(parameter)=0]"
		[Register ("c", "()Z", "GetCHandler")]
		public virtual unsafe bool C ()
		{
			const string __id = "c.()Z";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
				return __rm;
			} finally {
			}
		}

	}
}
