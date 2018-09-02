using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Tencent.Android.Tpush.Data {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.tencent.android.tpush.data']/class[@name='MessageId']"
	[global::Android.Runtime.Register ("com/tencent/android/tpush/data/MessageId", DoNotGenerateAcw=true)]
	public partial class MessageId : global::Java.Lang.Object, global::Java.IO.ISerializable {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.android.tpush.data']/class[@name='MessageId']/field[@name='FLAG_ACK']"
		[Register ("FLAG_ACK")]
		public const short FlagAck = (short) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.android.tpush.data']/class[@name='MessageId']/field[@name='FLAG_UNACK']"
		[Register ("FLAG_UNACK")]
		public const short FlagUnack = (short) 0;


		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.android.tpush.data']/class[@name='MessageId']/field[@name='accessId']"
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


		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.android.tpush.data']/class[@name='MessageId']/field[@name='apn']"
		[Register ("apn")]
		public sbyte Apn {
			get {
				const string __id = "apn.B";

				var __v = _members.InstanceFields.GetSByteValue (__id, this);
				return __v;
			}
			set {
				const string __id = "apn.B";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.android.tpush.data']/class[@name='MessageId']/field[@name='busiMsgId']"
		[Register ("busiMsgId")]
		public long BusiMsgId {
			get {
				const string __id = "busiMsgId.J";

				var __v = _members.InstanceFields.GetInt64Value (__id, this);
				return __v;
			}
			set {
				const string __id = "busiMsgId.J";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.android.tpush.data']/class[@name='MessageId']/field[@name='date']"
		[Register ("date")]
		public string Date {
			get {
				const string __id = "date.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "date.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.android.tpush.data']/class[@name='MessageId']/field[@name='host']"
		[Register ("host")]
		public long Host {
			get {
				const string __id = "host.J";

				var __v = _members.InstanceFields.GetInt64Value (__id, this);
				return __v;
			}
			set {
				const string __id = "host.J";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.android.tpush.data']/class[@name='MessageId']/field[@name='id']"
		[Register ("id")]
		public long Id {
			get {
				const string __id = "id.J";

				var __v = _members.InstanceFields.GetInt64Value (__id, this);
				return __v;
			}
			set {
				const string __id = "id.J";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.android.tpush.data']/class[@name='MessageId']/field[@name='isAck']"
		[Register ("isAck")]
		public short IsAck {
			get {
				const string __id = "isAck.S";

				var __v = _members.InstanceFields.GetInt16Value (__id, this);
				return __v;
			}
			set {
				const string __id = "isAck.S";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.android.tpush.data']/class[@name='MessageId']/field[@name='isp']"
		[Register ("isp")]
		public sbyte Isp {
			get {
				const string __id = "isp.B";

				var __v = _members.InstanceFields.GetSByteValue (__id, this);
				return __v;
			}
			set {
				const string __id = "isp.B";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.android.tpush.data']/class[@name='MessageId']/field[@name='msgType']"
		[Register ("msgType")]
		public long MsgType {
			get {
				const string __id = "msgType.J";

				var __v = _members.InstanceFields.GetInt64Value (__id, this);
				return __v;
			}
			set {
				const string __id = "msgType.J";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.android.tpush.data']/class[@name='MessageId']/field[@name='multiPkg']"
		[Register ("multiPkg")]
		public long MultiPkg {
			get {
				const string __id = "multiPkg.J";

				var __v = _members.InstanceFields.GetInt64Value (__id, this);
				return __v;
			}
			set {
				const string __id = "multiPkg.J";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.android.tpush.data']/class[@name='MessageId']/field[@name='pact']"
		[Register ("pact")]
		public sbyte Pact {
			get {
				const string __id = "pact.B";

				var __v = _members.InstanceFields.GetSByteValue (__id, this);
				return __v;
			}
			set {
				const string __id = "pact.B";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.android.tpush.data']/class[@name='MessageId']/field[@name='pkgName']"
		[Register ("pkgName")]
		public string PkgName {
			get {
				const string __id = "pkgName.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "pkgName.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.android.tpush.data']/class[@name='MessageId']/field[@name='port']"
		[Register ("port")]
		public int Port {
			get {
				const string __id = "port.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "port.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.android.tpush.data']/class[@name='MessageId']/field[@name='pushTime']"
		[Register ("pushTime")]
		public long PushTime {
			get {
				const string __id = "pushTime.J";

				var __v = _members.InstanceFields.GetInt64Value (__id, this);
				return __v;
			}
			set {
				const string __id = "pushTime.J";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.android.tpush.data']/class[@name='MessageId']/field[@name='receivedTime']"
		[Register ("receivedTime")]
		public long ReceivedTime {
			get {
				const string __id = "receivedTime.J";

				var __v = _members.InstanceFields.GetInt64Value (__id, this);
				return __v;
			}
			set {
				const string __id = "receivedTime.J";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.android.tpush.data']/class[@name='MessageId']/field[@name='serverTime']"
		[Register ("serverTime")]
		public long ServerTime {
			get {
				const string __id = "serverTime.J";

				var __v = _members.InstanceFields.GetInt64Value (__id, this);
				return __v;
			}
			set {
				const string __id = "serverTime.J";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.android.tpush.data']/class[@name='MessageId']/field[@name='serviceHost']"
		[Register ("serviceHost")]
		public string ServiceHost {
			get {
				const string __id = "serviceHost.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "serviceHost.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.android.tpush.data']/class[@name='MessageId']/field[@name='timestamp']"
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


		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.android.tpush.data']/class[@name='MessageId']/field[@name='ttl']"
		[Register ("ttl")]
		public long Ttl {
			get {
				const string __id = "ttl.J";

				var __v = _members.InstanceFields.GetInt64Value (__id, this);
				return __v;
			}
			set {
				const string __id = "ttl.J";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}
		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/tencent/android/tpush/data/MessageId", typeof (MessageId));
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

		protected MessageId (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.tencent.android.tpush.data']/class[@name='MessageId']/constructor[@name='MessageId' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe MessageId ()
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
			global::Com.Tencent.Android.Tpush.Data.MessageId __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Android.Tpush.Data.MessageId> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.A ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.android.tpush.data']/class[@name='MessageId']/method[@name='a' and count(parameter)=0]"
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

	}
}
